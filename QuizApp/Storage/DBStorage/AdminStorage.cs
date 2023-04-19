using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Runtime.InteropServices.JavaScript;
using System.Security.Policy;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Web;

namespace QuizApp.Storage.DBStorage
{
    internal class AdminStorage
    {
        public async Task<List<PreguntaDTO>> getPreguntas(string pUrl)
        {
            HttpClient client = new HttpClient();

            // Se hace la request
            var response = await client.GetFromJsonAsync<JsonResponse>(pUrl);

            if (response.response_code != 0)
            {
                if (response.response_code == 1)
                {
                    throw new Excepcion.NoResultException();
                }

                if (response.response_code == 2)
                {
                    throw new Excepcion.InvalidParameterException();
                }

                throw new Exception();
            }

            // Esto va a ser lo que devuelva
            List<PreguntaDTO> preguntas = new();

            // Se recorre la response para formar los datos a guardar
            for (int i = 0; i < response.results.Length; i++)
            {
                var preg = response.results[i];
                List<string> incorrectas = new();

                foreach (var item in preg.incorrect_answers)
                {
                    incorrectas.Add(HttpUtility.HtmlDecode(item));
                }

                var decoded = HttpUtility.HtmlDecode(preg.question);

                var preguntaDTO = new PreguntaDTO(HttpUtility.HtmlDecode(preg.question), preg.difficulty, preg.category, HttpUtility.HtmlDecode(preg.correct_answer), incorrectas);
                preguntas.Add(preguntaDTO);
            }

            return preguntas;


        }

        internal record class JsonResponse
        {
            public int response_code { get; set; }
            public JsonResults[] results { get; set; }

        }

        internal record class JsonResults
        {
            public string category { get; set; }
            public string type { get; set; }
            public string difficulty { get; set; }
            public string question { get; set; }
            public string correct_answer { get; set; }
            public string[] incorrect_answers { get; set; }
        }
    }
}
