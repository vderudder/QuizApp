using QuizApp.Dominio;
using QuizApp.Storage;
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
            List<UsuarioDTO> usuarioDTOs = Contexto.iInstancia.iUsuarioStorage.getUsuarios();

            // Los convierte a tipo Usuario
            List<Usuario> usuarios = usuarioDTOs.Select(dto => new Usuario(dto.iId, dto.iNombre)).ToList();

            return usuarios;
        }
    }
}
