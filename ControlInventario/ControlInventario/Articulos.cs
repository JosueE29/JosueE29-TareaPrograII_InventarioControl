using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlInventario
{
    internal class Articulos
    {
        //Aumentamos la cantidad de la lista a 5
        public static int[] id = new int[5];

        public static int[] cantidad = new int[5];

        public static string[] nombre = new string[5];

        public static string[] bodega = new string[5];

        public static float[] precio = new float[5];


        //Inicializamos todos los datos en 0 y "" para empezar el programa
        public static void inicializarArreglos()
        {
            for (int i = 0; i < id.Length; i++)
            {
                id[i] = 0;
                cantidad[i] = 0;
                nombre[i] = " ";
                bodega[i] = " ";
                precio[i] = 0;

            }
            Console.ReadKey();
            Console.WriteLine("Los arreglos han sido inicializados");
            Console.Clear();
        }
        //Se crea una Void llamada ingresarProductos en la cual el user digita c/u de los datos requeridos como codigo, nombre, precio, bodega y la cantidad de unidades en bodega
        public static void ingresarProductos()
        {
            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine("Digite un codigo: ");
                id[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite el nombre del articulo: ");
                nombre[i] = Console.ReadLine();

                Console.WriteLine("Digite el precio del articulo: ");
                precio[i] = float.Parse(Console.ReadLine());

                Console.WriteLine("Indique en qué bodega está almacenado: ");
                bodega[i] = Console.ReadLine();

                Console.WriteLine("Digite la cantidad de articulos existentes: ");
                cantidad[i] = int.Parse(Console.ReadLine());

                Console.Clear();
            }
            Console.WriteLine("Los articulos han sido ingresados");
        }
        //Este void es el encargado de modificar los datos del produicto encontrado por el ID o codigo
        public static void modificarProductos()
        {
            Console.Clear();
            Console.WriteLine("Digite el codigo del articulo que desea modificar");
            int nuevocodigo = int.Parse(Console.ReadLine());

            for (int i = 0; i < id.Length; i++)
            {
                if (nuevocodigo == id[i])
                {
                    Console.WriteLine($"Codigo: {id[i]} Nombre: {nombre[i]}");
                    Console.WriteLine("Digite un nuevo Nombre:");
                    nombre[i] = Console.ReadLine();

                    Console.WriteLine("Digite un nuevo precio:");
                    precio[i] = float.Parse(Console.ReadLine());

                    Console.WriteLine("Digite la nueva bodega:");
                    bodega[i] = Console.ReadLine();

                    Console.WriteLine("Digite una nueva cantidad de unidades:");
                    cantidad[i] = int.Parse(Console.ReadLine());

                    break;
                }
            }
        }
        //Esta void genera una lista de los productos y datos registrados en el arreglo
        public static void consultarProductos()
        {
            Console.Clear();
            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine($"Codigo: {id[i]} - Nombre: {nombre[i]} - Precio: {precio[i]} - Cantiadad: {cantidad[i]} Bodega: {bodega[i]} ");
            }
            Console.WriteLine("*** FIN DEL REPORTE ***");
        }
        //excluirProctos elimina un producto registrado en el arreglo segun el ID registrado
        public static void excluirProductos()
        {
            Console.Clear();
            Console.WriteLine("Digite el codigo del articulo que desea eliminar");
            int eliminarCodigo = int.Parse(Console.ReadLine());

            for (int i = 0; i < id.Length; i++)
            {
                if (eliminarCodigo == id[i])
                {
                    id[i] = 0;
                    nombre[i] = " ";
                    bodega[i] = " ";
                    precio[i] = 0;
                    cantidad[i] = 0;

                    Console.WriteLine("Articulo eliminado.");
                    break;
                }
            }
        }
    }
}
