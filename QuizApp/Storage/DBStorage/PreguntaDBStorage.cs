using QuizApp.UI;
using QuizApp.IO;
using Quizzify.Storage;

namespace QuizApp.Storage.DBStorage
{
    internal class PreguntaDBStorage : IPreguntaStorage
    {
        /// <summary>
        /// Obtiene los DTO de las preguntas con el filtro correspondiente
        /// </summary>
        /// <param name="pFiltro"></param>
        /// <returns></returns>
        public List<PreguntaDTO> GetPreguntasByFiltro(PreguntaFiltro pFiltro)
        {
            // Filtrar por categoria y dificultad
            var preguntasByCategoriaDificultad = Contexto.iServicioBD.Preguntas.Where(p => p.Dificultad.DificultadNombre == pFiltro.iDificultad && p.Categoria.CategoriaNombre == pFiltro.iCategoria).ToList();

            // Desordenar y tomar la cantidad del filtro
            var preguntasFiltradasContext = preguntasByCategoriaDificultad.OrderBy(elem => Guid.NewGuid()).ToList().Take(pFiltro.iCantidad).ToList();

            var preguntasFiltradas = new List<PreguntaDTO>();
            foreach (var preg in preguntasFiltradasContext)
            {
                preguntasFiltradas.Add(new PreguntaDTO(preg.PreguntaNombre, preg.Dificultad.DificultadNombre, preg.Categoria.CategoriaNombre, preg.PreguntaCorrecta, preg.PreguntaIncorrectas.ToList()));
            }

            return preguntasFiltradas;

        }

        public Task GuardarPreguntas(List<PreguntaDTO> pPreguntas)
        {
            foreach (var p in pPreguntas)
            {
                var categoriaId = GetCategoriaIdByNombre(p.iCategoriaNombre);
                if (categoriaId == null)
                {
                    var categoriaContext = Contexto.iServicioBD.Categorias.Add(new DB.QuizContext.Categoria() { CategoriaId = Guid.NewGuid().ToString(), CategoriaNombre = p.iCategoriaNombre });
                    Contexto.iServicioBD.SaveChanges();

                    categoriaId = categoriaContext.Entity.CategoriaId;
                }

                var dificultadId = GetDificultadIdByNombre(p.iDificultadNombre);
                if (dificultadId == null)
                {
                    var dificultadContext = Contexto.iServicioBD.Dificultades.Add(new DB.QuizContext.Dificultad() { DificultadId = Guid.NewGuid().ToString(), DificultadNombre = p.iDificultadNombre });
                    Contexto.iServicioBD.SaveChanges();

                    dificultadId = dificultadContext.Entity.DificultadId;
                }

                if (!ExistePregunta(p.iPregunta))
                {
                    Contexto.iServicioBD.Preguntas.Add(new DB.QuizContext.Pregunta() { PreguntaId = Guid.NewGuid().ToString(), PreguntaNombre = p.iPregunta, PreguntaCorrecta = p.iCorrecta, PreguntaIncorrectas = p.iIncorrectaList.ToArray(), CategoriaId = categoriaId, DificultadId = dificultadId });
                    Contexto.iServicioBD.SaveChanges();
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
            var categoriasContext = Contexto.iServicioBD.Categorias.ToList();
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
            var dificultadesContext = Contexto.iServicioBD.Dificultades.ToList();
            var dificultadesDTO = new List<DificultadDTO>();

            foreach (var item in dificultadesContext)
            {
                dificultadesDTO.Add(new DificultadDTO(item.DificultadId, item.DificultadNombre));
            }

            return dificultadesDTO;
        }

        public string? GetCategoriaIdByNombre(string pNombre)
        {
            var cat = Contexto.iServicioBD.Categorias.Where(c => c.CategoriaNombre == pNombre).SingleOrDefault();

            if (cat == null)
            {
                return null;
            }
            else
            {
                return cat.CategoriaId;
            }
                
        }
        public string? GetDificultadIdByNombre(string pNombre)
        {
            var dif = Contexto.iServicioBD.Dificultades.Where(d => d.DificultadNombre == pNombre).SingleOrDefault();

            if (dif == null)
            {
                return null;
            }
            else
            {
                return dif.DificultadId;
            }
            
        }

        public bool ExistePregunta(string pPregunta)
        {
            return Contexto.iServicioBD.Preguntas.Any(p => p.PreguntaNombre == pPregunta);
        }

    }

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
