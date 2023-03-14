using QuizApp.Dominio;
using QuizApp.Dominio.Util;
using QuizApp.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Facade
{
    internal class SesionFacade
    {
        private SesionStorage iSesionStorage = new SesionStorage();
        private UsuarioStorage iUsuarioStorage = new UsuarioStorage();

        /// <summary>
        /// Guarda la sesion de juego
        /// </summary>
        public SesionDTO finalizarSesion(string pNombreUsuario, double pTiempo, List<PreguntaYRespuesta> pPregResElegidas)
        {
            var usuarioDto = iUsuarioStorage.getUsuarioByNombre(pNombreUsuario);
            if (usuarioDto == null)
            {
                usuarioDto = iUsuarioStorage.createUsuario(pNombreUsuario);
            }
            var usuario = new Usuario(usuarioDto.iId, usuarioDto.iNombre);

            var sesion = new Sesion(pTiempo, pPregResElegidas, usuario);
            sesion.finalizar();

            return iSesionStorage.createSesion(usuario.Id, sesion.Puntaje, sesion.Tiempo, DateTime.Now);
        }

        public List<SesionDTO> getRanking()
        {
            var list = iSesionStorage.getSesionesByPuntaje();

            for (int i = 0; i < list.Count; i++)
            {
                // Cambiar id de usuario por nombre para mostrar
                list[i].iUsuarioId = iUsuarioStorage.getUsuarioById(list[i].iUsuarioId).iNombre;
            }

            return iSesionStorage.getSesionesByPuntaje();
        }

        
    }
}
