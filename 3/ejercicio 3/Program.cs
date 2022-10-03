using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nro = 0;
            string mensaje = "";

            Console.WriteLine("\n------------------------------ 2 ------------------------------\n");
            //Crear una función que pida que al usuario ingrese un numero entero positivo.
            //Verificar que se haya ingresado un número y sino se muestre un mensaje de error y
            //vuelva a solicitar el ingreso de un 
            ingresarNumero(ref nro);
            Console.WriteLine("el numero es: " + nro);

            Console.WriteLine("\n------------------------------ 3 ------------------------------\n");
            //Crear una función que muestre un mensaje pasado como parámetro.
            Console.Write("ingrese un mensaje: ");
            mensaje = Console.ReadLine();
            Console.Write("el mensaje enviado es: ");
            MensajePorParametro(mensaje);

            Console.WriteLine("\n------------------------------ 4 ------------------------------\n");
            //Crear una función para validar si un numero es mayor o igual a 50 usando el numero ingresado
            //en el punto 2 y usando la función del punto 3 para mostrar el mensaje.
            ejercicio4(nro,mensaje);

            Console.WriteLine("\n------------------------------ 5 ------------------------------\n");
            //Crear una función para validar si un numero es múltiplo de 4 usando el numero ingresado
            //en el punto 2 y usando la función del punto 3 para mostrar el mensaje.
            ejercicio5(nro, mensaje);
        }
        public static void ingresarNumero(ref int nro)
        {
            do
            {
                Console.WriteLine("ingresar numero entero positivo:");
                nro = NumeroEntero();
            } while (nro < 0);
        }
        static int NumeroEntero()
        {
            int numero;
            while (!Int32.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write("El valor ingresado no es un número.\nIngrese un Número: ");
            }
            return numero;
        }
        static void MensajePorParametro(string x)
        {
            Console.WriteLine(x);
        }
        static bool MayorA50(int nro)
        {
            if(nro >= 50) { return true; 
            } else { return false; }
        }
        static void ejercicio4(int nro,string mensaje)
        {
            if (MayorA50(nro))
            {
                mensaje = ($"el numero {nro} es mayor a 50");
            }
            else
            {
                mensaje = ($"el numero {nro} NO es mayo a 50");
            }
            MensajePorParametro(mensaje);
        }
        static void ejercicio5(int nro, string mensaje)
        {
            if (divX4(nro))
            {
                mensaje = ($"el numero {nro} es divisible por 4");
            }
            else
            {
                mensaje = ($"el numero {nro} NO es divisible por 4");
            }
            MensajePorParametro(mensaje);
        }
        static bool divX4(int x)
        {
            if( (x % 4) == 0) { return true;
            } else { return false; 
                }
        }
    }
}
