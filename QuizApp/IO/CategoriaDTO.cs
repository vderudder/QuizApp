using Quizzify.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzify.IO
{
    /// <summary>
    /// Clase DTO de Categoria
    /// </summary>
    public class CategoriaDTO : BaseDTO<CategoriaDTO, Categoria>
    {
        // Atributos
        public string Id { get; set; }
        public string Nombre { get; set; }
    }
}
