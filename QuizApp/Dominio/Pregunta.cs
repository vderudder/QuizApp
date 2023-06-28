using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzify.Dominio
{
    /// <summary>
    /// Clase para persistir las preguntas de la trivia
    /// </summary>
    public class Pregunta
    { 
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Correcta { get; set; }
        public IList<string> Incorrectas { get; set; }
        public Categoria Categoria { get; set; }
        public Dificultad Dificultad { get; set; }
        public Origen Origen { get; set; }


        public bool EsRespuestaCorrecta(string pRespuesta)
        {
            return Correcta == pRespuesta;
        }
    }
}
