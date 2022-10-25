using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Unidad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear una función que pida la edad de 3 personas guardando en un arreglo los valores,
            //luego sumar 5 a cada uno y mostrar el resultado.
            Console.WriteLine("...... Punto 2 ...... \n");
            Console.WriteLine("Le vamos a solicitar que ingrese 3 edades\n");
            FuncionPunto2();
            //Hacer una función que ingresen los sueldos de una empresa y los guarde en un ArrayList.
            //Luego calcular y mostrar el promedio, sueldo máximo y mínimo.
            Console.WriteLine("...... Punto 3 ...... \n");
            Console.WriteLine("Le vamos a solicitar que ingrese unos sueldos");
            FuncionSueldos();
            //Hacer una función que actúe como un diccionario, con palabra y definición, 
            //usando la colección Hashtable(inicializar con al menos 3 palabras).
            Console.WriteLine("...... Punto 4 ...... \n");
            FuncionPunto4();
            //Hacer un función que le solicite al usuario 5 números y luego las muestre en orden descendente.
            Console.WriteLine("...... Punto 5 ...... \n");
            //Hacer un función que le solicite al usuario 5 números y luego las muestre
            //en orden descendente.
            FuncionPunto5();
        }
        //Función para cargar el arreglo y sumar 5 a cada elemento del ARREGLO
        static void FuncionPunto2()
        {
            int[] ArregloEdades = { 0, 0, 0 }; ;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese la edad para el elemento " + (i + 1));
                ArregloEdades[i] = EsNumero();
                ArregloEdades[i] = ArregloEdades[i] + 5;
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("La edad en la posición: " + i + " - Valor: " + ArregloEdades[i]);
            }
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }
        //Función para carga de sueldos
        static void FuncionSueldos()
        {
            decimal promedio, acumulador, maximo, minimo;
            int cantidad;
            Console.WriteLine("Ingrese la cantidad de sueldos:");
            cantidad = EsNumero();
            ArrayList sueldos = new ArrayList(cantidad);
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingrese el sueldo número " + (i + 1));
                sueldos.Add(Convert.ToInt32(Console.ReadLine()));
            }
            acumulador = 0;
            maximo = 0;
            promedio = 0;
            minimo = 999999999;
            foreach (var x in sueldos)
            {
                Console.WriteLine("Sueldo " + x);
                acumulador += Convert.ToInt32(x);
                if (Convert.ToInt32(x) > maximo)
                {
                    maximo = Convert.ToInt32(x);
                }
                if (Convert.ToInt32(x) < minimo)
                {
                    minimo = Convert.ToInt32(x);
                }
            }

            promedio = acumulador / cantidad;
            Console.WriteLine("El sueldo máximo es: " + maximo);
            Console.WriteLine("El sueldo mínimo es: " + minimo);
            Console.WriteLine("El promedio de los sueldos es: " + promedio);
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }
        //Función para determinar si un número es entero y positivo
        static int EsNumero()
        {
            int numero;
            while (!Int32.TryParse(Console.ReadLine(), out numero) || (numero < 0))
            {
                Console.Write("El valor ingresado, no es lo que se solicita.\nIngrese un Número: ");
            }
            return numero;
        }
        static void FuncionPunto4()
        {
            Console.WriteLine("Las palabras del diccionario, son: palabra, tiempo, vacaciones\n");
            Hashtable diccionario = new Hashtable();
            diccionario.Add("palabra", "vocablo, voz, término");
            diccionario.Add("tiempo", "período, duración, época, era");
            diccionario.Add("vacaciones", "descanso; holganza; ocio; receso");
            string palabra = "";
            Console.WriteLine("Ingrese palabra a buscar:");
            palabra = Console.ReadLine();
            if (diccionario.ContainsKey(palabra))
            {
                Console.WriteLine("El sinónimo de " + palabra + " es: " + diccionario[palabra]);
            }
            else
            {
                Console.WriteLine("No existe esa palabra en el diccionario");
            }
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }
        static void FuncionPunto5()
        {
            int[] arregloaux = new int[5];
            for (int cont = 0; cont < 5; cont++)
            {
                Console.WriteLine("Ingrese número " + (cont + 1) + " de 5:");
                arregloaux[cont] = EsNumero();
                //arregloaux[cont] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(arregloaux);
            Array.Reverse(arregloaux);
            Console.WriteLine("A continuación se muestran los numeros ordenados en forma ascendente");
            for (int k = 0; k < 5; k++)
            {
                Console.WriteLine("Elemento " + k + ": " + arregloaux[k]);
            }
            Console.WriteLine("Presione cualquier tecla para finalizar el TP - Saludos");
            Console.ReadKey();
        }

    }
}
