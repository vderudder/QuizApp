using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Dominio
{
    /// <summary>
    /// Clase para persistir las categorias de la trivia
    /// </summary>
    internal class Categoria
    {
        // Atributos
        private string iId;
        private string iNombre;

        //Propiedades
        public string Id => iId;
        public string Nombre => iNombre;

        // Constructor
        public Categoria(string pId, string pNombre)
        {
            iId = pId;
            iNombre = pNombre;
        }
    }
}
