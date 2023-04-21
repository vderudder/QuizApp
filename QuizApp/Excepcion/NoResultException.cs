using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Excepcion
{
    internal class NoResultException : Exception
    {
        public override string Message
        {
            get
            {
                return "There are no questions for this query";
            }
        }
    }
}
