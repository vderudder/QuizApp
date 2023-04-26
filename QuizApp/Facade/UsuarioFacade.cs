using QuizApp.Dominio;
using QuizApp.UI;
using QuizApp.IO;

namespace QuizApp.Facade
{
    internal class UsuarioFacade
    {
        /// <summary>
        /// Obtiene la lista de usuarios existente
        /// </summary>
        /// <returns></returns>
        public List<Usuario> GetUsuarios()
        {
            try
            {
                // Obtiene los dto
                List<UsuarioDTO> usuariosDTO = Contexto.iInstancia.iUsuarioStorage.GetUsuarios();
                List<Usuario> usuarios = new List<Usuario>();

                foreach (var item in usuariosDTO)
                {
                    usuarios.Add(new Usuario(item.iId, item.iNombre));
                }

                Bitacora.Log($"Operation: Get users list\nState: Success");

                return usuarios;
            }
            catch (Exception ex)
            {
                Bitacora.Log($"Operation: Get users list\nState: Error\nMessage: {ex.Message}");
                throw;
            }
            
        }
    }
}
