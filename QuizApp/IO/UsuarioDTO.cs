﻿using Quizzify.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzify.IO
{
    /// <summary>
    /// Clase DTO de Usuario
    /// </summary>
    public class UsuarioDTO : BaseDTO<UsuarioDTO, Usuario>
    {
        public string Id { get; set; }
        public string Nombre { get; set; }

    }
}
