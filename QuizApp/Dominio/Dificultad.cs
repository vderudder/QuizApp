using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Dominio
{
    /// <summary>
    /// Clase para persistir la dificultad de la trivia
    /// </summary>
    internal class Dificultad
    {
        // Atributos
        private string iId;
        private string iNombre;
        private int iFactor;

        // Propiedades
        public string Id => iId;
        public string Nombre => iNombre;

        public int Factor => iFactor;

        // Constructor
        public Dificultad(string pId, string pNombre)
        {
            iId = pId;
            iNombre = pNombre;
            switch (pNombre)
            {
                case "hard":
                    iFactor = 5;
                    break;
                case "medium":
                    iFactor = 3;
                    break;
                case "easy":
                    iFactor = 1;
                    break;
            }
            // Estas son las dificultades requeridas en el TP, 
            // Se dejo un constructor de un solo atributo para que no haya forma de que difiera el factor de su correspondiente nombre
            // En un futuro se podria ampliar esto y que el factor sea independiente del nombre
        }
    }
}
