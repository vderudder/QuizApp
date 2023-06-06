using Quizzify.IO;

namespace Quizzify.Storage
{
    internal interface ISesionStorage
    {
        public SesionDTO CreateSesion(string pUsuarioId, double pPuntaje, double pTiempo, DateTime pFecha);
        public List<SesionDTO> GetSesionesByPuntaje();

    }
}
