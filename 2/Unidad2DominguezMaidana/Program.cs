using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Unidad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nro = 0, numero50 = -1;
            string cadena = "";

            Console.WriteLine("........... Punto 2 ...........\n");
            Console.WriteLine("Ingrese un número entero y positivo:");
            nro = NumeroEntero();

            Console.WriteLine("........... Punto 3 ...........\n");
            Console.WriteLine("Ingrese una cadena para pasar por parámetro");
            cadena = Console.ReadLine();
            MostrarCadena(cadena);
            Console.WriteLine("........... Punto 4 ...........");
            Console.WriteLine("Ingrese un número entero mayor o igual a 50:");
            numero50 = NumeroEntero();
            //numero50 = Convert.ToInt32(Console.ReadLine());
            ComprobarNumero50(numero50);
            //Console.WriteLine("\nIngrese un nro para ver si es divisible por 4");
            Console.WriteLine("........... Punto 5 ...........");
            //nro = Convert.ToInt32(Console.ReadLine());
            Multiplo4(ref nro);
            Console.WriteLine("Presione cualquier tecla para finalizar");
            Console.ReadKey();
        }
        //Función para determinar si un número es entero y positivo
        static int NumeroEntero()
        {
            int numero;
            while (!Int32.TryParse(Console.ReadLine(), out numero) || (numero < 0))
            {
                Console.Write("El valor ingresado, no es lo que se solicita.\nIngrese un Número: ");
            }
            return numero;
        }
        //Función para mostrar cadena enviada
        static void MostrarCadena(string cadena)
        {
            Console.WriteLine($"{cadena}\n");
            //Console.ReadKey();
        }
        //Función para determinar si un número es mayor o igual a 50
        static int ComprobarNumero50(int numero50)
        {
            if (numero50 < 50)
                MostrarCadena("El número ingresado es MENOR a 50");
            else
                MostrarCadena("El número ingresado es MAYOR a 50");
            return numero50;
        }
        static int Multiplo4(ref int nro)
        {
            if ((nro % 4) == 0)
            {
                MostrarCadena($"el numero {nro} es divisible por 4");
            }
            else
            {
                MostrarCadena($"el numero {nro} NO es divisible por 4");
            }
            return nro;
        }

    }
}
