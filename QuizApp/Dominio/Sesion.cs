using Quizzify.Dominio.Util;
using System.Diagnostics;

namespace Quizzify.Dominio
{
    /// <summary>
    /// Clase para persistir las sesiones de juego
    /// </summary>
    internal class Sesion
    {
        // Atributos
        private string? iId;
        private DateTime iFecha;
        private double iTiempo;
        private double iPuntaje;
        private Usuario iUsuario;
        private List<PreguntaYRespuesta> iEleccionesUsuario;

        private Stopwatch iStopwatch = new Stopwatch();

        // Propiedades
        public string? Id => iId;
        public DateTime Fecha => iFecha;
        public double Puntaje
        {
            get { return iPuntaje; }
            set { iPuntaje = value; }

        }
        public double Tiempo => iTiempo;
        public Usuario Usuario => iUsuario;
        public List<PreguntaYRespuesta> EleccionesUsuario
        {
            get { return iEleccionesUsuario; }
            set { iEleccionesUsuario = value; }

        }

        // Constructor
        public Sesion() { }

        // Metodos

        /// <summary>
        /// Inicia el contador de tiempo
        /// </summary>
        public void IniciarContador()
        {
            iStopwatch.Start();
        }

        /// <summary>
        /// Finaliza el contador de tiempo
        /// </summary>
        public void FinalizarContador()
        {
            iStopwatch.Stop();
            iTiempo = iStopwatch.Elapsed.TotalSeconds;
        }

       
    }
}
