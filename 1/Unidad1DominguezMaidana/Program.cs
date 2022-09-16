using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad1Maidana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaro las variabales que voy a utilizar
            string apynom = "", direccion = "";
            long telefono = 0;
            //solicito el nombre y apellido y lo cargo a apynom
            Console.WriteLine("Ingrese su Apellido y nombre: ");
            apynom = Console.ReadLine();
            //solicito la direccion y lo cargo a direccion
            Console.WriteLine("Ingrese su dirección: ");
            direccion = Console.ReadLine();
            //solicito el teléfono lo cargo a telefono
            Console.WriteLine("Ingrese su teléfono: ");
            telefono = EsNumero();
            //long.TryParse(Console.ReadLine(), out telefono);
            //mostramos la línea solicitada
            Console.WriteLine($"La persona: {apynom} vive en dirección: {direccion}. Número Telefónico: {telefono}");
            // Con cualquier tecla que se presione, se cierra la venta y sale con error 0
            Console.WriteLine("Fin puntos 1, 2 y 3\nPresione una tecla para continuar\n");
            Console.ReadKey();
            // a partir de acá comienza el punto 4
            Console.WriteLine("Punto 4 - Definir e inicializar una variable de cada tipo (bool, byte, char, decimal, double, float, int, long, short y string) y mostrar por pantalla el contenido de cada uno.\n");
            bool buleano = true;
            byte bait = 255;
            char caracter = 'a';
            decimal deci = 123;
            double doble = -10307;
            float flotante = 345678;
            int entero = 1234567890;
            long largo = 1234567890987654321;
            short corto = 32767;
            string vcadena = "Cadena";
            Console.WriteLine($"Booleano: {buleano}");
            Console.WriteLine($"Byte: {bait}");
            Console.WriteLine($"Char: {caracter}");
            Console.WriteLine($"Decimal: {deci}");
            Console.WriteLine($"Double: {doble}");
            Console.WriteLine($"Flotante: {flotante}");
            Console.WriteLine($"Int: {entero}");
            Console.WriteLine($"Long: {largo}");
            Console.WriteLine($"Short: {corto}");
            Console.WriteLine($"String: {vcadena}");
            Console.WriteLine("Acá termina el punto 4.\nPresione una tecla para continuar\n");
            Console.ReadKey();
            // Acá comienza el punto 5
            Console.WriteLine("Punto 5\n¿Las siguientes variables están bien inicializadas? ¿Cuál es el error de compilación?\n");
            Console.WriteLine("int numero = string");
            Console.WriteLine("Error\tCS0029\tNo se puede convertir implícitamente el tipo 'string' en 'int'");
            Console.WriteLine("string cadena = 1");
            Console.WriteLine("Error\tCS0029\tNo se puede convertir implícitamente el tipo 'int' en 'string'");
            Console.WriteLine("Ambas están mal inicializadas, se inician con un tipo de dato (int y string) y se le asigna otro tipo de datos, por este motivo dan error de compilación.\nPresione una tecla para finalizar");
            Console.ReadKey();
        }
        //Con esta función corroboramos que se ingrese un número >
        static long EsNumero()
        {
            long aux_telefono;
            while (!long.TryParse(Console.ReadLine(), out aux_telefono))
            {
                Console.Write("El valor ingresado no es un número.\nIngrese un Número por favor: ");
            }
            return aux_telefono;
        }
    }
}
