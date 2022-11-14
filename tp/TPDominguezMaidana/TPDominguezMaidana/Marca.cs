using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPDominguezMaidana
{
    internal class Marca
    {
        private int codigo { get; set; }
        private string nombre { get; set; }
        private string descripcion { get; set; }


        //constructor
        public Marca() { }

        public Marca(int codigo, string nombre, string descripcion)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }


        //Sobrescribir el método ToString de las Clases para mostrar todos los atributos.+
        public override String ToString()
        {
            string x = "Codigo:" + codigo.ToString() +
                       " nombre:" + nombre.ToString() +
                       " descripcion:" + descripcion.ToString();
            return x;
        }

        // metodos
        public void setCodigo(int cod)
        {
            this.codigo = cod;
        }
        public void setNombre(string nom)
        {
            this.nombre = nom;
        }

        public void setDescripcion(string desc)
        {
            this.descripcion= desc;
        }



    }
}
