using Quizzify.DB;
using Quizzify.Facade;
using Quizzify.Storage;

namespace QuizApp.UI
{
    internal class Contexto
    {
        // Desactivado Warning de que puede ser null, porque lo vamos a inicializar cuando se inicie el Program
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public static Contexto iInstancia;
        public static QuizContext iServicioBD;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.


        public static void Iniciar(PreguntaFacade pPreguntaFacade, UsuarioFacade pUsuarioFacade, SesionFacade pSesionFacade, AdminFacade pAdminFacade, IPreguntaStorage pPreguntaStorage, IUsuarioStorage pUsuarioStorage, ISesionStorage pSesionStorage, IPreguntaStorageExterno pPreguntaStorageExterno)
        {
            iInstancia = new Contexto(pPreguntaFacade, pUsuarioFacade, pSesionFacade, pAdminFacade, pPreguntaStorage, pUsuarioStorage, pSesionStorage, pPreguntaStorageExterno);

            iServicioBD = new QuizContext();
        }

        public PreguntaFacade iPreguntaFacade;
        public UsuarioFacade iUsuarioFacade;
        public SesionFacade iSesionFacade;
        public AdminFacade iAdminFacade;
        public IPreguntaStorage iPreguntaStorage;
        public IUsuarioStorage iUsuarioStorage;
        public ISesionStorage iSesionStorage;
        public IPreguntaStorageExterno iPreguntaStorageExterno;

        private Contexto(PreguntaFacade pPreguntaFacade, UsuarioFacade pUsuarioFacade, SesionFacade pSesionFacade, AdminFacade pAdminFacade, IPreguntaStorage pPreguntaStorage, IUsuarioStorage pUsuarioStorage, ISesionStorage pSesionStorage, IPreguntaStorageExterno pPreguntaStorageExterno)
        {
            iPreguntaFacade = pPreguntaFacade;
            iUsuarioFacade = pUsuarioFacade;
            iSesionFacade = pSesionFacade;
            iAdminFacade = pAdminFacade;
            iPreguntaStorage = pPreguntaStorage;
            iUsuarioStorage = pUsuarioStorage;
            iSesionStorage = pSesionStorage;
            iPreguntaStorageExterno = pPreguntaStorageExterno;
        }
    }
}
