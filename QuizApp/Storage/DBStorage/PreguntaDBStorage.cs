using Microsoft.EntityFrameworkCore;
using Quizzify.IO;

namespace Quizzify.Storage.DBStorage
{
    /// <summary>
    /// Corresponde al Storage de preguntas usando DB relacional
    /// </summary>
    internal class PreguntaDBStorage : IPreguntaStorage
    {
        /// <summary>
        /// Obtiene la lista de nombres de origenes
        /// </summary>
        /// <returns></returns>
        public List<string> GetOrigenes()
        {
            return ContextoDB.Instancia.ServicioBD.Origenes.Select(o => o.OrigenNombre).Distinct().ToList();
        }

        /// <summary>
        /// Obtiene los DTO de las preguntas con el filtro correspondiente
        /// </summary>
        /// <param name="pFiltro"></param>
        /// <returns></returns>
        public List<Dominio.Pregunta> GetPreguntasByFiltro(PreguntaFiltro pFiltro)
        {
            // Filtrar por categoria y dificultad
            var preguntasByCategoriaDificultad = ContextoDB.Instancia.ServicioBD.Preguntas.Include(p => p.Categoria).Include(p => p.Dificultad).Where(p => p.Dificultad.DificultadNombre == pFiltro.Dificultad && p.Categoria.CategoriaNombre == pFiltro.Categoria).ToList();

            // Desordenar y tomar la cantidad del filtro
            var preguntasFiltradas = preguntasByCategoriaDificultad.OrderBy(elem => Guid.NewGuid()).ToList().Take(pFiltro.Cantidad).ToList();

            return preguntasFiltradas.Select(DB.QuizContext.Pregunta.DAOToEntity).ToList();

        }

        /// <summary>
        /// Guarda las preguntas en la DB
        /// </summary>
        /// <param name="pPreguntas"></param>
        /// <returns></returns>
        public Task GuardarPreguntas(List<PreguntaDTO> pPreguntas, string pOrigen)
        {
            var origenId = GetOrigenIdByNombre(pOrigen);

            foreach (var p in pPreguntas)
            {
                var categoriaId = GetCategoriaIdByNombre(p.Categoria.Nombre);
                if (categoriaId == null)
                {

                    var categoriaContext = ContextoDB.Instancia.ServicioBD.Categorias.Add(new DB.QuizContext.Categoria() { CategoriaId = Guid.NewGuid().ToString(), CategoriaNombre = p.Categoria.Nombre });
                    ContextoDB.Instancia.ServicioBD.SaveChanges();

                    categoriaId = categoriaContext.Entity.CategoriaId;
                }

                var dificultadId = GetDificultadIdByNombre(p.Dificultad.Nombre);
                if (dificultadId == null)
                {
                    var dificultadContext = ContextoDB.Instancia.ServicioBD.Dificultades.Add(new DB.QuizContext.Dificultad() { DificultadId = Guid.NewGuid().ToString(), DificultadNombre = p.Dificultad.Nombre });
                    ContextoDB.Instancia.ServicioBD.SaveChanges();

                    dificultadId = dificultadContext.Entity.DificultadId;
                }

                if (!ExistePregunta(p.Nombre))
                {
                    var preguntaDAO = new DB.QuizContext.Pregunta
                    {
                        PreguntaId = Guid.NewGuid().ToString(),
                        PreguntaNombre = p.Nombre,
                        PreguntaCorrecta = p.Correcta,
                        PreguntaIncorrectas = p.Incorrectas.ToArray(),
                        CategoriaId = categoriaId,
                        DificultadId = dificultadId,
                        OrigenId = origenId
                    };

                    ContextoDB.Instancia.ServicioBD.Preguntas.Add(preguntaDAO);
                    ContextoDB.Instancia.ServicioBD.SaveChanges();
                }
            };

            return Task.CompletedTask;
        }

        /// <summary>
        /// Obtiene las categorias
        /// </summary>
        /// <returns></returns>
        public List<Dominio.Categoria> GetCategoriasByOrigen(string pOrigen)
        {
            var id = GetOrigenIdByNombre(pOrigen);

            var categoriaList = ContextoDB.Instancia.ServicioBD.Preguntas.Include(p => p.Categoria).Where(p => p.OrigenId == id).Select(p => p.Categoria).Distinct().ToList();

            return categoriaList.Select(DB.QuizContext.Categoria.DAOToEntity).ToList();

        }

        /// <summary>
        /// Obtiene las dificultades
        /// </summary>
        /// <returns></returns>
        public List<Dominio.Dificultad> GetDificultadesByOrigen(string pOrigen)
        {
            var id = GetOrigenIdByNombre(pOrigen);

            var dificultadList = ContextoDB.Instancia.ServicioBD.Preguntas.Include(p => p.Dificultad).Where(p => p.OrigenId == id).Select(p => p.Dificultad).Distinct().ToList();

            return dificultadList.Select(DB.QuizContext.Dificultad.DAOToEntity).ToList();

        }

        /// <summary>
        /// Obtiene el id de categoria segun el nombre
        /// </summary>
        /// <param name="pNombre"></param>
        /// <returns></returns>
        public string? GetCategoriaIdByNombre(string pNombre)
        {
            var cat = ContextoDB.Instancia.ServicioBD.Categorias.Where(c => c.CategoriaNombre == pNombre).SingleOrDefault();

            if (cat == null)
            {
                return null;
            }
            else
            {
                return cat.CategoriaId;
            }

        }
        /// <summary>
        /// Obtiene el id de dificultad segun el nombre
        /// </summary>
        /// <param name="pNombre"></param>
        /// <returns></returns>
        public string? GetDificultadIdByNombre(string pNombre)
        {
            var dif = ContextoDB.Instancia.ServicioBD.Dificultades.Where(d => d.DificultadNombre == pNombre).SingleOrDefault();

            if (dif == null)
            {
                return null;
            }
            else
            {
                return dif.DificultadId;
            }

        }

        /// <summary>
        /// Chequea si existe la pregunta dada
        /// </summary>
        /// <param name="pPregunta"></param>
        /// <returns></returns>
        public bool ExistePregunta(string pPregunta)
        {
            return ContextoDB.Instancia.ServicioBD.Preguntas.Any(p => p.PreguntaNombre == pPregunta);
        }

        /// <summary>
        /// Obtiene el id de origen segun nombre dado
        /// </summary>
        /// <param name="pNombre"></param>
        /// <returns></returns>
        public string? GetOrigenIdByNombre(string pNombre)
        {
            var origen = ContextoDB.Instancia.ServicioBD.Origenes.Where(o => o.OrigenNombre == pNombre).SingleOrDefault();

            if (origen == null)
            {
                return null;
            }
            else
            {
                return origen.OrigenId;
            }
        }

    }

    /// <summary>
    /// Representa el filtro que se va a utilizar para filtrar las preguntas de una sesion de juego por comenzar
    /// </summary>
    internal class PreguntaFiltro
    {
        // Atributos
        public string Dificultad { get; set; }
        public string Categoria { get; set; }
        public int Cantidad { get; set; }

    }

}
