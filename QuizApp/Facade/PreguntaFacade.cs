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
            return Contexto.Instancia.PreguntaStorage.GetOrigenes();
        }

        /// <summary>
        /// Obtiene la lista de preguntas seleccionada
        /// </summary>
        /// <returns></returns>
        public List<PreguntaDTO> GetPreguntas(string pDificultadNombre, string pCategoriaNombre, int pCantidadPreg)
        {
            // Crea el filtro segun los parametros pasados
            PreguntaFiltro filtro = new PreguntaFiltro { Dificultad = pDificultadNombre, Categoria = pCategoriaNombre, Cantidad = pCantidadPreg };

            try
            {
                var preguntas = Contexto.Instancia.PreguntaStorage.GetPreguntasByFiltro(filtro);

                logger.Info("Operation: Get filtered question list");

                return preguntas.Select(PreguntaDTO.ToDto).ToList();
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
        public List<CategoriaDTO> GetCategoriasByOrigen(string pOrigen)
        {
            try
            {
                var categorias = Contexto.Instancia.PreguntaStorage.GetCategoriasByOrigen(pOrigen);

                if (categorias.Count == 0) { logger.Warn("Operation: Get categories list - Message: There are no categories"); }
                else { logger.Info("Operation: Get categories list"); }

                return categorias.Select(CategoriaDTO.ToDto).ToList();
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
        public List<DificultadDTO> GetDificultadesByOrigen(string pOrigen)
        {
            try
            {
                var dificultades = Contexto.Instancia.PreguntaStorage.GetDificultadesByOrigen(pOrigen);

                if (dificultades.Count == 0) { logger.Warn("Operation: Get difficulties list - Message: There are no difficulties"); }
                else { logger.Info("Operation: Get difficulties list"); }

                return dificultades.Select(DificultadDTO.ToDto).ToList();
            }
            catch (Exception ex)
            {
                logger.Error($"Operation: Get difficulties list - Message: {ex.Message}");
                throw;
            }
            
        }
       
    }
}
