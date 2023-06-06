using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzify.Dominio
{
    /// <summary>
    /// Clase para persistir info del usuario
    /// </summary>
    internal class Usuario
    {
        // Atributos
        private string iId;
        private string iNombreUsuario;

        // Propiedades
        public string Id => iId;
        public string NombreUsuario => iNombreUsuario;

        // Constructor
        public Usuario(string pId, string pNombreUsuario)
        {
            iId = pId;
            iNombreUsuario = pNombreUsuario;
        }
    }
}
