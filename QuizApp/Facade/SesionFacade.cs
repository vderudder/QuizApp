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
        /// <summary>
        /// Guarda la sesion de juego
        /// </summary>
        public SesionDTO finalizarSesion(string pNombreUsuario, int pTiempo, List<PreguntaYRespuesta> pPregResElegidas)
        {
            var usuarioStorage = new UsuarioStorage();
            var usuarioDto = usuarioStorage.getUsuarioByNombre(pNombreUsuario);
            if (usuarioDto == null)
            {
                usuarioDto = usuarioStorage.createUsuario(pNombreUsuario);
            }
            var usuario = new Usuario(usuarioDto.iId, usuarioDto.iNombre);

            var sesion = new Sesion(pTiempo, pPregResElegidas, usuario);
            sesion.finalizar();

            var sesionStorage = new SesionStorage();
            return sesionStorage.createSesion(usuario.Id, sesion.Puntaje, sesion.Tiempo, DateTime.Now);
        }

        
    }
}
