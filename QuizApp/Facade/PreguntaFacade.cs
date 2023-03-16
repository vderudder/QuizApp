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
        public List<Pregunta> getPreguntas(string pDificultadId, string pCategoriaId, int pCantidadPreg)
        {
            // Crea el filtro segun los parametros pasados
            PreguntaFiltro filtro = new PreguntaFiltro(pDificultadId, pCategoriaId, pCantidadPreg);

            // Obtiene los dto
            List<PreguntaDTO> preguntaDTOs = Contexto.iInstancia.iPreguntaStorage.getPreguntasByFiltro(filtro);

            // Los transforma a tipo Pregunta
            List<Pregunta> preguntas = preguntaDTOs.Select(dto => new Pregunta(
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
            // Obtiene los dto
            List<CategoriaDTO> categoriaDTOs = Contexto.iInstancia.iPreguntaStorage.getCategorias();

            // Los transforma a tipo Categoria
            List<Categoria> categorias = categoriaDTOs.Select(dto => new Categoria(dto.iId, dto.iCategoria)).ToList();

            return categorias;
        }

        /// <summary>
        /// Obtiene la lista de dificultades existente
        /// </summary>
        /// <returns></returns>
        public List<Dificultad> getDificultades()
        {
            // Obtiene los dto
            List<DificultadDTO> dificultadDTOs = Contexto.iInstancia.iPreguntaStorage.getDificultades();

            // Los transforma a tipo Dificultad
            List<Dificultad> dificultades = dificultadDTOs.Select(dto => new Dificultad(dto.iId, dto.iDificultad)).ToList();

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
