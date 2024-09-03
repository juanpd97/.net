using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_GPT.Models
{
    public class Usuario
    {
        public int id { get; set; }
        public int edad { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public Usuario() { }

    }
}
