using Quizzify.Facade;
using Quizzify.Storage.DBStorage;
using QuizApp.UI;
using Quizzify.Storage.ExternalStorage;

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
            if (!Directory.Exists(@"C:\Quizzify\Temp"))
            {
                Directory.CreateDirectory(@"C:\Quizzify\Temp");
            }

            // Se inicializa las fachadas y storages
            Contexto.Iniciar(new PreguntaFacade(), new UsuarioFacade(), new SesionFacade(), new AdminFacade(), new PreguntaDBStorage(), new UsuarioDBStorage(), new SesionDBStorage(), new OpenTDBPreguntaStorage());

            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Inicio());
        }
    }
}