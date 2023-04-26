using QuizApp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Contexto.iServicioBD.Sesiones.Add(new DB.QuizContext.Sesion() {SesionId = Guid.NewGuid().ToString(), UsuarioId = pUsuarioId, SesionPuntaje = pPuntaje, SesionTiempo = pTiempo, SesionFecha = pFecha });
            Contexto.iServicioBD.SaveChanges();
            
            return new SesionDTO() { iUsuarioId = pUsuarioId, iPuntaje = pPuntaje, iTiempo = pTiempo, iFecha = pFecha };

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
                sesionesDTO.Add(new SesionDTO() { iId = item.SesionId, iUsuarioId = item.UsuarioId, iPuntaje = item.SesionPuntaje, iTiempo = item.SesionTiempo, iFecha = item.SesionFecha });
            };

            return sesionesDTO;
        }

    }

    public class SesionDTO
    {
        public string iId;
        public string iUsuarioId;
        public double iPuntaje;
        public double iTiempo;
        public DateTime iFecha;

        public SesionDTO(string iId, string iUsuarioId, double iPuntaje, double iTiempo, DateTime iFecha)
        {
            this.iId = iId;
            this.iUsuarioId = iUsuarioId;
            this.iPuntaje = iPuntaje;
            this.iTiempo = iTiempo;
            this.iFecha = iFecha;
        }
        public SesionDTO() { }
    }
}
