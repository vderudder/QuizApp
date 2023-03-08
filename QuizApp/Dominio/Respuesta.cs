using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Dominio
{
    /// <summary>
    /// Clase para persistir las respuestas de las preguntas
    /// </summary>
    internal class Respuesta
    {
        // Atributos
        private string iId;
        private string iNombre;

        //Propiedades
        public string Id => iId;
        public string Nombre => iNombre;

        // Constructor
        public Respuesta(string pId, string pNombre)
        {
            iId = pId;
            iNombre = pNombre;
        }
    }
}
