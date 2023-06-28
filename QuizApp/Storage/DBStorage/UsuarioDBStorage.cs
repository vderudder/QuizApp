
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
        public Dominio.Usuario? GetUsuarioByNombre(string pNombre)
        {
            var usuario = ContextoDB.Instancia.ServicioBD.Usuarios.Where(u => u.UsuarioNombre == pNombre).SingleOrDefault();

            if (usuario == null)
            {
                return null;
            }
            else
            {
                return DB.QuizContext.Usuario.DAOToEntity(usuario);
            }
        }

        /// <summary>
        /// Crea un nuevo usuario
        /// </summary>
        /// <param name="pNombreUsuario"></param>
        /// <returns></returns>
        public Dominio.Usuario CreateUsuario(string pNombreUsuario)
        {
            var usuario = ContextoDB.Instancia.ServicioBD.Usuarios.Add(new DB.QuizContext.Usuario { UsuarioId = Guid.NewGuid().ToString(), UsuarioNombre = pNombreUsuario });
            ContextoDB.Instancia.ServicioBD.SaveChanges();

            return DB.QuizContext.Usuario.DAOToEntity(usuario.Entity);
        }

        /// <summary>
        /// Obtiene todos los nombres de usuarios
        /// </summary>
        /// <returns></returns>
        public List<Dominio.Usuario> GetUsuarios()
        {
            var usuariosList = ContextoDB.Instancia.ServicioBD.Usuarios.ToList();

            return usuariosList.Select(DB.QuizContext.Usuario.DAOToEntity).ToList();
        }

       
    }
}
