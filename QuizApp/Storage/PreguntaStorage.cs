using QuizApp.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Storage
{
    internal class PreguntaStorage
    {
        /// <summary>
        /// Obtiene el DTO de las preguntas con el filtro correspondiente
        /// </summary>
        /// <param name="pFiltro"></param>
        /// <returns></returns>
        public PreguntaDTO[] getPreguntasByFiltro(PreguntaFiltro pFiltro)
        {
            var pregunta1 = new PreguntaDTO(
                "Cuanto es 2+2?",
                "1",
                "1",
                "1",
                // respuesta correcta
                "4",
                //respuestas incorrectas
                new List<string> {"5", "2", "20"}
                );

            return new PreguntaDTO[] { pregunta1 };
        }
    }

    internal class PreguntaFiltro
    {
        // Atributos
        public string iDificultad;
        public string iCategoria;
        public int iCantidad;

        public PreguntaFiltro(string pDificultad, string pCategoria, int pCantidad)
        {
            this.iDificultad = pDificultad;
            this.iCategoria = pCategoria;
            this.iCantidad = pCantidad;
        }
    }

    internal class PreguntaDTO
    {
        // Atributos
        public string iPregunta;
        public string iDificultadId;
        public string iCategoriaId;
        public string iTipoPreguntaId;
        public string iCorrecta;
        public List<string> iIncorrectaList;

        public PreguntaDTO(string pPregunta, string pDificultadId, string pCategoriaId, string pTipoPreguntaId, string pCorrecta, List<string> pIncorrectaList)
        {
            this.iPregunta = pPregunta;
            this.iDificultadId = pDificultadId;
            this.iCategoriaId = pCategoriaId;
            this.iTipoPreguntaId = pTipoPreguntaId;
            this.iCorrecta = pCorrecta;
            this.iIncorrectaList = pIncorrectaList;
        }
    }
}
