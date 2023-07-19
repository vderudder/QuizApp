using Quizzify.Dominio;
using QuizApp.UI;
using Quizzify.IO;
using log4net;

namespace Quizzify.Facade
{
    internal class SesionFacade
    {
        private static ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private Sesion iSesion = new Sesion();
        /// <summary>
        /// Inicia el contador
        /// </summary>
        public void IniciarTiempo()
        {
            iSesion.IniciarContador();
        }

        /// <summary>
        /// Detiene el tiempo, calcula el puntaje y guarda la sesion de juego
        /// </summary>
        public SesionDTO FinalizarSesion(List<PreguntaYRespuestaDTO> pPregResElegidas, string pNombreUsuario)
        {
            // Detiene el contador de dominio
            var tiempo = iSesion.FinalizarContador();
            // Calcula el puntaje
            iSesion.Puntaje = Contexto.Instancia.LogicaExterna.CalcularPuntaje(pPregResElegidas, tiempo);
            // Obtiene usuario
            var usuario = Contexto.Instancia.UsuarioStorage.GetUsuarioByNombre(pNombreUsuario);

            // Si no existe, entonces crea el usuario
            if (usuario == null)
            {
                try
                {
                    usuario = Contexto.Instancia.UsuarioStorage.CreateUsuario(pNombreUsuario);
                    logger.Info("Operation: User saved to DB");

                }
                catch (Exception ex)
                {
                    logger.Error($"Operation: User saved to DB - Message: {ex.Message}");
                    throw;
                }
            }

            try
            {
                // Crea la sesion
                var sesion = Contexto.Instancia.SesionStorage.CreateSesion(usuario.Id, iSesion.Puntaje, iSesion.Tiempo, DateTime.Now);
                logger.Info("Operation: Game session saved to DB");


                return SesionDTO.ToDto(sesion);

            }
            catch (Exception ex)
            {
                logger.Error($"Operation: Game session saved to DB - Message: {ex.Message}");
                throw;
            }
            
        }

        /// <summary>
        /// Obtiene la lista de sesiones que entran en el ranking top 20
        /// </summary>
        /// <returns></returns>
        public List<SesionDTO> GetRanking()
        {
            try
            {
                // Obtiene el ranking de sesiones
                var sesionesList = Contexto.Instancia.SesionStorage.GetSesionesByPuntaje();

                if (sesionesList.Count > 0) { 
                    logger.Info("Operation: Get Ranking");
                }
                else {
                    logger.Warn("Operation: Get Ranking - Message: There are no sessions to show");
                }

                return sesionesList.Select(SesionDTO.ToDto).ToList();
            }
            catch (Exception ex)
            {
                logger.Error($"Operation: Get Ranking - Message: {ex.Message}");
                throw;
            }
            
        }

        
    }
}
