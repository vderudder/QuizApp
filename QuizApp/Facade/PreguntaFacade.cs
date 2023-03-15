using QuizApp.Dominio;
using QuizApp.Storage;
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
        public List<Pregunta> getPreguntas(string pDificultadId, string pCategoriaId, int pCantidadPreg)
        {
            var filtro = new PreguntaFiltro(pDificultadId, pCategoriaId, pCantidadPreg);

            var storage = new PreguntaStorage();
            var preguntaDTOs = storage.getPreguntasByFiltro(filtro);

            var preguntas = preguntaDTOs.Select(dto => new Pregunta(
                                                dto.iPregunta,
                                                getCategoriaById(dto.iCategoriaId),
                                                getDificultadById(dto.iDificultadId),
                                                getTipoPreguntaById(dto.iTipoPreguntaId),
                                                dto.iCorrecta,
                                                dto.iIncorrectaList.ToList())
                                                ).ToList();

            return preguntas;
        }

        /// <summary>
        /// Obtiene la lista de categorias existente
        /// </summary>
        /// <returns></returns>
        public List<Categoria> getCategorias()
        {
            var storage = new PreguntaStorage();
            var categoriaDTOs = storage.getCategorias();

            var categorias = categoriaDTOs.Select(dto => new Categoria(dto.iId, dto.iCategoria)).ToList();

            return categorias;
        }

        /// <summary>
        /// Obtiene la lista de dificultades existente
        /// </summary>
        /// <returns></returns>
        public List<Dificultad> getDificultades()
        {
            var storage = new PreguntaStorage();
            var dificultadDTOs = storage.getDificultades();

            var dificultades = dificultadDTOs.Select(dto => new Dificultad(dto.iId, dto.iDificultad)).ToList();

            return dificultades;
        }

        private Categoria getCategoriaById(string pId)
        {
            return new Categoria(pId, "Matematicas");
        }

        private Dificultad getDificultadById(string pId)
        {
            return new Dificultad(pId, "Facil");

        }
        private TipoPregunta getTipoPreguntaById(string pId)
        {
            return new TipoPregunta(pId, "Multiple");

        }

       
    }
}
