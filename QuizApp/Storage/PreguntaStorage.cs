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
            new PreguntaDTO("Cuanto es 10+20?", "easy", "Matematicas", "multiple",
                // respuesta correcta
                "30",
                //respuestas incorrectas
                new List<string> {"10", "100", "200"}),
            new PreguntaDTO("Cuanto es 100+100?", "easy", "Matematicas", "multiple",
                // respuesta correcta
                "200",
                //respuestas incorrectas
                new List<string> {"10", "1000", "200"}),
            new PreguntaDTO("Cuanto es 10+10?", "easy", "Matematicas", "multiple",
                // respuesta correcta
                "20",
                //respuestas incorrectas
                new List<string> {"10", "100", "200"}),
            new PreguntaDTO("Cuanto es 2 elevado a la 2?", "easy", "Matematicas", "multiple",
                // respuesta correcta
                "4",
                //respuestas incorrectas
                new List<string> {"8", "2", "200"}),
            new PreguntaDTO("Se puede dividir por cero?", "easy", "Matematicas", "multiple",
                // respuesta correcta
                "No",
                //respuestas incorrectas
                new List<string> {"Si"}),
            new PreguntaDTO("Si tengo 24 manzanas y me sacan 3, con cuantas me quedo?", "easy", "Matematicas", "multiple",
                // respuesta correcta
                "21",
                //respuestas incorrectas
                new List<string> {"20", "3", "24"}),
            new PreguntaDTO("Cuanto es 10+10?", "easy", "Matematicas", "multiple",
                // respuesta correcta
                "20",
                //respuestas incorrectas
                new List<string> {"10", "100", "200"}),
            new PreguntaDTO("Que significa el operador +?", "easy", "Matematicas", "multiple",
                // respuesta correcta
                "Suma",
                //respuestas incorrectas
                new List<string> {"Resta", "Division", "Multiplicacion"}),
            new PreguntaDTO("El orden de los factores altera al producto?", "easy", "Matematicas", "multiple",
                // respuesta correcta
                "No",
                //respuestas incorrectas
                new List<string> {"Si" }),
            new PreguntaDTO("Cuales son los numeros naturales?", "easy", "Matematicas", "multiple",
                // respuesta correcta
                "Los numeros positivos, sin incluir el cero",
                //respuestas incorrectas
                new List<string> {"Los numeros negativos y positivos", "Los numeros negativos y positivos, incluido el cero"}),
            new PreguntaDTO("Cuantos numeros hay?", "easy", "Matematicas", "multiple",
                // respuesta correcta
                "Infinitos",
                //respuestas incorrectas
                new List<string> {"Mas de un millon", "Mas de 3 millones", "No existen"}),

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

            // Desordenar y tomar la cantidad del filtro
            var preguntasFiltradas = preguntasByCategoriaDificultad.OrderBy(elem => Guid.NewGuid()).ToList().Take(pFiltro.iCantidad).ToList();

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
