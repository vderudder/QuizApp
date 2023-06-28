using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Quizzify.DB
{
    public partial class QuizContext : DbContext
    {
        public virtual DbSet<Origen> Origenes { get; set; }
        public virtual DbSet<Dificultad> Dificultades { get; set; }
        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Pregunta> Preguntas { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Sesion> Sesiones { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configurar la conexion
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(ConfigurationManager.ConnectionStrings["QuizDatabase"].ConnectionString);
            }
        }

        // Clases de base de datos
        public class Origen
        {
            public string OrigenId { get; set; }
            public string OrigenNombre { get; set; }

            /// <summary>
            /// Transforma DAO a entidad de dominio
            /// </summary>
            /// <param name="pDao"></param>
            /// <returns>Entidad de dominio</returns>
            public static Dominio.Origen DAOToEntity(Origen pDao)
            {
                return new Dominio.Origen() { Id = pDao.OrigenId, Nombre = pDao.OrigenNombre };
            }

        }

            public class Usuario
        {
            public string UsuarioId { get; set; }
            public string UsuarioNombre { get; set; }

            /// <summary>
            /// Transforma DAO a entidad de dominio
            /// </summary>
            /// <param name="pDao"></param>
            /// <returns>Entidad de dominio</returns>
            public static Dominio.Usuario DAOToEntity(Usuario pDao)
            {
                return new Dominio.Usuario() { Id = pDao.UsuarioId, Nombre = pDao.UsuarioNombre };
            }
        }

        public class Dificultad
        {
            public string DificultadId { get; set; }
            public string DificultadNombre { get; set; }

            /// <summary>
            /// Transforma DAO a entidad de dominio
            /// </summary>
            /// <param name="pDao"></param>
            /// <returns>Entidad de dominio</returns>
            public static Dominio.Dificultad DAOToEntity(Dificultad pDao)
            {
                var factor = 0;
                switch (pDao.DificultadNombre)
                {
                    case "easy":
                        factor = 1; 
                        break;
                    case "medium":
                        factor = 3; break;
                    case "hard":
                        factor = 5; break;
                    default:
                        factor = 0;
                        break;
                }

                return new Dominio.Dificultad() { Id = pDao.DificultadId, Nombre = pDao.DificultadNombre, Factor = factor };
            }
        }

        public class Categoria
        {
            public string CategoriaId { get; set; }
            public string CategoriaNombre { get; set; }

            /// <summary>
            /// Transforma DAO a entidad de dominio
            /// </summary>
            /// <param name="pDao"></param>
            /// <returns>Entidad de dominio</returns>
            public static Dominio.Categoria DAOToEntity(Categoria pDao)
            {
                return new Dominio.Categoria() { Id = pDao.CategoriaId, Nombre = pDao.CategoriaNombre };
            }

        }

        public class Pregunta
        {
            public string PreguntaId { get; set; }
            public string PreguntaNombre { get; set; }
            public string PreguntaCorrecta { get; set; }
            public string[] PreguntaIncorrectas { get; set; }
            public string CategoriaId { get; set; }
            public string DificultadId { get; set; }
            public string OrigenId { get; set; }

            public Categoria Categoria { get; set; }
            public Dificultad Dificultad { get; set; }
            public Origen Origen { get; set; }

            /// <summary>
            /// Transforma DAO a entidad de dominio
            /// </summary>
            /// <param name="pDao"></param>
            /// <returns>Entidad de dominio</returns>
            public static Dominio.Pregunta DAOToEntity(Pregunta pDao)
            {
                return new Dominio.Pregunta()
                {
                    Id = pDao.PreguntaId,
                    Nombre = pDao.PreguntaNombre,
                    Correcta = pDao.PreguntaCorrecta,
                    Incorrectas = pDao.PreguntaIncorrectas.ToList(),
                    Categoria = Categoria.DAOToEntity(pDao.Categoria),
                    Dificultad = Dificultad.DAOToEntity(pDao.Dificultad),
                    Origen = Origen.DAOToEntity(pDao.Origen)
                };
            }
        }

        public class Sesion
        {
            public string SesionId { get; set; }
            public DateTime SesionFecha { get; set; }
            public double SesionTiempo { get; set; }
            public double SesionPuntaje { get; set; }
            public string UsuarioId { get; set; }

            public Usuario Usuario { get; set; }

            /// <summary>
            /// Transforma DAO a entidad de dominio
            /// </summary>
            /// <param name="pDao"></param>
            /// <returns>Entidad de dominio</returns>
            public static Dominio.Sesion DAOToEntity(Sesion pDao)
            {
                return new Dominio.Sesion()
                {
                    Id = pDao.SesionId,
                    Fecha = pDao.SesionFecha,
                    Tiempo = pDao.SesionTiempo,
                    Puntaje = pDao.SesionPuntaje,
                    Usuario = Usuario.DAOToEntity(pDao.Usuario)
                };
            }
        }
    }
}
