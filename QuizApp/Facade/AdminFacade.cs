using QuizApp.Dominio;
using QuizApp.Storage;
using QuizApp.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace QuizApp.Facade
{
    internal class AdminFacade
    {
        public async Task getPreguntas(string pUrl)
        {

            var preguntas = await Contexto.iInstancia.iAdminStorage.getPreguntas(pUrl);

            var memoria = Contexto.iInstancia.iPreguntaStorage.guardarPreguntas(preguntas);

        }
    }
}
