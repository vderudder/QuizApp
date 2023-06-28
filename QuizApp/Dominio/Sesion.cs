using Quizzify.Dominio.Util;
using System.Diagnostics;

namespace Quizzify.Dominio
{
    /// <summary>
    /// Clase para persistir las sesiones de juego
    /// </summary>
    public class Sesion
    {
        public string Id { get; set; }
        public DateTime Fecha { get; set; }
        public double Tiempo { get; set; }
        public double Puntaje { get; set; }
        public Usuario Usuario { get; set; }    

        private Stopwatch iStopwatch = new Stopwatch();    

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
        public double FinalizarContador()
        {
            iStopwatch.Stop();
            Tiempo = iStopwatch.Elapsed.TotalSeconds;
            return Tiempo;
        }

       
    }
}
