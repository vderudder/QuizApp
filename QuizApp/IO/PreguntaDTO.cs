using Quizzify.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzify.IO
{
    /// <summary>
    /// Clase DTO de Pregunta
    /// </summary>
    public class PreguntaDTO : BaseDTO<PreguntaDTO, Pregunta>
    {
        // Atributos
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Correcta { get; set; }
        public IList<string> Incorrectas { get; set; }
        public CategoriaDTO Categoria { get; set; }
        public DificultadDTO Dificultad { get; set; }
        public OrigenDTO Origen { get; set; }
        public override void AddCustomMappings()
        {
            SetCustomMappings()
                .Map(dest => dest.Categoria, src => src.Categoria)
                .Map(dest => dest.Dificultad, src => src.Dificultad)
                .Map(dest => dest.Origen, src => src.Origen)
                .Map(dest => dest.Dificultad.Factor, src => 1, src2 => src2.Dificultad.Nombre == "easy")
                .Map(dest => dest.Dificultad.Factor, src => 3, src2 => src2.Dificultad.Nombre == "medium")
                .Map(dest => dest.Dificultad.Factor, src => 5, src2 => src2.Dificultad.Nombre == "hard");

            SetCustomMappingsInverse()
               .Map(dest => dest.Categoria, src => src.Categoria)
               .Map(dest => dest.Dificultad, src => src.Dificultad)
               .Map(dest => dest.Origen, src => src.Origen);

        }
    }


}
