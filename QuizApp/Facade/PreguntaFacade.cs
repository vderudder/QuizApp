using Quizzify.Storage.DBStorage;
using QuizApp.UI;
using Quizzify.IO;

namespace Quizzify.Facade
{
    internal class PreguntaFacade
    {

        /// <summary>
        /// Obtiene la lista de preguntas seleccionada
        /// </summary>
        /// <returns></returns>
        public List<PreguntaDTO> GetPreguntas(string pDificultadNombre, string pCategoriaNombre, int pCantidadPreg)
        {
            // Crea el filtro segun los parametros pasados
            PreguntaFiltro filtro = new PreguntaFiltro(pDificultadNombre, pCategoriaNombre, pCantidadPreg);

            try
            {
                // Obtiene los dto
                List<PreguntaDTO> preguntaDTOs = Contexto.iInstancia.iPreguntaStorage.GetPreguntasByFiltro(filtro);

                return preguntaDTOs;
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
        public List<CategoriaDTO> GetCategorias()
        {
            try
            {
                List<CategoriaDTO> categoriasDTO = Contexto.iInstancia.iPreguntaStorage.GetCategorias();

                if (categoriasDTO.Count == 0) { Bitacora.Log("Operation: Get categories list\nState: Error\nMessage: There are no categories"); }
                else { Bitacora.Log("Operation: Get categories list\nState: Success"); }

                return categoriasDTO;
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
        public List<DificultadDTO> GetDificultades()
        {
            try
            {
                List<DificultadDTO> dificultadesDTO = Contexto.iInstancia.iPreguntaStorage.GetDificultades();

                if (dificultadesDTO.Count == 0) { Bitacora.Log("Operation: Get difficulties list\nState: Error\nMessage: There are no difficulties"); }
                else { Bitacora.Log("Operation: Get difficulties list\nState: Success"); }

                return dificultadesDTO;
            }
            catch (Exception ex)
            {
                Bitacora.Log($"Operation: Get difficulties list\nState: Error\nMessage: {ex.Message}");
                throw;
            }
            
        }
       
    }
}
