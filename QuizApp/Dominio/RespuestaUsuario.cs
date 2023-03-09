using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Dominio
{
    /// <summary>
    /// Clase para persistir las respuestas del usuario en una sesion
    /// </summary>
    internal class RespuestaUsuario
    {
        // Atributos
        private string iId;
        private string iRespuesta;
        private Pregunta iPregunta;

        // Propiedades
        public string Id => iId;
        public string Respuesta
        {
            get { return iRespuesta; }
            set { iRespuesta = value; }
        }

        public Pregunta Pregunta => iPregunta;

        // Constructor
        public RespuestaUsuario(string pId, Pregunta pPregunta)
        {
            iId = pId;
            iPregunta = pPregunta;
        }

        // Metodos

        public bool EsCorrecta()
        {
            return iPregunta.EsRespuestaCorrecta(iRespuesta);
        }

        public void ResponderPregunta(string pRespuesta)
        {
            iRespuesta = pRespuesta;
        }
    }
}
