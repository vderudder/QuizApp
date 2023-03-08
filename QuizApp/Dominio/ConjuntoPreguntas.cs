using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Dominio
{
    /// <summary>
    /// Clase para persistir los conjuntos de preguntas disponibles
    /// </summary>
    internal class ConjuntoPreguntas
    {
        // Atributos
        private string iId; //esto seria el link de tdb

        // Propiedades
        public string Id => iId;

        // Constructor
        public ConjuntoPreguntas(string pId)
        {
            iId = pId;
        }
    }
}
