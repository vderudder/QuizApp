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
        public List<PreguntaDTO> GetPreguntasByFiltro(PreguntaFiltro pFiltro)
        {
            // Filtrar por categoria y dificultad
            var preguntasByCategoriaDificultad = ContextoDB.Instancia.ServicioBD.Preguntas.Where(p => p.Dificultad.DificultadNombre == pFiltro.iDificultad && p.Categoria.CategoriaNombre == pFiltro.iCategoria).ToList();

            // Desordenar y tomar la cantidad del filtro
            var preguntasFiltradasContext = preguntasByCategoriaDificultad.OrderBy(elem => Guid.NewGuid()).ToList().Take(pFiltro.iCantidad).ToList();

            var preguntasFiltradas = new List<PreguntaDTO>();
            foreach (var preg in preguntasFiltradasContext)
            {
                preguntasFiltradas.Add(new PreguntaDTO(preg.PreguntaNombre, preg.Dificultad.DificultadNombre, preg.Categoria.CategoriaNombre, preg.PreguntaCorrecta, preg.PreguntaIncorrectas.ToList()));
            }

            return preguntasFiltradas;

        }

        /// <summary>
        /// Guarda las preguntas en la DB
        /// </summary>
        /// <param name="pPreguntas"></param>
        /// <returns></returns>
        public Task GuardarPreguntas(List<PreguntaDTO> pPreguntas)
        {
            foreach (var p in pPreguntas)
            {
                var categoriaId = GetCategoriaIdByNombre(p.iCategoriaNombre);
                if (categoriaId == null)
                {
                    var categoriaContext = ContextoDB.Instancia.ServicioBD.Categorias.Add(new DB.QuizContext.Categoria() { CategoriaId = Guid.NewGuid().ToString(), CategoriaNombre = p.iCategoriaNombre });
                    ContextoDB.Instancia.ServicioBD.SaveChanges();

                    categoriaId = categoriaContext.Entity.CategoriaId;
                }

                var dificultadId = GetDificultadIdByNombre(p.iDificultadNombre);
                if (dificultadId == null)
                {
                    var dificultadContext = ContextoDB.Instancia.ServicioBD.Dificultades.Add(new DB.QuizContext.Dificultad() { DificultadId = Guid.NewGuid().ToString(), DificultadNombre = p.iDificultadNombre });
                    ContextoDB.Instancia.ServicioBD.SaveChanges();

                    dificultadId = dificultadContext.Entity.DificultadId;
                }

                if (!ExistePregunta(p.iPregunta))
                {
                    ContextoDB.Instancia.ServicioBD.Preguntas.Add(new DB.QuizContext.Pregunta() { PreguntaId = Guid.NewGuid().ToString(), PreguntaNombre = p.iPregunta, PreguntaCorrecta = p.iCorrecta, PreguntaIncorrectas = p.iIncorrectaList.ToArray(), CategoriaId = categoriaId, DificultadId = dificultadId });
                    ContextoDB.Instancia.ServicioBD.SaveChanges();
                }                       
            };

            return Task.CompletedTask;
        }

        /// <summary>
        /// Obtiene las categorias
        /// </summary>
        /// <returns></returns>
        public List<CategoriaDTO> GetCategorias()
        {
            var categoriasContext = ContextoDB.Instancia.ServicioBD.Categorias.ToList();
            var categoriasDTO = new List<CategoriaDTO>();

            foreach (var item in categoriasContext)
            {
                categoriasDTO.Add(new CategoriaDTO(item.CategoriaId, item.CategoriaNombre));
            }

            return categoriasDTO;
        }

        /// <summary>
        /// Obtiene las dificultades
        /// </summary>
        /// <returns></returns>
        public List<DificultadDTO> GetDificultades()
        {
            var dificultadesContext = ContextoDB.Instancia.ServicioBD.Dificultades.ToList();
            var dificultadesDTO = new List<DificultadDTO>();

            foreach (var item in dificultadesContext)
            {
                dificultadesDTO.Add(new DificultadDTO(item.DificultadId, item.DificultadNombre));
            }

            return dificultadesDTO;
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

    }

    /// <summary>
    /// Representa el filtro que se va a utilizar para filtrar las preguntas de una sesion de juego por comenzar
    /// </summary>
    internal class PreguntaFiltro
    {
        // Atributos
        public string iDificultad;
        public string iCategoria;
        public int iCantidad;

        public PreguntaFiltro(string pDificultad, string pCategoria, int pCantidad)
        {
            iDificultad = pDificultad;
            iCategoria = pCategoria;
            iCantidad = pCantidad;
        }
    }

}
