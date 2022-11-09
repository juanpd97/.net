using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TPDominguezMaidana
{
    internal class Provedor
    {
        private int codigo { get; set; }
        private string nombre { get; set; }
        private string apellido { get; set; }
        private string direccion { get; set; }
        private string ciudad { get; set; }
       
        private ArrayList listaTelefonos = new ArrayList(); //crear metodos get y set para poder modificar 
                                                            //la lista de telefonos


        //constructor
        public Provedor() { }

        public Provedor(int cod,string nom,string apell, string dir,string ciud,ArrayList tel)
        {
            this.codigo = cod;
            this.nombre = nom;
            this.apellido = apell;
            this.direccion = dir;
            this.ciudad = ciud;

            foreach (int i in tel)
            {
                this.listaTelefonos.Add(tel[i]);
            }

        }


        //Sobrescribir el método ToString de las Clases para mostrar todos los atributos
        public override String ToString()
        {
            string x = "Codigo:" + codigo.ToString() +
                       " nombre:" + nombre.ToString() +
                       " apellido:" + apellido.ToString()+
                       " direccion:" + direccion.ToString() +
                       " ciudad:" + ciudad.ToString();

            string s;
            for (int i=0 ; i<listaTelefonos.Count; i++)
            {
                s = " telefono " + (i + 1) + ":" + listaTelefonos[i].ToString();
                x += s;
            }

            return x;
        }
    }
}
