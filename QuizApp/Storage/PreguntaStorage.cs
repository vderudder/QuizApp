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
        /// Obtiene los DTO de las preguntas con el filtro correspondiente
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

            var pregunta2 = new PreguntaDTO(
                "Cuanto es 2*5?",
                "1",
                "1",
                "1",
                // respuesta correcta
                "10",
                //respuestas incorrectas
                new List<string> { "5", "2", "15" }
                );

            var pregunta3 = new PreguntaDTO(
                "Cuanto es 10+10?",
                "1",
                "1",
                "1",
                // respuesta correcta
                "20",
                //respuestas incorrectas
                new List<string> { "10", "100", "200" }
                );

            return new PreguntaDTO[] { pregunta1, pregunta2, pregunta3};
        }

        /// <summary>
        /// Obtiene los DTO de las categorias 
        /// </summary>
        /// <returns></returns>
        public CategoriaDTO[] getCategorias()
        {
            var categoria1 = new CategoriaDTO("1", "Matematicas");

            return new CategoriaDTO[] { categoria1 };   
        }

        /// <summary>
        /// Obtiene los DTO de las dificultades 
        /// </summary>
        /// <returns></returns>
        public DificultadDTO[] getDificultades()
        {
            var dificultad1 = new DificultadDTO("1", "Facil");

            return new DificultadDTO[] { dificultad1 };
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

    internal class CategoriaDTO
    {
        // Atributos
        public string iId;
        public string iCategoria;

        public CategoriaDTO(string pId, string pCategoria)
        {
            this.iId = pId;
            this.iCategoria = pCategoria;
        }
    }

    internal class DificultadDTO
    {
        // Atributos
        public string iId;
        public string iDificultad;

        public DificultadDTO(string pId, string pDificultad)
        {
            this.iId = pId;
            this.iDificultad = pDificultad;
        }
    }
}
