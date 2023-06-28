using Quizzify.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzify.IO
{
    /// <summary>
    /// Clase DTO de Dificultad
    /// </summary>
    public class DificultadDTO : BaseDTO<DificultadDTO, Dificultad>
    {
        // Atributos
        public string Id { get; set; }
        public string Nombre { get; set; }
        public int Factor { get; set; }

    }
}
