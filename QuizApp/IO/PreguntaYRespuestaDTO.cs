using QuizApp.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzify.IO
{
    internal class PreguntaYRespuestaDTO
    {
        public PreguntaDTO iPregunta;
        public string iRespuesta;

        public PreguntaYRespuestaDTO(PreguntaDTO iPregunta, string iRespuesta)
        {
            this.iPregunta = iPregunta;
            this.iRespuesta = iRespuesta;
        }
    }
}
