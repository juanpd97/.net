using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    internal class Cliente
    {
        public byte edad { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dni;
        public ulong telefono { get; set; }
        public DateTime fechaNacimiento { get; set; }

        public Cliente(){}
    }
}
