using Quizzify.IO;

namespace Quizzify.Storage.DBStorage
{
    /// <summary>
    /// Corresponde al Storage de preguntas usando DB relacional
    /// </summary>
    internal class UsuarioDBStorage : IUsuarioStorage
    {
        /// <summary>
        /// Obtiene el usuario por nombre
        /// </summary>
        /// <param name="pNombre"></param>
        /// <returns></returns>
        public UsuarioDTO? GetUsuarioByNombre(string pNombre)
        {
            var usuario = ContextoDB.Instancia.ServicioBD.Usuarios.Where(u => u.UsuarioNombre == pNombre).SingleOrDefault();

            if (usuario == null)
            {
                return null;
            }
            else
            {
                return new UsuarioDTO(usuario.UsuarioId, usuario.UsuarioNombre);
            }


        }

        /// <summary>
        /// Crea un nuevo usuario
        /// </summary>
        /// <param name="pNombreUsuario"></param>
        /// <returns></returns>
        public UsuarioDTO CreateUsuario(string pNombreUsuario)
        {
            var usuario = ContextoDB.Instancia.ServicioBD.Usuarios.Add(new DB.QuizContext.Usuario { UsuarioId = Guid.NewGuid().ToString(), UsuarioNombre = pNombreUsuario });
            ContextoDB.Instancia.ServicioBD.SaveChanges();

            return new UsuarioDTO(usuario.Entity.UsuarioId, usuario.Entity.UsuarioNombre);
        }

        /// <summary>
        /// Obtiene todos los nombres de usuarios
        /// </summary>
        /// <returns></returns>
        public List<UsuarioDTO> GetUsuarios()
        {
            var usuariosContext = ContextoDB.Instancia.ServicioBD.Usuarios.ToList();
            var usuariosDTO = new List<UsuarioDTO>();

            foreach (var item in usuariosContext)
            {
                usuariosDTO.Add(new UsuarioDTO(item.UsuarioId, item.UsuarioNombre));
            }

            return usuariosDTO;
        }

        /// <summary>
        /// Obtiene el usuario por id
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public UsuarioDTO? GetUsuarioById(string pId)
        {
            var usuario = ContextoDB.Instancia.ServicioBD.Usuarios.First(u => u.UsuarioId == pId);
            var usuarioDTO = new UsuarioDTO(usuario.UsuarioId, usuario.UsuarioNombre);

            return usuarioDTO;

        }
    }
}
