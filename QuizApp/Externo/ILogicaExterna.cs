using Quizzify.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzify.Externo
{
    /// <summary>
    /// Representa logica que va por fuera de las reglas de negocio
    /// </summary>
    internal interface ILogicaExterna
    {
        /// <summary>
        /// Calcular el puntaje de una sesion de juego
        /// </summary>
        /// <param name="pElecciones">Elecciones de pregunta/respuesta de usuario</param>
        /// <param name="pTiempo">Tiempo insumido</param>
        /// <returns></returns>
        public double CalcularPuntaje(List<PreguntaYRespuestaDTO> pElecciones, double pTiempo);
    }
}
