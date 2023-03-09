using QuizApp.Dominio;
using QuizApp.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Facade
{
    internal class PreguntaFacade
    {
        public List<Pregunta> getPreguntas()
        {
            var storage = new PreguntaStorage();
            var preguntaDTOs = storage.getPreguntasByFiltro(new PreguntaFiltro("1", "1", 3));

            var preguntas = preguntaDTOs.Select(dto => new Pregunta(
                                                dto.iPregunta,
                                                getCategoriaById(dto.iCategoriaId),
                                                getDificultadById(dto.iDificultadId),
                                                getTipoPreguntaById(dto.iTipoPreguntaId),
                                                dto.iCorrecta,
                                                dto.iIncorrectaList.ToList())
                                                ).ToList();

            return preguntas;
        }

        private Categoria getCategoriaById(string pId)
        {
            return new Categoria(pId, "Matematicas");
        }

        private Dificultad getDificultadById(string pId)
        {
            return new Dificultad(pId, "Facil");

        }
        private TipoPregunta getTipoPreguntaById(string pId)
        {
            return new TipoPregunta(pId, "Multiple");

        }

       
    }
}
