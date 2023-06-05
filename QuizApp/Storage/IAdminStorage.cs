using QuizApp.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzify.Storage
{
    internal interface IAdminStorage
    {
        public Task<List<PreguntaDTO>> GetPreguntas(string pUrl);

    }
}
