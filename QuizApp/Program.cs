using Quizzify.Storage.DBStorage;
using QuizApp.UI;
using Quizzify.DB;
using Mapster;
using System.Reflection;
using Quizzify.IO;

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
            // Inicializar configuraciones de mapper
            var typeAdapterConfig = TypeAdapterConfig.GlobalSettings;
            Assembly applicationAssembly = typeof(BaseDTO<,>).Assembly;
            typeAdapterConfig.Scan(applicationAssembly);

            // Se inicializa las fachadas y storages
            var contexto = new Contexto { PreguntaFacade = new(), UsuarioFacade = new(), SesionFacade = new(), AdminFacade = new(), PreguntaStorage = new PreguntaDBStorage(), UsuarioStorage = new UsuarioDBStorage(), SesionStorage = new SesionDBStorage() }; 
            Contexto.Instancia = contexto;

            // Se inicializa el servicio de BD
            var contextoBD = new ContextoDB { ServicioBD = new QuizContext() };
            ContextoDB.Instancia = contextoBD;

            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Inicio());
        }
    }
}