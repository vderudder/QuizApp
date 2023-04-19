using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace QuizApp.DB
{
    public partial class QuizContext : DbContext
    {
        public virtual DbSet<Dificultad> Dificultades { get; set; }
        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Pregunta> Preguntas { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Sesion> Sesiones { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(ConfigurationManager.ConnectionStrings["QuizDatabase"].ConnectionString);
            }
        }

        public class Usuario
        {
            public string UsuarioId { get; set; }
            public string UsuarioNombre { get; set; }
        }

        public class Dificultad
        {
            public string DificultadId { get; set; }
            public string DificultadNombre { get; set; }

        }

        public class Categoria
        {
            public string CategoriaId { get; set; }
            public string CategoriaNombre { get; set; }

        }

        public class Pregunta
        {
            public string PreguntaId { get; set; }
            public string PreguntaNombre { get; set; }
            public string PreguntaCorrecta { get; set; }
            public string[] PreguntaIncorrectas { get; set; }
            public string CategoriaId { get; set; }
            public string DificultadId { get; set; }

            public Categoria Categoria { get; set; }
            public Dificultad Dificultad { get; set; }

        }

        public class Sesion
        {
            public string SesionId { get; set; }
            public DateTime SesionFecha { get; set; }
            public double SesionTiempo { get; set; }
            public double SesionPuntaje { get; set; }
            public string UsuarioId { get; set; }

            public Usuario Usuario { get; set; }
        }
    }
}
