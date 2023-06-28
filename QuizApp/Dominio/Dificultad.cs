

namespace Quizzify.Dominio
{
    /// <summary>
    /// Clase para persistir la dificultad de la trivia
    /// </summary>
    public class Dificultad
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public int Factor { get; set; }
       
        }
}
