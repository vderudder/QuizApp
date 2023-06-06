namespace Quizzify.IO
{
    internal class PreguntaYRespuestaDTO
    {
        public PreguntaDTO iPregunta;
        public string iRespuesta;

        public PreguntaYRespuestaDTO(PreguntaDTO iPregunta, string iRespuesta)
        {
            this.iPregunta = iPregunta;
            this.iRespuesta = iRespuesta;
        }
    }
}
