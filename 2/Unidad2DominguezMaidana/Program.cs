using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unidad_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------- 2 --------------------\n");
            //2Hacer un programa que le pida al usuario que ingrese un número y le responda si es divisible por 3.

            //declaro las variables que voy a necesitar
            int numero, mes;

            Console.Write("ingrese un numero para ver si es divisible por 3: ");
            //pido el ingreso de las variables y realizo su conversion a entero
            numero = NumeroEntero();

            //utilizo un condicional if para verificar si el numero ingresado es divisible por 3
            if ((numero % 3) == 0)
            {
                Console.WriteLine($"el numero {numero} es divisible por 3");
            }
            else
            {
                Console.WriteLine($"el numero {numero} NO es divisible por 3");
            }

            Console.WriteLine("\n----------------------- 3 --------------------\n");
            //3 Hacer un programa que le pida al usuario un número del 1 al 12 y
            //escriba el nombre del mes que corresponda a ese número. Usar Switch

            //Compruebo que el mes que se ingrese esté entre 1 y 12 y sea un número
            mes = RangoMes();
            switch (mes)
            {
                case 1:
                    Console.WriteLine("enero");
                    break;
                case 2:
                    Console.WriteLine("febrero");
                    break;
                case 3:
                    Console.WriteLine("marzo");
                    break;
                case 4:
                    Console.WriteLine("abril");
                    break;
                case 5:
                    Console.WriteLine("mayo");
                    break;
                case 6:
                    Console.WriteLine("junio");
                    break;
                case 7:
                    Console.WriteLine("julio");
                    break;
                case 8:
                    Console.WriteLine("agosto");
                    break;
                case 9:
                    Console.WriteLine("septiembre");
                    break;
                case 10:
                    Console.WriteLine("octubre");
                    break;
                case 11:
                    Console.WriteLine("noviembre");
                    break;
                case 12:
                    Console.WriteLine("diciembre");
                    break;
                default:
                    Console.WriteLine("mes ingresado no válido");
                    break;
            }
            Console.WriteLine("\n----------------------- 4 --------------------\n");
            //4 Hacer un programa que muestre la tabla de multiplicar del 1 al 10 de cualquier número. Usar For
            Console.Write("ingrese un numero para multiplicar del 1 al 10: ");
            numero = NumeroEntero();
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($" - {numero} * {i} = {i * numero}");
            }
            Console.WriteLine("Presione cualquier tecla para finalizar");
            Console.ReadKey();
            //5En los puntos 2,3 y 4 verificar que se haya ingresado un número y
            //sino se muestre un mensaje de error y vuelva a solicitar el ingreso
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
        //Compruebo que el nro de mes ingresado esté entre 1 y 12 y sea un número
        static int RangoMes()
        {
            int nro_mes = 0;
            while ((nro_mes > 12) || (nro_mes < 1))
            {
                Console.Write("ingrese un numero de mes entre 1 y 12: ");
                nro_mes = NumeroEntero();
            }
            return nro_mes;
        }
    }
}