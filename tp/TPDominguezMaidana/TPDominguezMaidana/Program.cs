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
                        menuMarca(listaMarcas, listaProductos);
                        break;

                    case 2://Proveedor
                        menuProveedor(listaProvedores, listaProductos);
                        break;

                    case 3://Producto
                        menuProductos(listaProductos, listaMarcas, listaProvedores);
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

        public static void menuMarca(ArrayList listaMarcas,ArrayList listaProductos)
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
                        eliminarMarca(listaMarcas, listaProductos);
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

        public static void eliminarMarca(ArrayList listaMarcas,ArrayList listaProductos)
        {
            int opcion;
            Console.WriteLine("Seleccione la marca que desea eliminar");
            mostrarMarcas(listaMarcas);
            opcion = NumeroEntero();
            opcion--;

            Marca unaMarca = (Marca)listaMarcas[opcion];
            bool pertenece;

            pertenece = perteneceMarcaAProducto(unaMarca,listaProductos);
            if (pertenece)
            {
                Console.WriteLine("no es posible eliminar el objeto.");
            } else
            {
                listaMarcas.RemoveAt(opcion);
            }

        }
        public static bool perteneceMarcaAProducto(Marca unaMarca,ArrayList listaProductos)
        {   
            for (int i=0; i<listaProductos.Count; i++)
            {
                if (((Producto)listaProductos[i]).esIgual(unaMarca) )
                {
                    return true;
                }
            }

            return false;
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
                Console.WriteLine("no hay marcas registradas");
            }
            else
            {
                mostrarMarcas(listaMarcas);
                Console.Write("ingrese la marca que desea modificar: ");
                opcion = NumeroEntero();
                if ((opcion > 0) && (opcion <= listaMarcas.Count))
                {
                    modificarAtributoMarca(listaMarcas,opcion);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
        }

        public static void modificarAtributoMarca(ArrayList listaMarcas,int pos)
        {
            Console.WriteLine();
            Console.WriteLine("1- codigo");
            Console.WriteLine("2- nombre");
            Console.WriteLine("3- descripcion");
            Console.Write("atributo que desea modificar:");

            int opcion;
            opcion = NumeroEntero();

            switch (opcion)
            {
                case 1:
                    
                    int nuevoCodigo;
                    Console.Write("ingrese el nuevo codigo: ");
                    nuevoCodigo = NumeroEntero();
                    ((Marca)listaMarcas[pos-1]).setCodigo(nuevoCodigo);

                    break;

                case 2:
                    string nuevoNombre;
                    Console.Write("ingrese el nuevo nombre: ");
                    nuevoNombre = Console.ReadLine();
                    ((Marca)listaMarcas[pos - 1]).setNombre(nuevoNombre);
                    break;

                case 3:
                    string nuevaDescripcion;
                    Console.Write("ingrese la nueva descripcion:");
                    nuevaDescripcion = Console.ReadLine();
                    ((Marca)listaMarcas[pos - 1]).setDescripcion(nuevaDescripcion);
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }

        public static void menuProveedor(ArrayList listaProvedores,ArrayList listaProductos)
        {
            bool menu = true;
            int opcion;

            while (menu)
            {
                Console.WriteLine();
                Console.WriteLine("----- Proveedor -----");
                menu2();
                Console.Write("ingresar opcion: ");
                opcion = NumeroEntero();

                switch (opcion)
                {
                    case 1://muestro todas los proveedores que tengo almacenadas
                        mostrarProveedor(listaProvedores);
                        break;

                    case 2://doy de alta un nuevo proveedor
                        altaProveedor(listaProvedores);
                        break;

                    case 3://modifico un proveedor
                        modificarProveedor(listaProvedores);
                        break;

                    case 4://elimino un proveedor
                        eliminarProveedor(listaProvedores, listaProductos);
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
        public static void eliminarProveedor(ArrayList listaProvedores, ArrayList listaProductos)
        {

            int opcion;
            Console.WriteLine("Seleccione el proveedor que desea eliminar");
            mostrarProveedor(listaProvedores);
            opcion = NumeroEntero();
            opcion--;

            Provedor unProveedor= (Provedor)listaProvedores[opcion];
            bool pertenece;

            pertenece = perteneceProveedorAProducto(unProveedor, listaProductos);
            if (pertenece)
            {
                Console.WriteLine("no es posible eliminar el objeto.");
            }
            else
            {
                listaProvedores.RemoveAt(opcion);
            }
        }
        public static bool perteneceProveedorAProducto(Provedor unProveedor,ArrayList listaProductos)
        {
            for (int i = 0; i < listaProductos.Count; i++)
            {
                if (((Producto)listaProductos[i]).esIgualP(unProveedor))
                {
                    return true;
                }
            }

            return false;
        }
        public static void modificarProveedor(ArrayList listaProvedores)
        {
            int opcion;
            Console.WriteLine("------ Modificar Proveedor -----");

            if (listaProvedores.Count == 0)
            {
                Console.WriteLine("no hay proveedores registrados");
            }
            else
            {
                mostrarProveedor(listaProvedores);
                Console.Write("ingrese el proveedor que desea modificar: ");
                opcion = NumeroEntero();
                if ((opcion > 0) && (opcion <= listaProvedores.Count))
                {
                    modificarAtributoProveedor(listaProvedores, opcion);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
        }
        public static void modificarAtributoProveedor(ArrayList listaProvedores, int pos)
        {

            Console.WriteLine();
            Console.WriteLine("1- codigo");
            Console.WriteLine("2- nombre");
            Console.WriteLine("3- apellido");
            Console.WriteLine("4- direccion");
            Console.WriteLine("5- ciudad");
            Console.WriteLine("6- telefono");
            Console.Write("atributo que desea modificar:");

            int opcion;
            opcion = NumeroEntero();

            switch (opcion)
            {
                case 1:

                    int nuevoCodigo;
                    Console.Write("ingrese el nuevo codigo: ");
                    nuevoCodigo = NumeroEntero();
                    ((Provedor)listaProvedores[pos - 1]).setCodigo(nuevoCodigo);

                    break;

                case 2:
                    string nuevoNombre;
                    Console.Write("ingrese el nuevo nombre: ");
                    nuevoNombre = Console.ReadLine();
                    ((Provedor)listaProvedores[pos - 1]).setNombre(nuevoNombre);
                    break;

                case 3:
                    string nuevoApellido;
                    Console.Write("ingrese el nuevo apellido:");
                    nuevoApellido = Console.ReadLine();
                    ((Provedor)listaProvedores[pos - 1]).setApellido(nuevoApellido);
                    break;
                case 4:
                    string nuevaDireccion;
                    Console.Write("ingrese la nueva direccion:");
                    nuevaDireccion = Console.ReadLine();
                    ((Provedor)listaProvedores[pos - 1]).setDireccion(nuevaDireccion);
                    break;
                case 5:
                    string nuevaCiudad;
                    Console.Write("ingrese la nueva ciudad:");
                    nuevaCiudad = Console.ReadLine();
                    ((Provedor)listaProvedores[pos - 1]).setCiudad(nuevaCiudad);
                    break;
                case 6:
                    int op,nuevoNumero;
                    Console.WriteLine(((Provedor)listaProvedores[pos - 1]).nrosDeTelefono());
                    Console.Write("-que numero desea modificar:");
                    op = NumeroEntero();
                    op -= 1;
                    Console.Write("nuevo numero:");
                    nuevoNumero = NumeroEntero();
                    ((Provedor)listaProvedores[pos - 1]).setNroTelefono(op,nuevoNumero);
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }

        }
        public static void altaProveedor(ArrayList listaProvedores)
        {
            Provedor nuevoProveedor;

            int codigo;
            string nombre;
            string apellido;
            string direccion;
            string ciudad;

            int telefono;
            bool agregarTelefono = true;
            string opcionTelefono;
            bool opcionValida;
            ArrayList listaTelefonos = new ArrayList();

            Console.Write("-Codigo: ");
            codigo = NumeroEntero();
            Console.Write("-Nombre del probveedor: ");
            nombre = Console.ReadLine();
            Console.Write("-Apellido del proveedor:");
            apellido = Console.ReadLine();
            Console.Write("-Direccion: ");
            direccion = Console.ReadLine();
            Console.Write("-Ciudad: ");
            ciudad = Console.ReadLine();

            while (agregarTelefono)
            {
                Console.Write("-Telefono: ");
                telefono = NumeroEntero();
                listaTelefonos.Add(telefono);

                opcionValida = true;
                while (opcionValida) 
                {
                    Console.Write("¿desea agregar otro numero de telefono? (si/no): ");
                    opcionTelefono = Console.ReadLine();
                    if (opcionTelefono == "no")
                    {
                        opcionValida = false;
                        agregarTelefono = false;

                    }
                    else if (opcionTelefono == "si")
                    {
                        opcionValida = false;
                    }
                    else Console.WriteLine("error");
                }
            }

            nuevoProveedor = new Provedor(codigo, nombre, apellido, direccion, ciudad, listaTelefonos);
            listaProvedores.Add(nuevoProveedor);

        }

        public static void mostrarProveedor(ArrayList listaProvedores)
        {
            if (listaProvedores.Count > 0)
            {
                Console.WriteLine("----- Proveedores -----");

                for (int i = 0; i < listaProvedores.Count; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("  ---Proveedor " + (i + 1) + " ---");
                    Console.WriteLine(listaProvedores[i].ToString());
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("no hay proveedores registrados");
            }
        }

        public static void menuProductos(ArrayList listaProductos,ArrayList listaMarcas,ArrayList listaProvedores)
        {
            bool menu = true;
            int opcion;

            while (menu)
            {
                Console.WriteLine();
                Console.WriteLine("----- Producto -----");
                menu2();
                Console.Write("ingresar opcion: ");
                opcion = NumeroEntero();

                switch (opcion)
                {
                    case 1://muestro todos los Productos que tengo almacenados
                        mostrarProducto(listaProductos);
                        break;

                    case 2://doy de alta un nuevo producto
                        altaPoducto(listaProductos, listaMarcas, listaProvedores);
                        break;

                    case 3://modifico un producto
                        modificarProducto(listaProductos, listaMarcas, listaProvedores);
                        break;

                    case 4://elimino un producto
                        eliminarProducto(listaProductos);
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
        public static void eliminarProducto(ArrayList listaProductos)
        {

            int opcion;
            Console.WriteLine("Seleccione el producto que desea eliminar");
            mostrarProducto(listaProductos);
            opcion = NumeroEntero();
            opcion--;

            listaProductos.RemoveAt(opcion);
        }
        public static void modificarProducto(ArrayList listaProductos, ArrayList listaMarcas,ArrayList listaProvedores)
        {
            int opcion;
            Console.WriteLine("------ Modificar Producto -----");

            if (listaProductos.Count == 0)
            {
                Console.WriteLine("no hay productos registrados");
            }
            else
            {
                mostrarProducto(listaProductos);
                Console.Write("ingrese el proveedor que desea modificar: ");
                opcion = NumeroEntero();
                if ((opcion > 0) && (opcion <= listaProductos.Count))
                {
                    modificarAtributoProducto(listaProductos, opcion, listaMarcas, listaProvedores);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
        }

        public static void modificarAtributoProducto(ArrayList listaProductos, int pos,ArrayList listaMarcas,ArrayList listaProvedores)
        {

            Console.WriteLine();
            Console.WriteLine("1- codigo");
            Console.WriteLine("2- nombre");
            Console.WriteLine("3- caracteristicas");
            Console.WriteLine("4- marca");
            Console.WriteLine("5- proveedor");
            Console.Write("atributo que desea modificar:");

            int opcion;
            opcion = NumeroEntero();

            switch (opcion)
            {
                case 1:

                    int nuevoCodigo;
                    Console.Write("ingrese el nuevo codigo: ");
                    nuevoCodigo = NumeroEntero();
                    ((Producto)listaProductos[pos - 1]).setCodigo(nuevoCodigo);

                    break;

                case 2:
                    string nuevoNombre;
                    Console.Write("ingrese el nuevo nombre: ");
                    nuevoNombre = Console.ReadLine();
                    ((Producto)listaProductos[pos - 1]).setNombre(nuevoNombre);
                    break;

                case 3:
                    string nuevaCaracteristica;
                    Console.Write("ingrese la nueva caracteristica:");
                    nuevaCaracteristica = Console.ReadLine();
                    ((Producto)listaProductos[pos - 1]).setCaracteristica(nuevaCaracteristica);
                    break;
                case 4://marca
                    Console.WriteLine("Modificar Marca:");
                    mostrarMarcas(listaMarcas);
                    Console.Write("seleccione una nueva marca: ");
                    int op;
                    op = NumeroEntero();
                    op--;

                    Marca nuevaMarca;
                    nuevaMarca = ((Marca)listaMarcas[op]).getMarca();
                    ((Producto)listaProductos[pos - 1]).setMarca(nuevaMarca);

                    break;
                case 5://proveedor-------------------------
                    Console.WriteLine("Modificar Proveedores");

                    ArrayList nuevosProveedores = new ArrayList();

                    bool agregarProveedor = true;
                    string otroProveedor;
                    while (agregarProveedor)
                    {
                        Console.WriteLine("selecciones un nuevo proveedor");
                        mostrarProveedor(listaProvedores);
                        Console.Write("   -opcion: ");
                        opcion = NumeroEntero();
                        nuevosProveedores.Add(listaProvedores[opcion - 1]);

                        bool bucle = true;
                        while (bucle)
                        {
                            Console.Write("¿desea agregar otro proveedor? (si/no): ");
                            otroProveedor = Console.ReadLine();
                            if (otroProveedor == "no")
                            {
                                agregarProveedor = false;
                                bucle = false;
                            }
                            else if (otroProveedor == "si")
                            {
                                bucle = false;
                            }
                            else if (otroProveedor != "si" && otroProveedor != "no")
                            {
                                Console.WriteLine("error de opcion");
                            }
                        }
                    }

                    ((Producto)listaProductos[pos - 1]).setProvedor(nuevosProveedores);

                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
        public static void altaPoducto(ArrayList listaProductos, ArrayList listaMarcas, ArrayList listaProvedores)
        {
            if ( (listaMarcas.Count>0) && (listaProvedores.Count>0) )
            {
            int codigo;
            string nombre;
            string caracteristicas;
            Marca unaMarca;
            ArrayList proveedores = new ArrayList();

            Console.Write("-Codigo del producto:");
            codigo = NumeroEntero();
            Console.Write("-Nombre del producto:");
            nombre = Console.ReadLine();
            Console.Write("-Caracteristica del producto:");
            caracteristicas = Console.ReadLine();


            int opcion;

            Console.WriteLine("seleccione una marca");
            mostrarMarcas(listaMarcas);
            Console.Write("   -opcion: ");
            opcion= NumeroEntero();
            unaMarca = (Marca)listaMarcas[opcion - 1];

            bool agregarProveedor = true;
            string otroProveedor;
            while (agregarProveedor)
            {
                Console.WriteLine("selecciones un proveedor");
                mostrarProveedor(listaProvedores);
                Console.Write("   -opcion: ");
                opcion = NumeroEntero();
                proveedores.Add(listaProvedores[opcion-1]);

                bool bucle = true;
                while (bucle)
                {
                    Console.Write("¿desea agregar otro proveedor? (si/no): ");
                    otroProveedor = Console.ReadLine();
                    if (otroProveedor == "no")
                    {
                        agregarProveedor = false;
                        bucle = false;
                    }
                    else if(otroProveedor == "si")
                    {
                            bucle = false; 
                    } else if (otroProveedor != "si" && otroProveedor != "no")
                        {
                            Console.WriteLine("error de opcion");
                        }
                }
                }
           
            Producto nuevoProducto;
            nuevoProducto = new Producto(codigo,nombre,caracteristicas,unaMarca,proveedores);
            listaProductos.Add(nuevoProducto);

            } else if (listaMarcas.Count == 0 && listaProvedores.Count == 0)
            {
                Console.WriteLine("Error, debe registrar al menos una marca y un proveedor");
            } else if (listaMarcas.Count == 0)
            {
                Console.WriteLine("Error, debe registrar al menos una marca");
            } else if (listaProvedores.Count == 0)
            {
                Console.WriteLine("Error, debe registrar al menos un proveedor");
            }
        }

        public static void mostrarProducto(ArrayList listaProductos)
        {
            if (listaProductos.Count > 0)
            {
                Console.WriteLine("----- Productos -----");

                for (int i = 0; i < listaProductos.Count; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("  ---Producto " + (i + 1) + " ---");
                    Console.WriteLine(listaProductos[i].ToString());
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("no hay Productos registradas");
            }
        }




























    }
}
