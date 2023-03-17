using QuizApp.Dominio;
using QuizApp.Storage;
using QuizApp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Facade
{
    internal class PreguntaFacade
    {

        /// <summary>
        /// Obtiene la lista de preguntas seleccionada
        /// </summary>
        /// <returns></returns>
        public List<Pregunta> getPreguntas(string pDificultadNombre, string pCategoriaNombre, int pCantidadPreg)
        {
            // Crea el filtro segun los parametros pasados
            PreguntaFiltro filtro = new PreguntaFiltro(pDificultadNombre, pCategoriaNombre, pCantidadPreg);

            // Obtiene los dto
            List<PreguntaDTO> preguntaDTOs = Contexto.iInstancia.iPreguntaStorage.getPreguntasByFiltro(filtro);

            // Los transforma a tipo Pregunta
            List<Pregunta> preguntas = preguntaDTOs.Select(dto => new Pregunta(
                                                dto.iPregunta,
                                                getCategoriaByNombre(dto.iCategoriaNombre),
                                                getDificultadByNombre(dto.iDificultadNombre),
                                                getTipoPreguntaByNombre(dto.iTipoPreguntaNombre),
                                                dto.iCorrecta,
                                                dto.iIncorrectaList.ToList())
                                                ).ToList();

            return preguntas;
        }

        /// <summary>
        /// Obtiene la lista de categorias existente
        /// </summary>
        /// <returns></returns>
        public List<string> getCategorias()
        {
            List<string> categorias = Contexto.iInstancia.iPreguntaStorage.getCategorias();

            return categorias;
        }

        /// <summary>
        /// Obtiene la lista de dificultades existente
        /// </summary>
        /// <returns></returns>
        public List<string> getDificultades()
        {
            List<string> dificultades = Contexto.iInstancia.iPreguntaStorage.getDificultades();

            return dificultades;
        }

        private Categoria getCategoriaByNombre(string pNombre)
        {
            return new Categoria(new Guid().ToString(), pNombre);
        }

        private Dificultad getDificultadByNombre(string pNombre)
        {
            return new Dificultad(new Guid().ToString(), pNombre);

        }
        private TipoPregunta getTipoPreguntaByNombre(string pNombre)
        {
            return new TipoPregunta(new Guid().ToString(), pNombre);

        }

       
    }
}
