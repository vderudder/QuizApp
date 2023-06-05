using QuizApp.DB;
using QuizApp.Facade;
using QuizApp.Storage.DBStorage;
using Quizzify.Storage;
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
        public static QuizContext iServicioBD;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.


        public static void Iniciar(PreguntaFacade pPreguntaFacade, UsuarioFacade pUsuarioFacade, SesionFacade pSesionFacade, AdminFacade pAdminFacade, IPreguntaStorage pPreguntaStorage, IUsuarioStorage pUsuarioStorage, ISesionStorage pSesionStorage, IAdminStorage pAdminStorage)
        {
            iInstancia = new Contexto(pPreguntaFacade, pUsuarioFacade, pSesionFacade, pAdminFacade, pPreguntaStorage, pUsuarioStorage, pSesionStorage, pAdminStorage);

            iServicioBD = new QuizContext();
        }

        public PreguntaFacade iPreguntaFacade;
        public UsuarioFacade iUsuarioFacade;
        public SesionFacade iSesionFacade;
        public AdminFacade iAdminFacade;
        public IPreguntaStorage iPreguntaStorage;
        public IUsuarioStorage iUsuarioStorage;
        public ISesionStorage iSesionStorage;
        public IAdminStorage iAdminStorage;

        private Contexto(PreguntaFacade pPreguntaFacade, UsuarioFacade pUsuarioFacade, SesionFacade pSesionFacade, AdminFacade pAdminFacade, IPreguntaStorage pPreguntaStorage, IUsuarioStorage pUsuarioStorage, ISesionStorage pSesionStorage, IAdminStorage pAdminStorage)
        {
            iPreguntaFacade = pPreguntaFacade;
            iUsuarioFacade = pUsuarioFacade;
            iSesionFacade = pSesionFacade;
            iAdminFacade = pAdminFacade;
            iPreguntaStorage = pPreguntaStorage;
            iUsuarioStorage = pUsuarioStorage;
            iSesionStorage = pSesionStorage;
            iAdminStorage = pAdminStorage;
        }
    }
}
