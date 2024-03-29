﻿using Quizzify.Dominio.Util;

namespace Quizzify.IO
{
    /// <summary>
    /// Clase DTO de PreguntaYRespuesta
    /// </summary>
    public class PreguntaYRespuestaDTO : BaseDTO<PreguntaYRespuestaDTO, PreguntaYRespuesta>
    {
        public PreguntaDTO Pregunta { get; set; }
        public string Respuesta { get; set; }
    }
}
