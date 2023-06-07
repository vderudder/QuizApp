using Quizzify.IO;

namespace Quizzify.Storage
{
    /// <summary>
    /// Storage para los usuarios locales
    /// </summary>
    internal interface IUsuarioStorage
    {
        /// <summary>
        /// Obtener un usuario por nombre
        /// </summary>
        /// <param name="pNombre"></param>
        /// <returns></returns>
        public UsuarioDTO? GetUsuarioByNombre(string pNombre);
        /// <summary>
        /// Crear un nuevo usuario
        /// </summary>
        /// <param name="pNombreUsuario"></param>
        /// <returns></returns>
        public UsuarioDTO CreateUsuario(string pNombreUsuario);
        /// <summary>
        /// Obtener todos los usuarios
        /// </summary>
        /// <returns></returns>
        public List<UsuarioDTO> GetUsuarios();
        /// <summary>
        /// Obtener un usuario por id de usuario
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public UsuarioDTO? GetUsuarioById(string pId);
    }
}
