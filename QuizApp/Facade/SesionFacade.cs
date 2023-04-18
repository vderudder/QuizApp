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
            var usuarioDto = Contexto.iInstancia.iUsuarioStorage.getUsuarioByNombre(pNombreUsuario);

            // Si no existe, entonces crea el usuario
            if (usuarioDto == null)
            {
                usuarioDto = Contexto.iInstancia.iUsuarioStorage.createUsuario(pNombreUsuario);
            }

            // Si existe, lo convierte a tipo Usuario
            Usuario usuario = new Usuario(usuarioDto.iId, usuarioDto.iNombre);

            // Llama al metodo del dominio
            Sesion sesion = new Sesion(pTiempo, pPregResElegidas, usuario);
            sesion.finalizar();

            // Crea la sesion
            return Contexto.iInstancia.iSesionStorage.createSesion(usuario.Id, sesion.Puntaje, sesion.Tiempo, DateTime.Now);
        }

        /// <summary>
        /// Obtiene la lista de sesiones que entran en el ranking top 20
        /// </summary>
        /// <returns></returns>
        public List<SesionDTO> getRanking()
        {
            // Obtiene el ranking de sesiones
            List<SesionDTO> sesionesList = Contexto.iInstancia.iSesionStorage.getSesionesByPuntaje();

            for (int i = 0; i < sesionesList.Count; i++)
            {
                // Busca el usuario para obtener el nombre
                var usuario = Contexto.iInstancia.iUsuarioStorage.getUsuarioById(sesionesList[i].iUsuarioId);

                // Cambiar id de usuario por nombre para mostrarlo en la UI
                sesionesList[i].iUsuarioId = usuario.iNombre;
            }

            return sesionesList;
        }

        
    }
}
