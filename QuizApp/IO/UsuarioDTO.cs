using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzify.IO
{
    internal class UsuarioDTO
    {
        public string iId;
        public string iNombre;

        public UsuarioDTO(string pId, string pNombre)
        {
            this.iId = pId;
            this.iNombre = pNombre;
        }
    }
}
