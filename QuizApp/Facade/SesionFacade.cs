using QuizApp.Dominio;
using QuizApp.Dominio.Util;
using QuizApp.Storage.DBStorage;
using QuizApp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Facade
{
    internal class SesionFacade
    {
        /// <summary>
        /// Guarda la sesion de juego
        /// </summary>
        public SesionDTO finalizarSesion(string pNombreUsuario, double pTiempo, List<PreguntaYRespuesta> pPregResElegidas)
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

            // Llama al metodo del dominio
            Sesion sesion = new Sesion(pTiempo, pPregResElegidas, usuario);
            sesion.Finalizar();

            try
            {
                // Crea la sesion
                var sesionDTO = Contexto.iInstancia.iSesionStorage.CreateSesion(usuario.Id, sesion.Puntaje, sesion.Tiempo, DateTime.Now);
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
        public List<SesionDTO> getRanking()
        {
            try
            {
                // Obtiene el ranking de sesiones
                List<SesionDTO> sesionesList = Contexto.iInstancia.iSesionStorage.GetSesionesByPuntaje();

                for (int i = 0; i < sesionesList.Count; i++)
                {
                    // Busca el usuario para obtener el nombre
                    var usuario = Contexto.iInstancia.iUsuarioStorage.GetUsuarioById(sesionesList[i].iUsuarioId);

                    // Cambiar id de usuario por nombre para mostrarlo en la UI
                    sesionesList[i].iUsuarioId = usuario.iNombre;
                }

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
