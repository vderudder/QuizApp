﻿using QuizApp.Storage.MemoriaStorage;
using QuizApp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Storage.DBStorage
{
    internal class PreguntaDBStorage
    {
        /// <summary>
        /// Obtiene los DTO de las preguntas con el filtro correspondiente
        /// </summary>
        /// <param name="pFiltro"></param>
        /// <returns></returns>
        public List<PreguntaDTO> getPreguntasByFiltro(PreguntaFiltro pFiltro)
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

        public Task guardarPreguntas(List<PreguntaDTO> pPreguntas)
        {
            foreach (var p in pPreguntas)
            {
                var categoriaId = getCategoriaIdByNombre(p.iCategoriaNombre);
                if (categoriaId == null)
                {
                    var categoriaContext = Contexto.iServicioBD.Categorias.Add(new DB.QuizContext.Categoria() { CategoriaId = Guid.NewGuid().ToString(), CategoriaNombre = p.iCategoriaNombre });
                    Contexto.iServicioBD.SaveChanges();

                    categoriaId = categoriaContext.Entity.CategoriaId;
                }

                var dificultadId = getDificultadIdByNombre(p.iDificultadNombre);
                if (dificultadId == null)
                {
                    var dificultadContext = Contexto.iServicioBD.Dificultades.Add(new DB.QuizContext.Dificultad() { DificultadId = Guid.NewGuid().ToString(), DificultadNombre = p.iDificultadNombre });
                    Contexto.iServicioBD.SaveChanges();

                    dificultadId = dificultadContext.Entity.DificultadId;
                }

                if (!existePregunta(p.iPregunta))
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
        public List<CategoriaDTO> getCategorias()
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
        public List<DificultadDTO> getDificultades()
        {
            var dificultadesContext = Contexto.iServicioBD.Dificultades.ToList();
            var dificultadesDTO = new List<DificultadDTO>();

            foreach (var item in dificultadesContext)
            {
                dificultadesDTO.Add(new DificultadDTO(item.DificultadId, item.DificultadNombre));
            }

            return dificultadesDTO;
        }

        public string? getCategoriaIdByNombre(string pNombre)
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
        public string? getDificultadIdByNombre(string pNombre)
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

        public bool existePregunta(string pPregunta)
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

    internal class PreguntaDTO
    {
        // Atributos
        public string iPregunta;
        public string iDificultadNombre;
        public string iCategoriaNombre;
        public string iCorrecta;
        public List<string> iIncorrectaList;

        public PreguntaDTO(string pPregunta, string pDificultadNombre, string pCategoriaNombre, string pCorrecta, List<string> pIncorrectaList)
        {
            iPregunta = pPregunta;
            iDificultadNombre = pDificultadNombre;
            iCategoriaNombre = pCategoriaNombre;
            iCorrecta = pCorrecta;
            iIncorrectaList = pIncorrectaList;
        }
    }

    internal class CategoriaDTO
    {
        // Atributos
        public string iId;
        public string iCategoria;

        public CategoriaDTO(string pId, string pCategoria)
        {
            iId = pId;
            iCategoria = pCategoria;
        }
    }

    internal class DificultadDTO
    {
        // Atributos
        public string iId;
        public string iDificultad;

        public DificultadDTO(string pId, string pDificultad)
        {
            iId = pId;
            iDificultad = pDificultad;
        }
    }
}
