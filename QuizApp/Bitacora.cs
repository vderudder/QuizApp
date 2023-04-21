using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    public static class Bitacora
    {
        public static void Log(string message)
        {
            string logPath = ConfigurationManager.AppSettings["logPath"];

            using(StreamWriter sw = new StreamWriter(logPath, true))
            {
                sw.WriteLine($"{DateTime.Now} : {message}");
            }
        }
    }
}
