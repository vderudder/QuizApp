using Quizzify.Facade;
using Quizzify.Storage.DBStorage;
using QuizApp.UI;
using Quizzify.Storage.ExternalStorage;
using Quizzify.Externo;

[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config")]

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
            Contexto.Iniciar(new PreguntaFacade(), new UsuarioFacade(), new SesionFacade(), new AdminFacade(), new PreguntaDBStorage(), new UsuarioDBStorage(), new SesionDBStorage(), new OpenTDBPreguntaStorage(), new LogicaOTDB());

            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Inicio());
        }
    }
}