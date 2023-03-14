using QuizApp.Dominio;
using QuizApp.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Facade
{
    internal class UsuarioFacade
    {

        /// <summary>
        /// Obtiene la lista de usuarios existente
        /// </summary>
        /// <returns></returns>
        public List<Usuario> getUsuarios()
        {
            var storage = new UsuarioStorage();
            var usuarioDTOs = storage.getUsuarios();

            var usuarios = usuarioDTOs.Select(dto => new Usuario(dto.iId, dto.iNombre)).ToList();

            return usuarios;
        }
    }
}
