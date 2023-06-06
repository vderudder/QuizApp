using Quizzify.Dominio;
using Quizzify.Dominio.Util;
using QuizApp.UI;
using Quizzify.IO;

namespace Quizzify.Facade
{
    internal class SesionFacade
    {
        private Sesion iSesion = new Sesion();
        /// <summary>
        /// Inicia la sesion de juego, comenzando el contador
        /// </summary>
        public void IniciarTiempo()
        {
            iSesion.IniciarContador();
        }
        /// <summary>
        /// Detiene el contador
        /// </summary>
        public void FinalizarTiempo()
        {
            iSesion.FinalizarContador();
        }

        /// <summary>
        /// Guarda la sesion de juego
        /// </summary>
        public SesionDTO GuardarSesion(string pNombreUsuario, List<PreguntaYRespuestaDTO> pPregResElegidas)
        {

            // Obtiene el dto
            var usuarioDto = Contexto.iInstancia.iUsuarioStorage.GetUsuarioByNombre(pNombreUsuario);

            // Si no existe, entonces crea el usuario
            if (usuarioDto == null)
            {
                try
                {
                    usuarioDto = Contexto.iInstancia.iUsuarioStorage.CreateUsuario(pNombreUsuario);
                    Bitacora.Log($"Operation: User saved to DB\nState: Success");

                }
                catch (Exception ex)
                {
                    Bitacora.Log($"Operation: User saved to DB\nState: Error\nMessage: {ex.Message}");
                    throw;
                }
            }

            // Si existe, lo convierte a tipo Usuario
            Usuario usuario = new Usuario(usuarioDto.iId, usuarioDto.iNombre);
            List<PreguntaYRespuesta> elecciones = new List<PreguntaYRespuesta>();

            foreach (var el in pPregResElegidas)
            {
                var pregunta = new Pregunta(
                        el.iPregunta.iPregunta,
                        new Categoria(Contexto.iInstancia.iPreguntaStorage.GetCategoriaIdByNombre(el.iPregunta.iCategoriaNombre), el.iPregunta.iCategoriaNombre),
                        new Dificultad(Contexto.iInstancia.iPreguntaStorage.GetDificultadIdByNombre(el.iPregunta.iDificultadNombre), el.iPregunta.iDificultadNombre),
                        el.iPregunta.iCorrecta,
                        el.iPregunta.iIncorrectaList                    
                    );

                elecciones.Add(new PreguntaYRespuesta(pregunta, el.iRespuesta));
            }

            iSesion.CalcularPuntaje(elecciones, usuario);

            try
            {
                // Crea la sesion
                var sesionDTO = Contexto.iInstancia.iSesionStorage.CreateSesion(usuarioDto.iId, iSesion.Puntaje, iSesion.Tiempo, DateTime.Now);
                Bitacora.Log($"Operation: Game session saved to DB\nState: Success");

                return sesionDTO;

            }
            catch (Exception ex)
            {
                Bitacora.Log($"Operation: Game session saved to DB\nState: Error\nMessage: {ex.Message}");
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
                List<SesionDTO> sesionesList = Contexto.iInstancia.iSesionStorage.GetSesionesByPuntaje();

                if (sesionesList.Count > 0) { Bitacora.Log("Operation: Get Ranking\nState: Success"); }
                else { Bitacora.Log("Operation: Get Ranking\nState: Error\nMessage: There are no sessions to show"); }

                return sesionesList;
            }
            catch (Exception ex)
            {
                Bitacora.Log($"Operation: Get Ranking\nState: Error\nMessage: {ex.Message}");
                throw;
            }
            
        }

        
    }
}
