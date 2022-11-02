using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad5DominguezMaidana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa en donde el usuario ingrese 3 empleaados validando que la edad
            //y el sueldo no sea negativa y luego muestre todos los datos usando el método ToString().
            
            empleado[] empleados = new empleado[3];
            string iden,nomb,apell,pues;
            int edad;
            double sueld;

            for (int i=0; i<3; i++)
            {
                Console.WriteLine("Datos del empleado: " + (i+1));
                empleados[i] = new empleado();
                Console.Write("Nombre: ");
                nomb = Console.ReadLine();
                empleados[i].nombre = nomb;
                Console.Write("apellido: ");
                apell = Console.ReadLine();
                empleados[i].apellido = apell;
                Console.Write("Puesto: ");
                pues = Console.ReadLine();
                empleados[i].puesto = Console.ReadLine();
                Console.Write("identificador: ");
                iden = Console.ReadLine();
                empleados[i].identificador = iden;
                Console.Write("edad:");
                edad = Convert.ToInt32(Console.ReadLine());
                empleados[i].setEdadP(edad);
                Console.Write("sueldo:");
                sueld = Convert.ToDouble(Console.ReadLine());
                empleados[i].setSueldoM0(sueld);
            }

            for (int i=0; i<3; i++)
            {
                Console.WriteLine("----- empleado " + (i+1) + "-----");
                Console.WriteLine(empleados[i].ToString());
            }
        }

        
    }
    

}
