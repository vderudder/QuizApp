using Microsoft.VisualBasic.ApplicationServices;
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
        private string iId;
        private DateTime iFecha;
        private int iTiempo;
        private int iPuntaje;
        private Usuario iUsuario;
        private IList<RespuestaUsuario> iRespuestasUsuario;

        // Propiedades
        public string Id => iId;
        public DateTime Fecha
        {
            get { return iFecha; }
            set { iFecha = value; }
        }

        public int Tiempo
        {
            get { return iTiempo; }
            set { iTiempo = value; }
        }

        public int Puntaje
        {
            get { return iPuntaje; }
            set { iPuntaje = value; }

        }
        public Usuario Usuario => iUsuario;
        public IList<RespuestaUsuario> RespuestasUsuario => iRespuestasUsuario;

        // Constructor
        public Sesion(string pId, List<RespuestaUsuario> pRespuestasUsuario, Usuario pUsuario)
        {
            iId = pId;

            iRespuestasUsuario = pRespuestasUsuario;

            iUsuario = pUsuario;
        }

        // Metodos

        /// <summary>
        /// Comienza la sesion de juego
        /// </summary>
        public void Comenzar()
        {
            iFecha = DateTime.Now;
        }

        /// <summary>
        /// Termina la sesion de juego
        /// </summary>
        public void Finalizar()
        {
            int numCorrectas = 0;
            int numPreguntas = iRespuestasUsuario.Count();
            //Se hizo asi para mantener el modelo relacional en una forma normal donde no haya dependencia transitiva de sus atributos
            int factorDificultad = iRespuestasUsuario[0].Pregunta.Dificultad.Factor;
            DateTime fechaFin = DateTime.Now;
            double tiempoTranscurrido = (fechaFin - iFecha).TotalSeconds;
            iTiempo = ((int)Math.Round(tiempoTranscurrido, 2));
            int tiempo = iTiempo / numPreguntas;
            int factorTiempo = 0;

            // Se fija cuales son las respuestas correctas
            foreach (var res in iRespuestasUsuario)
            {
                if (res.EsCorrecta())
                {
                    numCorrectas++;
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
            iPuntaje = numCorrectas / numPreguntas * factorDificultad * factorTiempo;


        }
    }
}
