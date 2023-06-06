using System.Net.Http.Json;
using System.Web;
using Quizzify.IO;

namespace Quizzify.Storage.ExternalStorage
{
    internal class OpenTDBPreguntaStorage : IPreguntaStorageExterno
    {
        public async Task<List<PreguntaDTO>> GetPreguntas(string pUrl)
        {
            HttpClient client = new HttpClient();

            // Se hace la request
            var response = await client.GetFromJsonAsync<JsonResponse>(pUrl);

            if (response.Response_code != 0)
            {
                if (response.Response_code == 1)
                {
                    throw new Excepcion.NoResultException();
                }

                if (response.Response_code == 2)
                {
                    throw new Excepcion.InvalidParameterException();
                }

                throw new Exception();
            }

            // Esto va a ser lo que devuelva
            List<PreguntaDTO> preguntas = new();

            // Se recorre la response para formar los datos a guardar
            for (int i = 0; i < response.Results.Length; i++)
            {
                var preg = response.Results[i];
                List<string> incorrectas = new();

                foreach (var item in preg.Incorrect_answers)
                {
                    incorrectas.Add(HttpUtility.HtmlDecode(item));
                }

                var preguntaDTO = new PreguntaDTO(HttpUtility.HtmlDecode(preg.Question), preg.Difficulty, preg.Category, HttpUtility.HtmlDecode(preg.Correct_answer), incorrectas);
                preguntas.Add(preguntaDTO);
            }

            return preguntas;


        }

        internal record class JsonResponse
        {
            public int Response_code { get; set; }
            public JsonResults[] Results { get; set; }

        }

        internal record class JsonResults
        {
            public string Category { get; set; }
            public string Type { get; set; }
            public string Difficulty { get; set; }
            public string Question { get; set; }
            public string Correct_answer { get; set; }
            public string[] Incorrect_answers { get; set; }
        }
    }
}
