using QuizApp.UI;
using QuizApp.IO;

namespace QuizApp.Storage.DBStorage
{
    internal class SesionDBStorage
    {
        /// <summary>
        /// Crea una nueva sesion de juego
        /// </summary>
        /// <param name="pUsuarioId">El id de usuario</param>
        /// <param name="pPuntaje">El puntaje de la sesion</param>
        /// <param name="pTiempo">El tiempo insumido de la sesion</param>
        /// <param name="pFecha">La fecha que se realizo la sesion</param>
        /// <returns></returns>
        public SesionDTO CreateSesion(string pUsuarioId, double pPuntaje, double pTiempo, DateTime pFecha)
        {
            var sesionContext = Contexto.iServicioBD.Sesiones.Add(new DB.QuizContext.Sesion() {SesionId = Guid.NewGuid().ToString(), UsuarioId = pUsuarioId, SesionPuntaje = pPuntaje, SesionTiempo = pTiempo, SesionFecha = pFecha });
            Contexto.iServicioBD.SaveChanges();
            
            return new SesionDTO(sesionContext.Entity.SesionId, pUsuarioId, pPuntaje, pTiempo, pFecha);

        }

        /// <summary>
        /// Obtiene las sesiones ordenadas por puntaje de mayor a menor, tomando solo las primeras 20
        /// </summary>
        /// <returns></returns>
        public List<SesionDTO> GetSesionesByPuntaje()
        {
            var sesionesByPuntaje = Contexto.iServicioBD.Sesiones.OrderByDescending(ses => ses.SesionPuntaje).ToList();

            var sesionesTruncadas = sesionesByPuntaje.Take(20).Select(s => s).ToList();

            List<SesionDTO> sesionesDTO = new List<SesionDTO>();

            foreach (var item in sesionesTruncadas)
            {
                sesionesDTO.Add(new SesionDTO(item.SesionId, item.UsuarioId, item.SesionPuntaje, item.SesionTiempo, item.SesionFecha));
            };

            return sesionesDTO;
        }

    }

   
}
