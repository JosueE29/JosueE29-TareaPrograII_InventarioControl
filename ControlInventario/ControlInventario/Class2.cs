//Josue Espinoza Castillo
//Prof. Benjamin Curling
//Tarea de Control de Inventarios 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlInventario
{
    internal class menu
    {
        public static void principal ()
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("1. Inicializar arreglos");
                Console.WriteLine("2. Ingresar Articulos");
                Console.WriteLine("3. Modificar Articulos");
                Console.WriteLine("4. Borrar Articulos");
                Console.WriteLine("5. Consultar Articulos");
                Console.WriteLine("6. Salir");
                Console.WriteLine("Digite una opción: ");
                opcion=int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: Articulos.inicializarArreglos(); break;
                    case 2: Articulos.ingresarProductos(); break;
                    case 3: Articulos.modificarProductos(); break;
                    case 4: Articulos.excluirProductos(); break;
                    case 5: Articulos.consultarProductos();  break;
                    case 6: Console.WriteLine("**** Saliendo del sistema****"); break;
                    default:Console.WriteLine("**** OPCION INVALIDA****"); break;
                }

            } 
            // Va a correr mientras la opcion este dentro de 6 o sea diferente a este dando un False
            while (opcion!=6);
            {


            }
        }
    }
}
