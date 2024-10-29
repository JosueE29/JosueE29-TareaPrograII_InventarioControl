using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstructura_GrupoTres
{
    internal class Logica
    {
        public static int[,] reservas = new int[4, 8];

        public static void inicializar()
        {
            for (int i = 0; i < reservas.GetLength(0); i++)
            {
                for (int j = 0; j < 8; j++)
                {

                }
            }

        }
        public static Boolean asientosReservados(int fila, int columna, int cedula)
        {
            if (reservas[fila, columna].Equals(0))
            {
                reservas[fila, columna] = cedula;

                return true;

            }
            else
            {

                return false;
            }


        }
        public static bool Cancelar(string cedulaStr)
        {
            if (!int.TryParse(cedulaStr, out int cedula))
            {
                return false; 
            }

            for (int i = 0; i < reservas.GetLength(0); i++)
            {
                for (int j = 0; j < reservas.GetLength(1); j++)
                {
                    if (reservas[i, j] == cedula) 
                    {
                        reservas[i, j] = 0; 
                        return true; 
                    }
                }
            }
            return false; 
        }
        // Mediante el "?" declaramos que los valores de int, int en este caso de las posiciones puede ser NULL
        public static (int, int)? BuscarReservaPorCedula(int cedula) //Se crea un metodo estatico llamado BuscarReservaPorCedula
        {
            for (int i = 0; i < reservas.GetLength(0); i++)
            {
                for (int j = 0; j < reservas.GetLength(1); j++)
                {
                    if (reservas[i, j] == cedula)
                    {
                        return (i, j); // Mediante este return devolvemos la posicion de la reserva
                    }
                }
            }
            return null; 
        }

    }
}



