using Microsoft.VisualBasic.ApplicationServices;
using QuizApp.Dominio.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Dominio
{
    internal class Sesion
    {
        // Atributos
        private string? iId;
        private DateTime iFecha;
        private int iTiempo;
        private int iPuntaje;
        private Usuario iUsuario;
        private List<PreguntaYRespuesta> iEleccionesUsuario;

        // Propiedades
        public string? Id => iId;
        public DateTime Fecha => iFecha;
        public int Puntaje
        {
            get { return iPuntaje; }
            set { iPuntaje = value; }

        }
        public int Tiempo => iTiempo;
        public Usuario Usuario => iUsuario;

        // Constructor
        public Sesion(int pTiempo, List<PreguntaYRespuesta> pEleccionesUsuario, Usuario pUsuario)
        {
            iTiempo = pTiempo;
            iEleccionesUsuario = pEleccionesUsuario;
            iUsuario = pUsuario;
        }

        // Metodos

        /// <summary>
        /// Termina la sesion de juego, calculando el puntaje
        /// </summary>
        public void finalizar()
        {
            int cantCorrectas = 0;
            int cantPreguntas = iEleccionesUsuario.Count();
            int factorDificultad = iEleccionesUsuario[0].iPregunta.Dificultad.Factor;
            int tiempo = iTiempo / cantPreguntas;
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
            iPuntaje = cantCorrectas / cantPreguntas * factorDificultad * factorTiempo;
        }
    }
}
