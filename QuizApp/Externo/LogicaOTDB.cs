using QuizApp.UI;
using Quizzify.Dominio;
using Quizzify.Dominio.Util;
using Quizzify.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzify.Externo
{
    /// <summary>
    /// Logica que corresponde exclusivamente a OTDB
    /// </summary>
    public class LogicaOTDB : ILogicaExterna
    {
        /// <summary>
        /// Calcula el puntaje de una sesion
        /// </summary>
        /// <param name="pElecciones">Elecciones del usuario</param>
        /// <param name="pTiempo">Tiempo insumido</param>
        /// <returns>Devuelve el valor del puntaje</returns>
        public double CalcularPuntaje(List<PreguntaYRespuestaDTO> pElecciones, double pTiempo)
        {
            List<PreguntaYRespuesta> elecciones = new List<PreguntaYRespuesta>();

            foreach (var el in pElecciones)
            {
                elecciones.Add(PreguntaYRespuestaDTO.ToEntity(el));
            }


            int cantCorrectas = 0;
            int cantPreguntas = elecciones.Count();
            int factorDificultad = elecciones[0].Pregunta.Dificultad.Factor;
            double tiempo = pTiempo / cantPreguntas;
            int factorTiempo = 0;

            // Se fija cuales son las respuestas correctas
            foreach (var eleccion in elecciones)
            {
                if (eleccion.Pregunta.EsRespuestaCorrecta(eleccion.Respuesta))
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
            return ((double)cantCorrectas / cantPreguntas) * factorDificultad * factorTiempo;
        }
    }
}
