using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.IO
{
    internal class PreguntaDTO
    {
        // Atributos
        public string iPregunta;
        public string iDificultadNombre;
        public string iCategoriaNombre;
        public string iCorrecta;
        public List<string> iIncorrectaList;

        public PreguntaDTO(string pPregunta, string pDificultadNombre, string pCategoriaNombre, string pCorrecta, List<string> pIncorrectaList)
        {
            iPregunta = pPregunta;
            iDificultadNombre = pDificultadNombre;
            iCategoriaNombre = pCategoriaNombre;
            iCorrecta = pCorrecta;
            iIncorrectaList = pIncorrectaList;
        }
    }
}
