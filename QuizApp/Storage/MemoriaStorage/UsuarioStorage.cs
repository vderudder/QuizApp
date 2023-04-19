﻿using QuizApp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Storage.MemoriaStorage
{
    internal class UsuarioStorage
    {
        private List<UsuarioDTO> iUsuariosEnMemoria = new List<UsuarioDTO>() {
            new UsuarioDTO(){ iId = "1", iNombre = "Pepito" },
            new UsuarioDTO(){ iId = "2", iNombre = "Andrea" },
            new UsuarioDTO(){ iId = "3", iNombre = "Dana" },
            new UsuarioDTO(){ iId = "4", iNombre = "Roberto" },
        };

        /// <summary>
        /// Obtiene el usuario por el nombre de usuario
        /// </summary>
        /// <param name="pNombre"></param>
        /// <returns></returns>
        public UsuarioDTO? getUsuarioByNombre(string pNombre)
        {
            return iUsuariosEnMemoria.Find((u) => u.iNombre == pNombre);
        }

        /// <summary>
        /// Crea un nuevo usuario
        /// </summary>
        /// <param name="pNombreUsuario"></param>
        /// <returns></returns>
        public UsuarioDTO createUsuario(string pNombreUsuario)
        {
            var usuario = new UsuarioDTO() { iId = Guid.NewGuid().ToString(), iNombre = pNombreUsuario };
            iUsuariosEnMemoria.Add(usuario);
            return usuario;
        }

        /// <summary>
        /// Obtiene todos los usuarios
        /// </summary>
        /// <returns></returns>
        public List<UsuarioDTO> getUsuarios()
        {
            return iUsuariosEnMemoria;
        }

        /// <summary>
        /// Obtiene el usuario por id
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public UsuarioDTO? getUsuarioById(string pId)
        {
            return iUsuariosEnMemoria.Find((u) => u.iId == pId);

        }
    }

    internal class UsuarioDTO
    {
        public string iId;
        public string iNombre;
    }
}