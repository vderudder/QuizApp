using QuizApp.Facade;
using QuizApp.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.UI
{
    internal class Contexto
    {
        // Desactivado Warning de que puede ser null, porque lo vamos a inicializar cuando se inicie el Program
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public static Contexto iInstancia;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public static void iniciar(PreguntaFacade pPreguntaFacade, UsuarioFacade pUsuarioFacade, SesionFacade pSesionFacade, PreguntaStorage pPreguntaStorage, UsuarioStorage pUsuarioStorage, SesionStorage pSesionStorage)
        {
            iInstancia = new Contexto(pPreguntaFacade, pUsuarioFacade, pSesionFacade, pPreguntaStorage, pUsuarioStorage, pSesionStorage);
        }

        public PreguntaFacade iPreguntaFacade;
        public UsuarioFacade iUsuarioFacade;
        public SesionFacade iSesionFacade;
        public PreguntaStorage iPreguntaStorage;
        public UsuarioStorage iUsuarioStorage;
        public SesionStorage iSesionStorage;

        private Contexto(PreguntaFacade pPreguntaFacade, UsuarioFacade pUsuarioFacade, SesionFacade pSesionFacade, PreguntaStorage pPreguntaStorage, UsuarioStorage pUsuarioStorage, SesionStorage pSesionStorage)
        {
            iPreguntaFacade = pPreguntaFacade;
            iUsuarioFacade = pUsuarioFacade;
            iSesionFacade = pSesionFacade;
            iPreguntaStorage = pPreguntaStorage;
            iUsuarioStorage = pUsuarioStorage;
            iSesionStorage = pSesionStorage;
        }
    }
}
