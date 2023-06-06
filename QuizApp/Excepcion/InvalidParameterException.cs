using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzify.Excepcion
{
    internal class InvalidParameterException : Exception
    {
        public override string Message
        {
            get
            {
                return "There is an invalid parameter in this query";
            }
        }
    }
}
