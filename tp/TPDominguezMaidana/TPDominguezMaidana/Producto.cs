using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPDominguezMaidana
{
    internal class Producto
    {
        private int codigo { get; set; }
        private string nombre{ get; set; }
        private string  caracteristicas { get; set; }
        private Marca marca { get; set; }

        private ArrayList listaProveedores = new ArrayList();

        //constructor
        public Producto() { }

        public Producto(int cod,string nomb,string carct,Marca marc,ArrayList prov)
        {
            this.codigo = cod;
            this.nombre = nomb;
            this.caracteristicas = carct;
            this.marca = marc;


            for (int i=0; i<prov.Count ; i++)
            {
                this.listaProveedores.Add(prov[i]);
            }
        }

        //Sobrescribir el método ToString de las Clases para mostrar todos los atributos.+
        public override String ToString()
        {
            string x = "Codigo:" + codigo.ToString() +
                       " nombre:" + nombre.ToString() +
                       " caracteristicas:" + caracteristicas.ToString() +
                       " marca:" + marca.ToString();

            string s;
            for (int i = 0; i < listaProveedores.Count; i++)
            {
                s = " provedor " + (i + 1) + ": " + listaProveedores[i].ToString();
                x += s;
            }

            return x;
        }

    }
}
