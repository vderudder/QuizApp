using Quizzify.Excepcion;
using QuizApp.UI;
using log4net;

namespace Quizzify.Facade
{
    internal class AdminFacade
    {
        private static ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Guarda las preguntas
        /// </summary>
        /// <param name="pUrl"></param>
        /// <returns></returns>
        public async Task GuardarPreguntas(string pUrl)
        {
            try
            {
                var preguntas = await Contexto.Instancia.PreguntaStorageExterno.GetPreguntas(pUrl);

                await Contexto.Instancia.PreguntaStorage.GuardarPreguntas(preguntas);

                logger.Info("Operation: Questions saved to DB");

            }
            catch (Exception ex)
            {
                if (ex is InvalidParameterException)
                {
                    logger.Error($"Operation: Questions saved to DB - Message: {ex.Message}");
                }
                else if (ex is NoResultException)
                {
                    logger.Error($"Operation: Questions saved to DB - Message: {ex.Message}");
                }
                else
                {
                    logger.Error($"Operation: Questions saved to DB - Message: {ex.Message}");
                }
                throw;
            }
        }
    }
}
