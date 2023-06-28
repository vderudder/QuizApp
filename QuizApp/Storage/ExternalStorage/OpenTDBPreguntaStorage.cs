using System.Net.Http.Json;
using System.Web;
using Quizzify.IO;

namespace Quizzify.Storage.ExternalStorage
{
    /// <summary>
    /// Corresponde al storage de preguntas obtenidas usando OTDB API.
    /// Si se quiere usar otra API, se debe agregar otra clase que extienda de IPreguntaStorageExterno
    /// y que implemente su propio metodo de obtencion
    /// </summary>
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

                var incorrectas = preg.Incorrect_answers.ToList().Select(i => HttpUtility.HtmlDecode(i)).ToList();

                var preguntaDTO = new PreguntaDTO { Nombre = HttpUtility.HtmlDecode(preg.Question), Dificultad = new DificultadDTO { Nombre = preg.Difficulty }, Categoria = new CategoriaDTO { Nombre = preg.Category }, Correcta = HttpUtility.HtmlDecode(preg.Correct_answer), Incorrectas = incorrectas };
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
