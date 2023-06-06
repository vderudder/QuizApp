using Quizzify.IO;

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
