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
        /// Detiene el contador
        /// </summary>
        public double FinalizarTiempo()
        {
            return iSesion.FinalizarContador();
        }

        /// <summary>
        /// Calcula el puntaje
        /// </summary>
        /// <param name="pPregResElegidas"> Elecciones de respuestas de usuario</param>
        public void CalcularPuntaje(List<PreguntaYRespuestaDTO> pPregResElegidas, double pTiempo)
        {
            iSesion.Puntaje = Contexto.Instancia.LogicaExterna.CalcularPuntaje(pPregResElegidas, pTiempo);
        }

        /// <summary>
        /// Guarda la sesion de juego
        /// </summary>
        public SesionDTO GuardarSesion(string pNombreUsuario)
        {
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
