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
        private List<PreguntaDTO> iPreguntasEnMemoria = new List<PreguntaDTO>()
        {
            new PreguntaDTO("Cuanto es 2+2?", "easy", "Matematicas", "multiple",
                // respuesta correcta
                "4",
                //respuestas incorrectas
                new List<string> {"5", "2", "20"}),
            new PreguntaDTO("Cuanto es 2*5?", "easy", "Matematicas", "multiple",
                // respuesta correcta
                "10",
                //respuestas incorrectas
                new List<string> {"5", "2", "15"}),
            new PreguntaDTO("Cuanto es 10+10?", "easy", "Matematicas", "multiple",
                // respuesta correcta
                "20",
                //respuestas incorrectas
                new List<string> {"10", "100", "200"}),

        };

        /// <summary>
        /// Obtiene los DTO de las preguntas con el filtro correspondiente
        /// </summary>
        /// <param name="pFiltro"></param>
        /// <returns></returns>
        public List<PreguntaDTO> getPreguntasByFiltro(PreguntaFiltro pFiltro)
        {
            // Filtrar por categoria y dificultad
            var preguntasByCategoriaDificultad = iPreguntasEnMemoria.Where(p => (p.iDificultadNombre == pFiltro.iDificultad) && (p.iCategoriaNombre == pFiltro.iCategoria)).ToList();

            // Tomar la cantidad del filtro
            var preguntasFiltradas = preguntasByCategoriaDificultad.Take(pFiltro.iCantidad).ToList();

            return preguntasFiltradas;

        }

        public List<PreguntaDTO> guardarPreguntas(List<PreguntaDTO> pPreguntas)
        {
            foreach (var p in pPreguntas)
            {
                iPreguntasEnMemoria.Add(p);
            }

            return iPreguntasEnMemoria;
        }

        /// <summary>
        /// Obtiene las categorias
        /// </summary>
        /// <returns></returns>
        public List<string> getCategorias()
        {
            var categorias = iPreguntasEnMemoria.DistinctBy(p => p.iCategoriaNombre).ToList().Select(elem => elem.iCategoriaNombre).ToList();

            return categorias;
        }

        /// <summary>
        /// Obtiene las dificultades
        /// </summary>
        /// <returns></returns>
        public List<string> getDificultades()
        {
            var dificultades = iPreguntasEnMemoria.DistinctBy(p => p.iDificultadNombre).ToList().Select(elem => elem.iDificultadNombre).ToList();

            return dificultades;
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
        public string iDificultadNombre;
        public string iCategoriaNombre;
        public string iTipoPreguntaNombre;
        public string iCorrecta;
        public List<string> iIncorrectaList;

        public PreguntaDTO(string pPregunta, string pDificultadNombre, string pCategoriaNombre, string pTipoPreguntaNombre, string pCorrecta, List<string> pIncorrectaList)
        {
            this.iPregunta = pPregunta;
            this.iDificultadNombre = pDificultadNombre;
            this.iCategoriaNombre = pCategoriaNombre;
            this.iTipoPreguntaNombre = pTipoPreguntaNombre;
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
