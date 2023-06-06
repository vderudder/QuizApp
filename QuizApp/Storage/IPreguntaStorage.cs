using Quizzify.IO;
using Quizzify.Storage.DBStorage;

namespace Quizzify.Storage
{
    internal interface IPreguntaStorage
    {
        public List<PreguntaDTO> GetPreguntasByFiltro(PreguntaFiltro pFiltro);
        public Task GuardarPreguntas(List<PreguntaDTO> pPreguntas);
        public List<CategoriaDTO> GetCategorias();
        public List<DificultadDTO> GetDificultades();
        public string? GetCategoriaIdByNombre(string pNombre);
        public string? GetDificultadIdByNombre(string pNombre);
        public bool ExistePregunta(string pPregunta);

    }
}
