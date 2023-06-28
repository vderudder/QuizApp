using Quizzify.Dominio;

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
        public Usuario? GetUsuarioByNombre(string pNombre);
        /// <summary>
        /// Crear un nuevo usuario
        /// </summary>
        /// <param name="pNombreUsuario"></param>
        /// <returns></returns>
        public Usuario CreateUsuario(string pNombreUsuario);
        /// <summary>
        /// Obtener todos los usuarios
        /// </summary>
        /// <returns></returns>
        public List<Usuario> GetUsuarios();
       
    }
}
