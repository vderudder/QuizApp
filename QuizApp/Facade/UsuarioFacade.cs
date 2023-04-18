using QuizApp.Dominio;
using QuizApp.Storage;
using QuizApp.Storage.DBStorage;
using QuizApp.UI;
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
            // Obtiene los dto
            List<UsuarioDTO> usuariosDTO = Contexto.iInstancia.iUsuarioStorage.getUsuarios();
            List<Usuario> usuarios = new List<Usuario>();

            foreach (var item in usuariosDTO)
            {
                usuarios.Add(new Usuario(item.iId, item.iNombre));
            }

            return usuarios;
        }
    }
}
