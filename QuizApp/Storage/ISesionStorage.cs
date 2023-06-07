using Quizzify.IO;

namespace Quizzify.Storage
{
    /// <summary>
    /// Storage para las sesiones locales
    /// </summary>
    internal interface ISesionStorage
    {
        /// <summary>
        /// Crea una nueva sesion
        /// </summary>
        /// <param name="pUsuarioId">Id del usuario</param>
        /// <param name="pPuntaje">Puntaje de la sesion</param>
        /// <param name="pTiempo">Tiempo insumido en la sesion</param>
        /// <param name="pFecha">Fecha de la sesion</param>
        /// <returns></returns>
        public SesionDTO CreateSesion(string pUsuarioId, double pPuntaje, double pTiempo, DateTime pFecha);
        /// <summary>
        /// Obtiene sesiones segun el puntaje
        /// </summary>
        /// <returns></returns>
        public List<SesionDTO> GetSesionesByPuntaje();

    }
}
