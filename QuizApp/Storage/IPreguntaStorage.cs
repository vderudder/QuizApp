using QuizApp.IO;
using QuizApp.Storage.DBStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
