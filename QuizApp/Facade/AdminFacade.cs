using QuizApp.Dominio;
using QuizApp.Excepcion;
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
            try
            {
                var preguntas = await Contexto.iInstancia.iAdminStorage.getPreguntas(pUrl);

                await Contexto.iInstancia.iPreguntaStorage.guardarPreguntas(preguntas);

                Bitacora.Log("Operation: Questions saved to DB\nState: Success");
            }
            catch (Exception ex)
            {
                if (ex is InvalidParameterException)
                {
                    Bitacora.Log($"Operation: Questions saved to DB\nState: Error\nMessage: {ex.Message}");
                }
                else if (ex is NoResultException)
                {
                    Bitacora.Log($"Operation: Questions saved to DB\nState: Error\nMessage: {ex.Message}");
                }
                else
                {
                    Bitacora.Log($"Operation: Questions saved to DB\nState: Error\nMessage: {ex.Message}");
                }
                throw;
            }
        }
    }
}
