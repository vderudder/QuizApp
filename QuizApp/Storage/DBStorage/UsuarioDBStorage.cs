using QuizApp.Dominio;
using QuizApp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Storage.DBStorage
{
    internal class UsuarioDBStorage
    {
        /// <summary>
        /// Obtiene el usuario por nombre
        /// </summary>
        /// <param name="pNombre"></param>
        /// <returns></returns>
        public UsuarioDTO? getUsuarioByNombre(string pNombre)
        {
            var usuario = Contexto.iServicioBD.Usuarios.Where(u => u.UsuarioNombre == pNombre).SingleOrDefault();

            if (usuario == null)
            {
                return null;
            }
            else
            {
                return new UsuarioDTO() { iId = usuario.UsuarioId, iNombre = usuario.UsuarioNombre };
            }


        }

        /// <summary>
        /// Crea un nuevo usuario
        /// </summary>
        /// <param name="pNombreUsuario"></param>
        /// <returns></returns>
        public UsuarioDTO createUsuario(string pNombreUsuario)
        {
            Contexto.iServicioBD.Usuarios.Add(new DB.QuizContext.Usuario { UsuarioId = Guid.NewGuid().ToString(), UsuarioNombre = pNombreUsuario });
            Contexto.iServicioBD.SaveChanges();

            var usuario = getUsuarioByNombre(pNombreUsuario);

            return usuario;
        }

        /// <summary>
        /// Obtiene todos los nombres de usuarios
        /// </summary>
        /// <returns></returns>
        public List<UsuarioDTO> getUsuarios()
        {
            var usuariosContext = Contexto.iServicioBD.Usuarios.ToList();
            var usuariosDTO = new List<UsuarioDTO>();

            foreach (var item in usuariosContext)
            {
                usuariosDTO.Add(new UsuarioDTO() { iId = item.UsuarioId, iNombre = item.UsuarioNombre });
            }

            return usuariosDTO;
        }

        /// <summary>
        /// Obtiene el usuario por id
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public UsuarioDTO? getUsuarioById(string pId)
        {
            var usuario = Contexto.iServicioBD.Usuarios.First(u => u.UsuarioId == pId);
            var usuarioDTO = new UsuarioDTO() { iId = usuario.UsuarioId, iNombre = usuario.UsuarioNombre };

            return usuarioDTO;

        }
    }

    internal class UsuarioDTO
    {
        public string iId;
        public string iNombre;
    }
}
