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

        // Constructor
         public Sesion() { }

        // Metodos

        /// <summary>
        /// Inicia la sesion de juego, comenzando el contador de tiempo
        /// </summary>
        public void IniciarContador()
        {
            iStopwatch.Start();
        }

        public void FinalizarContador()
        {
            iStopwatch.Stop();
            iTiempo = iStopwatch.Elapsed.TotalSeconds;
        }

        /// <summary>
        /// Termina la sesion de juego, calculando el puntaje
        /// </summary>
        public void CalcularPuntaje(List<PreguntaYRespuesta> pEleccionesUsuario, Usuario pUsuario)
        {
            iEleccionesUsuario = pEleccionesUsuario;
            iUsuario = pUsuario;

            int cantCorrectas = 0;
            int cantPreguntas = iEleccionesUsuario.Count();
            int factorDificultad = iEleccionesUsuario[0].iPregunta.Dificultad.Factor;
            double tiempo = iTiempo / cantPreguntas;
            int factorTiempo = 0;

            // Se fija cuales son las respuestas correctas
            foreach (var eleccion in iEleccionesUsuario)
            {
                if (eleccion.iPregunta.EsRespuestaCorrecta(eleccion.iRespuesta))
                {
                    cantCorrectas++;
                }
            }

            // Determina el factor tiempo
            if (tiempo <= 5)
            {
                factorTiempo = 5;
            }
            else if (tiempo > 5 && tiempo < 20)
            {
                factorTiempo = 3;
            }
            else if (tiempo >= 20)
            {
                factorTiempo = 1;
            }

            // Puntaje = cant de respuestas correctas / cant de preguntas * factor dificultad * factor tiempo
            iPuntaje = ((double)cantCorrectas / cantPreguntas) * factorDificultad * factorTiempo;
        }
    }
}
