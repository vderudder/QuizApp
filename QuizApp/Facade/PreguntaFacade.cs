using Quizzify.Storage.DBStorage;
using QuizApp.UI;
using Quizzify.IO;
using log4net;

namespace Quizzify.Facade
{
    internal class PreguntaFacade
    {
        private static ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Obtiene la lista de origenes de datos
        /// </summary>
        /// <returns></returns>
        public List<string> GetOrigenes()
        {
            return Contexto.iInstancia.iPreguntaStorage.GetOrigenes();
        }

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

                logger.Info("Operation: Get filtered question list");

                return preguntaDTOs;
            }
            catch (Exception ex)
            {
                logger.Error($"Operation: Get filtered question list - Message: {ex.Message}");
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

                if (categoriasDTO.Count == 0) { logger.Warn("Operation: Get categories list - Message: There are no categories"); }
                else { logger.Info("Operation: Get categories list"); }

                return categoriasDTO;
            }
            catch (Exception ex)
            {
                logger.Error($"Operation: Get categories list - Message: {ex.Message}");
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

                if (dificultadesDTO.Count == 0) { logger.Warn("Operation: Get difficulties list - Message: There are no difficulties"); }
                else { logger.Info("Operation: Get difficulties list"); }

                return dificultadesDTO;
            }
            catch (Exception ex)
            {
                logger.Error($"Operation: Get difficulties list - Message: {ex.Message}");
                throw;
            }
            
        }
       
    }
}
