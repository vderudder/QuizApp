using log4net;
using QuizApp.UI;
using Quizzify.IO;

namespace Quizzify.Facade
{
    internal class UsuarioFacade
    {
        private static ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Obtiene la lista de usuarios existente
        /// </summary>
        /// <returns></returns>
        public List<UsuarioDTO> GetUsuarios()
        {
            try
            {
                // Obtiene los dto
                List<UsuarioDTO> usuariosDTO = Contexto.iInstancia.iUsuarioStorage.GetUsuarios();

                logger.Info("Operation: Get users list");

                return usuariosDTO;
            }
            catch (Exception ex)
            {
                logger.Error($"Operation: Get users list - Message: {ex.Message}");
                throw;
            }
            
        }
    }
}
