using Quizzify.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzify.Storage.DBStorage
{
    internal class ContextoDB
    {
        private static ContextoDB iInstancia;

        private QuizContext iServicioBD;

        public static ContextoDB Instancia
        {
            get { return iInstancia; }
            set { iInstancia = value; }
        }

        public QuizContext ServicioBD
        {
            get { return iServicioBD; }
            set { iServicioBD = value; }
        }
    }
}
