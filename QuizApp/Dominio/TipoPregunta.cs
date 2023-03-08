using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Dominio
{
    /// <summary>
    /// Clase para persistir el tipo de pregunta de la trivia
    /// </summary>
    internal class TipoPregunta
    {
        // Atributos
        private string iNombre;

        //Propiedades
        public string Nombre => iNombre;

        // Constructor
        public TipoPregunta(string pNombre)
        {
            iNombre = pNombre;
        }
    }
}
