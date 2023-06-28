using Quizzify.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzify.IO
{
    /// <summary>
    /// Clase DTO de Sesion
    /// </summary>
    public class SesionDTO : BaseDTO<SesionDTO, Sesion>
    {
        public string Id { get; set; }
        public DateTime Fecha { get; set; }
        public double Tiempo { get; set; }
        public double Puntaje { get; set; }
        public UsuarioDTO Usuario { get; set; }

        public override void AddCustomMappings()
        {
            SetCustomMappings()
                .Map(dest => dest.Usuario, src => src.Usuario);

            SetCustomMappingsInverse()
                .Map(dest => dest.Usuario, src => src.Usuario);


        }
    }
}
