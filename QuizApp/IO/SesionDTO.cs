using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.IO
{
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
    }
}
