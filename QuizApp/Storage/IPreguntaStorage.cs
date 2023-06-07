using Quizzify.IO;
using Quizzify.Storage.DBStorage;

namespace Quizzify.Storage
{
    /// <summary>
    /// Storage para las preguntas locales
    /// </summary>
    internal interface IPreguntaStorage
    {
        /// <summary>
        /// Obtiene preguntas segun un filtro dado
        /// </summary>
        /// <param name="pFiltro">Filtro de pregunta segun categoria, dificultad y cantidad de preguntas</param>
        /// <returns></returns>
        public List<PreguntaDTO> GetPreguntasByFiltro(PreguntaFiltro pFiltro);
        /// <summary>
        /// Guarda las preguntas
        /// </summary>
        /// <param name="pPreguntas"></param>
        /// <returns></returns>
        public Task GuardarPreguntas(List<PreguntaDTO> pPreguntas);
        /// <summary>
        /// Obtiene todas las categorias
        /// </summary>
        /// <returns></returns>
        public List<CategoriaDTO> GetCategorias();
        /// <summary>
        /// Obtiene todas las dificultades
        /// </summary>
        /// <returns></returns>
        public List<DificultadDTO> GetDificultades();
        /// <summary>
        /// Obtiene el id de categoria segun el nombre dado
        /// </summary>
        /// <param name="pNombre"></param>
        /// <returns></returns>
        public string? GetCategoriaIdByNombre(string pNombre);
        /// <summary>
        /// Obtiene el id de dificultad segun el nombre dado
        /// </summary>
        /// <param name="pNombre"></param>
        /// <returns></returns>
        public string? GetDificultadIdByNombre(string pNombre);
        /// <summary>
        /// Chequea si existe la pregunta que le pasamos
        /// </summary>
        /// <param name="pPregunta"></param>
        /// <returns></returns>
        public bool ExistePregunta(string pPregunta);

    }
}
