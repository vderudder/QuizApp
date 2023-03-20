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
        public async Task guardarPreguntasLocal(string pUrl)
        {

            var preguntas = await Contexto.iInstancia.iAdminStorage.getPreguntas(pUrl);

            await Contexto.iInstancia.iPreguntaStorage.guardarPreguntas(preguntas);


        }
    }
}
