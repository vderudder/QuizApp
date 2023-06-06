using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzify.Dominio.Util
{
    /// <summary>
    /// Clase para los pares pregunta y respuesta
    /// </summary>
    internal class PreguntaYRespuesta
    {
        public Pregunta iPregunta;
        public string iRespuesta;

        public PreguntaYRespuesta(Pregunta iPregunta, string iRespuesta)
        {
            this.iPregunta = iPregunta;
            this.iRespuesta = iRespuesta;
        }
    }
}
