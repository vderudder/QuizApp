using QuizApp.UI;
using Quizzify.IO;

namespace Quizzify.Facade
{
    internal class UsuarioFacade
    {
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

                Bitacora.Log($"Operation: Get users list\nState: Success");

                return usuariosDTO;
            }
            catch (Exception ex)
            {
                Bitacora.Log($"Operation: Get users list\nState: Error\nMessage: {ex.Message}");
                throw;
            }
            
        }
    }
}
