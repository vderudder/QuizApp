using QuizApp.Dominio;
using QuizApp.Storage.DBStorage;
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
            List<CategoriaDTO> categoriasDTO = Contexto.iInstancia.iPreguntaStorage.getCategorias();
            List<Categoria> categorias = new List<Categoria>();

            foreach (var item in categoriasDTO)
            {
                categorias.Add(new Categoria(item.iId, item.iCategoria));
            }
            

            return categorias;
        }

        /// <summary>
        /// Obtiene la lista de dificultades existente
        /// </summary>
        /// <returns></returns>
        public List<Dificultad> getDificultades()
        {
            List<DificultadDTO> dificultadesDTO = Contexto.iInstancia.iPreguntaStorage.getDificultades();
            List<Dificultad> dificultades = new List<Dificultad>();

            foreach (var item in dificultadesDTO)
            {
                dificultades.Add(new Dificultad(item.iId, item.iDificultad));
            }

            return dificultades;
        }

        private Categoria getCategoriaByNombre(string pNombre)
        {
            var categoriaEncontrada = getCategorias().First(c => c.Nombre == pNombre);

            return new Categoria(categoriaEncontrada.Id, categoriaEncontrada.Nombre);
        }

        private Dificultad getDificultadByNombre(string pNombre)
        {
            var dificultadEncontrada = getDificultades().First(d => d.Nombre == pNombre);

            return new Dificultad(dificultadEncontrada.Id, dificultadEncontrada.Nombre);

        }
       
    }
}
