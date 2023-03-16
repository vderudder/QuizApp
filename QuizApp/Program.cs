using QuizApp.Facade;
using QuizApp.Storage;
using QuizApp.UI;

namespace QuizApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Se inicializa las fachadas y storages
            Contexto.iniciar(new PreguntaFacade(), new UsuarioFacade(), new SesionFacade(), new PreguntaStorage(), new UsuarioStorage(), new SesionStorage());

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Inicio());
        }
    }
}