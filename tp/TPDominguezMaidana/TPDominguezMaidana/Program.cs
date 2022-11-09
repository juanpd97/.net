using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPDominguezMaidana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool menu = true;
            int opcion;

            //creo arraylist para almacenar los nuevos objetos que voy creando de las diferentes clases
            //uso arraylist porque no se cuantos objetos voy a crear
            ArrayList listaProvedores = new ArrayList();
            ArrayList listaMarcas = new ArrayList();
            ArrayList listaProductos = new ArrayList();

            while (menu)
            {
                menu1();
                Console.Write("ingresar opcion: ");
                opcion = NumeroEntero();

                switch (opcion)//cada opcion me lleva al submenu de la clase
                {
                    case 1://Marca
                        menuMarca(listaMarcas);
                        break;

                    case 2://Proveedor
                        break;

                    case 3://Producto
                        break;

                    case 4://salgo del programa
                        menu = false;
                        break;

                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }


            }
        }
        public static void menu2()//funcion que imprime las opciones de la funcion secundaria
        {
            Console.WriteLine("  1-Listar");
            Console.WriteLine("  2-Alta");
            Console.WriteLine("  3-Modificacion");
            Console.WriteLine("  4-Eliminar");
            Console.WriteLine("  5-Salir");

        }
        public static void menu1()//funcion que imprime el menu principal
        {
            Console.WriteLine("----- menu principal -----");
            Console.WriteLine("  1-Marca");
            Console.WriteLine("  2-Proveedor");
            Console.WriteLine("  3-Producto");
            Console.WriteLine("  4-Salir");
        }

        static int NumeroEntero()//funcion para que solamente se puedan ingresar numeros enteros
        {
            int numero;
            while (!Int32.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write("El valor ingresado no es un número.\nIngrese un Número: ");
            }
            return numero;
        }

        public static void menuMarca(ArrayList listaMarcas)
        {
            

            bool menu = true;
            int opcion;

            while (menu)
            {
                Console.WriteLine();
                Console.WriteLine("----- Marca -----");
                menu2();
                Console.Write("ingresar opcion: ");
                opcion = NumeroEntero();

                switch (opcion)
                {
                    case 1://muestro todas las marcas que tengo almacenadas
                        mostrarMarcas(listaMarcas);
                        break;

                    case 2://doy de alta una nueva marca
                        altaMarca(listaMarcas);
                        break;

                    case 3://modifico una marca
                        modificarMarca(listaMarcas);
                        break;

                    case 4://elimino una marca
                        
                        break;

                    case 5://vuelvo al menu principal
                        menu = false;
                        break;

                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }

            }

        }

        public static void altaMarca(ArrayList listaMarcas)
        {
            Marca nuevaMarca;

            int codigo;
            string nombre;
            string descripcion;

            Console.Write("-Nombre de la nueva marca: ");
            nombre = Console.ReadLine();
            Console.Write("-Codigo: ");
            codigo = NumeroEntero();
            Console.Write("-Descripcion: ");
            descripcion = Console.ReadLine();

            nuevaMarca = new Marca(codigo, nombre, descripcion);
            listaMarcas.Add(nuevaMarca);
        }

        public static void mostrarMarcas(ArrayList listaMarcas)
        {
            if (listaMarcas.Count > 0)
            {
                Console.WriteLine("----- Marcas -----");

                for (int i = 0; i < listaMarcas.Count; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("  ---Marca " + (i + 1) + " ---");
                    Console.WriteLine(listaMarcas[i].ToString());
                }
            } else
            {
                Console.WriteLine();
                Console.WriteLine("no hay marcas registradas");
            }
        }

        public static void modificarMarca(ArrayList listaMarcas)
        {
            int opcion;
            Console.WriteLine("------ Modificar Marca -----");

            if (listaMarcas.Count == 0)
            {
                mostrarMarcas(listaMarcas);
            }
            else
            {
                mostrarMarcas(listaMarcas);
                Console.Write("ingrese la marca que desea modificar: ");
                opcion = NumeroEntero();
                if ((opcion > 0) && (opcion <= listaMarcas.Count))
                {
                    //crear una funcion y pasarle la opcion para ver que atributo le quiero modificar
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
        }








    }
}
