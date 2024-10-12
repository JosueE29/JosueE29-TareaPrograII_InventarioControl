using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Pequeña prueba realizada en la clase, esta no se invoca en el main
namespace ControlInventario
{
    internal class Arreglo
    {
        public void Main(string[] args)
        {
            int[] codigo = new int[10]; // Arreglo de 10 Posiciones Codigo
            string[] producto = new string[10]; // Arreglo de 10 posiciones Producto
            float[] precio = new float[10];
            int[] cantidad = new int[10];
            codigo[2] = 50;
            codigo[9] = 100;
            codigo[0] = 8501;
            producto[0] = "Teclado";
            producto[2] = "Mouse";
            producto[9] = "Monitor";
            cantidad[2] = 55;
            cantidad[9] = 60;
            cantidad[0] = 80;
            precio[2] = 15000;
            precio[9] = 6850;
            precio[0] = 25000;
            //Imprimir los valores de un arreglo
            for (int i = 0; i < 10; i++)
            {
                if (codigo[i] == 0 && (precio[i] >= 200 && precio[i] <= 300))
                    Console.WriteLine($"Código: {codigo[i]} - Producto: {producto[i]}");
                Console.WriteLine($"Cantidad {cantidad[i]} - Precio: {precio[i]}");
            }
            Console.Read();

        }
    }
}
