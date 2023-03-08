using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Dominio
{
    /// <summary>
    /// Clase para persistir las preguntas de la trivia
    /// </summary>
    internal class Pregunta
    {
        // Atributos
        private string iNombre;
        private Categoria iCategoria;
        private Dificultad iDificultad;
        private TipoPregunta iTipo;
        private Respuesta iCorrecta;
        private IList<Respuesta> iIncorrecta;

        //Propiedades
        public string Name => iNombre;
        public Categoria Categoria => iCategoria;
        public Dificultad Dificultad => iDificultad;
        public TipoPregunta Tipo => iTipo;
        public Respuesta Correcta => iCorrecta;
        public IList<Respuesta> Incorrecta => iIncorrecta;

        // Constructor
        public Pregunta(string pNombre, Categoria pCategoria, Dificultad pDificultad, TipoPregunta pTipoPregunta, Respuesta pCorrecta, List<Respuesta> pIncorrecta)
        {
            iNombre = pNombre;
            iCategoria = pCategoria;
            iDificultad = pDificultad;
            iTipo = pTipoPregunta;
            iCorrecta = pCorrecta;
            iIncorrecta = pIncorrecta;
        }

        // Metodos

        public bool EsRespuestaCorrecta(Respuesta pRespuesta)
        {
            return iCorrecta == pRespuesta;
        }
    }
}
