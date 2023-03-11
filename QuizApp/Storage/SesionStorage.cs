using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Storage
{
    internal class SesionStorage
    {
        private List<SesionDTO> iSesionesEnMemoria = new List<SesionDTO>() {
            new SesionDTO(){ iId = "1", iUsuarioId = "1", iPuntaje = 4, iTiempo = 20, iFecha = DateTime.Now },
            new SesionDTO(){ iId = "2", iUsuarioId = "2", iPuntaje = 10, iTiempo = 15, iFecha = DateTime.Now },
            new SesionDTO(){ iId = "3", iUsuarioId = "1", iPuntaje = 42, iTiempo = 5, iFecha = DateTime.Now },
            new SesionDTO(){ iId = "4", iUsuarioId = "3", iPuntaje = 22, iTiempo = 10, iFecha = DateTime.Now },
        };

        /// <summary>
        /// Crea una nueva sesion de juego
        /// </summary>
        /// <param name="pUsuarioId">El id de usuario</param>
        /// <param name="pPuntaje">El puntaje de la sesion</param>
        /// <param name="pTiempo">El tiempo insumido de la sesion</param>
        /// <param name="pFecha">La fecha que se realizo la sesion</param>
        /// <returns></returns>
        public SesionDTO createSesion(string pUsuarioId, int pPuntaje, int pTiempo, DateTime pFecha)
        {
            var sesion = new SesionDTO(Guid.NewGuid().ToString(), pUsuarioId, pPuntaje, pTiempo, pFecha);
            iSesionesEnMemoria.Add(sesion);
            return sesion;
        }
    }

    public class SesionDTO
    {
        public string iId;
        public string iUsuarioId;
        public int iPuntaje;
        public int iTiempo;
        public DateTime iFecha;

        public SesionDTO(string iId, string iUsuarioId, int iPuntaje, int iTiempo, DateTime iFecha)
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
