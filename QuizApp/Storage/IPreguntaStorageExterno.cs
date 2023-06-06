using Quizzify.IO;

namespace Quizzify.Storage
{
    internal interface IPreguntaStorageExterno
    {
        public Task<List<PreguntaDTO>> GetPreguntas(string pUrl);
    }
}
