using QuizApp.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzify.Storage
{
    internal interface IUsuarioStorage
    {
        public UsuarioDTO? GetUsuarioByNombre(string pNombre);
        public UsuarioDTO CreateUsuario(string pNombreUsuario);
        public List<UsuarioDTO> GetUsuarios();
        public UsuarioDTO? GetUsuarioById(string pId);
    }
}
