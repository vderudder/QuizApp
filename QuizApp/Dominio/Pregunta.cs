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
        private string iCorrecta;
        private IList<string> iIncorrecta;

        //Propiedades
        public string Nombre => iNombre;
        public Categoria Categoria => iCategoria;
        public Dificultad Dificultad => iDificultad;
        public TipoPregunta Tipo => iTipo;
        public string Correcta => iCorrecta;
        public IList<string> Incorrecta => iIncorrecta;

        // Constructor
        public Pregunta(string pNombre, Categoria pCategoria, Dificultad pDificultad, TipoPregunta pTipoPregunta, string pCorrecta, List<string> pIncorrecta)
        {
            iNombre = pNombre;
            iCategoria = pCategoria;
            iDificultad = pDificultad;
            iTipo = pTipoPregunta;
            iCorrecta = pCorrecta;
            iIncorrecta = pIncorrecta;
        }

        // Metodos

        public bool EsRespuestaCorrecta(string pRespuesta)
        {
            return iCorrecta == pRespuesta;
        }
    }
}
