using QuizApp.Dominio;
using QuizApp.Storage.DBStorage;
using QuizApp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static QuizApp.DB.QuizContext;

namespace QuizApp.Facade
{
    internal class PreguntaFacade
    {

        /// <summary>
        /// Obtiene la lista de preguntas seleccionada
        /// </summary>
        /// <returns></returns>
        public List<Dominio.Pregunta> getPreguntas(string pDificultadNombre, string pCategoriaNombre, int pCantidadPreg)
        {
            // Crea el filtro segun los parametros pasados
            PreguntaFiltro filtro = new PreguntaFiltro(pDificultadNombre, pCategoriaNombre, pCantidadPreg);

            try
            {
                // Obtiene los dto
                List<PreguntaDTO> preguntaDTOs = Contexto.iInstancia.iPreguntaStorage.getPreguntasByFiltro(filtro);

                // Los transforma a tipo Pregunta
                List<Dominio.Pregunta> preguntas = preguntaDTOs.Select(dto => new Dominio.Pregunta(
                                                    dto.iPregunta,
                                                    getCategoriaByNombre(dto.iCategoriaNombre),
                                                    getDificultadByNombre(dto.iDificultadNombre),
                                                    dto.iCorrecta,
                                                    dto.iIncorrectaList.ToList())
                                                    ).ToList();

                return preguntas;
            }
            catch (Exception ex)
            {
                Bitacora.Log($"Operation: Get filtered question list\nState: Error\nMessage: {ex.Message}");
                throw;
            }
            

            
        }

        /// <summary>
        /// Obtiene la lista de categorias existente
        /// </summary>
        /// <returns></returns>
        public List<Dominio.Categoria> getCategorias()
        {
            try
            {
                List<CategoriaDTO> categoriasDTO = Contexto.iInstancia.iPreguntaStorage.getCategorias();
                List<Dominio.Categoria> categorias = new List<Dominio.Categoria>();

                foreach (var item in categoriasDTO)
                {
                    categorias.Add(new Dominio.Categoria(item.iId, item.iCategoria));
                }

                if (categorias.Count == 0) { Bitacora.Log("Operation: Get categories list\nState: Error\nMessage: There are no categories"); }
                else { Bitacora.Log("Operation: Get categories list\nState: Success"); }

                return categorias;
            }
            catch (Exception ex)
            {
                Bitacora.Log($"Operation: Get categories list\nState: Error\nMessage: {ex.Message}");
                throw;
            }
            
        }

        /// <summary>
        /// Obtiene la lista de dificultades existente
        /// </summary>
        /// <returns></returns>
        public List<Dominio.Dificultad> getDificultades()
        {
            try
            {
                List<DificultadDTO> dificultadesDTO = Contexto.iInstancia.iPreguntaStorage.getDificultades();
                List<Dominio.Dificultad> dificultades = new List<Dominio.Dificultad>();

                foreach (var item in dificultadesDTO)
                {
                    dificultades.Add(new Dominio.Dificultad(item.iId, item.iDificultad));
                }

                if (dificultades.Count == 0) { Bitacora.Log("Operation: Get difficulties list\nState: Error\nMessage: There are no difficulties"); }
                else { Bitacora.Log("Operation: Get difficulties list\nState: Success"); }

                return dificultades;
            }
            catch (Exception ex)
            {
                Bitacora.Log($"Operation: Get difficulties list\nState: Error\nMessage: {ex.Message}");
                throw;
            }
            
        }

        /// <summary>
        /// Obtiene la categoria buscando por su nombre
        /// </summary>
        /// <param name="pNombre"></param>
        /// <returns></returns>
        private Dominio.Categoria getCategoriaByNombre(string pNombre)
        {
            var categoriaEncontrada = getCategorias().First(c => c.Nombre == pNombre);

            return new Dominio.Categoria(categoriaEncontrada.Id, categoriaEncontrada.Nombre);
        }

        /// <summary>
        /// Obtiene la dificultad buscando por su nombre
        /// </summary>
        /// <param name="pNombre"></param>
        /// <returns></returns>
        private Dominio.Dificultad getDificultadByNombre(string pNombre)
        {
            var dificultadEncontrada = getDificultades().First(d => d.Nombre == pNombre);

            return new Dominio.Dificultad(dificultadEncontrada.Id, dificultadEncontrada.Nombre);

        }
       
    }
}
