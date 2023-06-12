using Quizzify.DB;
using Quizzify.Externo;
using Quizzify.Facade;
using Quizzify.Storage;

namespace QuizApp.UI
{
    internal class Contexto
    {
        
        private static Contexto iInstancia;

        private PreguntaFacade iPreguntaFacade;
        private UsuarioFacade iUsuarioFacade;
        private SesionFacade iSesionFacade;
        private AdminFacade iAdminFacade;
        private IPreguntaStorage iPreguntaStorage;
        private IUsuarioStorage iUsuarioStorage;
        private ISesionStorage iSesionStorage;
        private IPreguntaStorageExterno iPreguntaStorageExterno;
        private ILogicaExterna iLogicaExterna;

        public static Contexto Instancia
        {
            get { return iInstancia; }
            set { iInstancia = value; }
        }

        public PreguntaFacade PreguntaFacade
        {
            get { return iPreguntaFacade; }
            set { iPreguntaFacade = value; }
        }

        public UsuarioFacade UsuarioFacade
        {
            get { return iUsuarioFacade; }
            set { iUsuarioFacade = value; }
        }

        public SesionFacade SesionFacade
        {
            get { return iSesionFacade; }
            set { iSesionFacade = value;}
        }

        public AdminFacade AdminFacade
        {
            get { return iAdminFacade; }
            set { iAdminFacade = value; }
        }
        public IPreguntaStorage PreguntaStorage
        {
            get { return iPreguntaStorage; }
            set { iPreguntaStorage = value; }
        }

        public IUsuarioStorage UsuarioStorage
        {
            get { return iUsuarioStorage; }
            set { iUsuarioStorage = value; }
        }

        public ISesionStorage SesionStorage
        {
            get { return iSesionStorage; }
            set { iSesionStorage = value; }
        }
        
        public IPreguntaStorageExterno PreguntaStorageExterno
        {
            get { return iPreguntaStorageExterno; }
            set { iPreguntaStorageExterno = value; }
        }

        public ILogicaExterna LogicaExterna
        {
            get { return iLogicaExterna; }
            set { iLogicaExterna = value; }
        }
    }
}
