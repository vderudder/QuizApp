using Quizzify.IO;

namespace Quizzify.Storage
{
    /// <summary>
    /// Storage para las preguntas por fuera de la aplicacion
    /// </summary>
    internal interface IPreguntaStorageExterno
    {
        /// <summary>
        /// Obtiene las preguntas desde fuera de la aplicacion
        /// </summary>
        /// <param name="pUrl"></param>
        /// <returns></returns>
        public Task<List<PreguntaDTO>> GetPreguntas(string pUrl);
    }
}
