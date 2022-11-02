using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Unidad5DominguezMaidana
{
    internal class empleado // --------- ejercicio 2 ----------
    {
        //atributos de la clase
        public string identificador { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public string puesto {get; set; }

        public double sueldo { get; set; }

        //constructor --------- ejercicio 3 ----------
        public empleado() { }

        public empleado(string identificador, string nombre, string apellido, int edad, string puesto, double sueldo)
        {
            this.identificador = identificador;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.puesto = puesto;
            this.sueldo = sueldo;
        }

        //metodos

        //---------- metodo ejercicio 4 ----------
        public void nombreYapellido()
        {
            Console.WriteLine("el nombre del empleado es: " + this.nombre + this.apellido);
        }

        //---------- metodo ejercicio 5 -----------
        public void setEdadP(int edad)
        {
            int x;

            if (edad < 0)
            {
                Console.WriteLine("error, ingrese una edad valida:");
                x = Convert.ToInt32(Console.ReadLine());
                setEdadP(x);
            }
            else
                this.edad = edad;
        }

        //---------- metodo ejercicio 6 -----------
        //Crear un método para validar que el sueldo sea mayor a cero.
        public void setSueldoM0(double sueldo)
        {
            double x;

            if (sueldo < 0)
            {
                Console.WriteLine("error, ingrese un sueldo valido:");
                x = Convert.ToDouble(Console.ReadLine());
                setSueldoM0(x);
            }
            else
                this.sueldo = sueldo;
        }

        //----------- metodo ejercicio 7 -----------
        //Programar el método ToString() con todos los elementos de la clase
        public override String ToString()
        {
            string x = "identificador:" + identificador.ToString() +
                       " nombre:" + nombre.ToString() +
                       " apellido:" + apellido.ToString() +
                       " edad:" + edad.ToString() +
                       " puesto:" + puesto.ToString() +
                       " sueldo:" + sueldo.ToString();
            return x;
        }
    }
}
