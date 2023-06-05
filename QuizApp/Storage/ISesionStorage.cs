using QuizApp.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzify.Storage
{
    internal interface ISesionStorage
    {
        public SesionDTO CreateSesion(string pUsuarioId, double pPuntaje, double pTiempo, DateTime pFecha);
        public List<SesionDTO> GetSesionesByPuntaje();

    }
}
