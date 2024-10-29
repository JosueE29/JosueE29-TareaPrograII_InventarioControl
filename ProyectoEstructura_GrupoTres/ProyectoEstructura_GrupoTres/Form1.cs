using ProyectoEstructura_GrupoTres;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//Proyecto Reservacion de Teatro
//Estructura de Datos
//Prof. Alexander Curling
//Grupo 3
//Estudiantes:
//Josue Espinoza Castillo
//David Estrada Morales
//Angel Castillo Vega
namespace ProyectoEstructura_GrupoTres
{
    public partial class Teatro : Form
    {
        public Teatro()
        {
            InitializeComponent();
        }
        public static int cedula; //Definimos el mismo valor de cedula para poder invocar

        private void silla2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CedulaTexto.Text.Trim(), out cedula)) //Intentamos convetir el str ingresado en CedulaTexto a int y mediante un .Trim eliminamos espacios en blanco tanto al inicio como al final
            {
                //Se invoca al metodo asientosReservados ubicada en la clase Logica 
                // Este método devuelve 'true' si el asiento estaba libre y la reserva fue exitosa.
                //Y cambiamos el color del boton a rojo, en este caso el ubicado en la posicion 0,1
                //DATO ESTO SE REPITE EN TODOS LOS DEMAS BOTONES 
                if (Logica.asientosReservados(0, 1, cedula) == true)
                {
                    silla2.BackColor = Color.Red;
                    MessageBox.Show("Reserva realizada");
                }
                else
                {
                    //En caso de que no, veremos este mensaje el cual indicara que el asiento esta ocupado
                    MessageBox.Show("No se puede reservar, asiento ocupado");
                }
            }
            else
            {
                //Y por ultimo en caso de que no pasen ninguna de las opciones anteriores, se tendra en cuenta que el user no ha ingresado un valor en el textBox
                MessageBox.Show("Por favor, ingrese un número de cédula válido");
            }
        }

        private void Teatro_Load(object sender, EventArgs e)
        {

        }

        private void silla1_Click(object sender, EventArgs e)
        {
            {
                if (int.TryParse(CedulaTexto.Text.Trim(), out cedula))
                {
                    if (Logica.asientosReservados(0, 0, cedula) == true)
                    {
                        silla1.BackColor = Color.Red;
                        MessageBox.Show("Reserva realizada");
                    }
                    else
                    {
                        MessageBox.Show("No se puede reservar");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un número de cédula válido");
                }
            }
        }
        private void silla17_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CedulaTexto.Text.Trim(), out cedula))
            {
                if (Logica.asientosReservados(2, 0, cedula) == true)
                {
                    silla17.BackColor = Color.Red;
                    MessageBox.Show("Reserva realizada");
                }
                else
                {
                    MessageBox.Show("No se puede reservar");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de cédula válido");
            }
        }
        private void silla3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CedulaTexto.Text.Trim(), out cedula))
            {
                if (Logica.asientosReservados(0, 2, cedula) == true)
                {
                    silla3.BackColor = Color.Red;
                    MessageBox.Show("Reserva realizada");
                }
                else
                {
                    MessageBox.Show("No se puede reservar");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de cédula válido");
            }
        }

        private void silla4_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CedulaTexto.Text.Trim(), out cedula))
            {
                if (Logica.asientosReservados(0, 3, cedula) == true)
                {
                    silla4.BackColor = Color.Red;
                    MessageBox.Show("Reserva realizada");
                }
                else
                {
                    MessageBox.Show("No se puede reservar");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de cédula válido");
            }
        }

        private void silla5_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CedulaTexto.Text.Trim(), out cedula))
            {
                if (Logica.asientosReservados(0, 4, cedula) == true)
                {
                    silla5.BackColor = Color.Red;
                    MessageBox.Show("Reserva realizada");
                }
                else
                {
                    MessageBox.Show("No se puede reservar");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de cédula válido");
            }
        }

        private void silla6_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CedulaTexto.Text.Trim(), out cedula))
            {
                if (Logica.asientosReservados(0, 5, cedula) == true)
                {
                    silla6.BackColor = Color.Red;
                    MessageBox.Show("Reserva realizada");
                }
                else
                {
                    MessageBox.Show("No se puede reservar");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de cédula válido");
            }
        }

        private void silla7_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CedulaTexto.Text.Trim(), out cedula))
            {
                if (Logica.asientosReservados(0, 6, cedula) == true)
                {
                    silla7.BackColor = Color.Red;
                    MessageBox.Show("Reserva realizada");
                }
                else
                {
                    MessageBox.Show("No se puede reservar");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de cédula válido");
            }
        }

        private void silla8_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CedulaTexto.Text.Trim(), out cedula))
            {
                if (Logica.asientosReservados(0, 7, cedula) == true)
                {
                    silla8.BackColor = Color.Red;
                    MessageBox.Show("Reserva realizada");
                }
                else
                {
                    MessageBox.Show("No se puede reservar");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de cédula válido");
            }
        }

        private void silla9_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CedulaTexto.Text.Trim(), out cedula))
            {
                if (Logica.asientosReservados(1, 0, cedula) == true)
                {
                    silla9.BackColor = Color.Red;
                    MessageBox.Show("Reserva realizada");
                }
                else
                {
                    MessageBox.Show("No se puede reservar");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de cédula válido");
            }
        }

        private void silla10_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CedulaTexto.Text.Trim(), out cedula))
            {
                if (Logica.asientosReservados(1, 1, cedula) == true)
                {
                    silla10.BackColor = Color.Red;
                    MessageBox.Show("Reserva realizada");
                }
                else
                {
                    MessageBox.Show("No se puede reservar");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de cédula válido");
            }
        }

        private void silla11_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CedulaTexto.Text.Trim(), out cedula))
            {
                if (Logica.asientosReservados(1, 2, cedula) == true)
                {
                    silla11.BackColor = Color.Red;
                    MessageBox.Show("Reserva realizada");
                }
                else
                {
                    MessageBox.Show("No se puede reservar");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de cédula válido");
            }
        }

        private void silla12_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CedulaTexto.Text.Trim(), out cedula))
            {
                if (Logica.asientosReservados(1, 3, cedula) == true)
                {
                    silla12.BackColor = Color.Red;
                    MessageBox.Show("Reserva realizada");
                }
                else
                {
                    MessageBox.Show("No se puede reservar");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de cédula válido");
            }
        }


        private void silla13_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CedulaTexto.Text.Trim(), out cedula))
            {
                if (Logica.asientosReservados(1, 4, cedula) == true)
                {
                    silla13.BackColor = Color.Red;
                    MessageBox.Show("Reserva realizada");
                }
                else
                {
                    MessageBox.Show("No se puede reservar");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de cédula válido");
            }
        }


        private void silla14_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CedulaTexto.Text.Trim(), out cedula))
            {
                if (Logica.asientosReservados(1, 5, cedula) == true)
                {
                    silla14.BackColor = Color.Red;
                    MessageBox.Show("Reserva realizada");
                }
                else
                {
                    MessageBox.Show("No se puede reservar");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de cédula válido");
            }
        }


        private void silla15_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CedulaTexto.Text.Trim(), out cedula))
            {
                if (Logica.asientosReservados(1, 6, cedula) == true)
                {
                    silla15.BackColor = Color.Red;
                    MessageBox.Show("Reserva realizada");
                }
                else
                {
                    MessageBox.Show("No se puede reservar");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de cédula válido");
            }
        }


        private void silla16_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CedulaTexto.Text.Trim(), out cedula))
            {
                if (Logica.asientosReservados(1, 7, cedula) == true)
                {
                    silla16.BackColor = Color.Red;
                    MessageBox.Show("Reserva realizada");
                }
                else
                {
                    MessageBox.Show("No se puede reservar");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de cédula válido");
            }
        }


        private void silla18_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CedulaTexto.Text.Trim(), out cedula))
            {
                if (Logica.asientosReservados(2, 1, cedula) == true)
                {
                    silla18.BackColor = Color.Red;
                    MessageBox.Show("Reserva realizada");
                }
                else
                {
                    MessageBox.Show("No se puede reservar");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de cédula válido");
            }
        }


        private void silla19_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CedulaTexto.Text.Trim(), out cedula))
            {
                if (Logica.asientosReservados(2, 2, cedula) == true)
                {
                    silla19.BackColor = Color.Red;
                    MessageBox.Show("Reserva realizada");
                }
                else
                {
                    MessageBox.Show("No se puede reservar");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de cédula válido");
            }
        }


        private void silla20_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CedulaTexto.Text.Trim(), out cedula))
            {
                if (Logica.asientosReservados(2, 3, cedula) == true)
                {
                    silla20.BackColor = Color.Red;
                    MessageBox.Show("Reserva realizada");
                }
                else
                {
                    MessageBox.Show("No se puede reservar");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de cédula válido");
            }
        }


        private void silla21_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CedulaTexto.Text.Trim(), out cedula))
            {
                if (Logica.asientosReservados(2, 4, cedula) == true)
                {
                    silla21.BackColor = Color.Red;
                    MessageBox.Show("Reserva realizada");
                }
                else
                {
                    MessageBox.Show("No se puede reservar");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de cédula válido");
            }
        }


        private void silla22_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CedulaTexto.Text.Trim(), out cedula))
            {
                if (Logica.asientosReservados(2, 5, cedula) == true)
                {
                    silla22.BackColor = Color.Red;
                    MessageBox.Show("Reserva realizada");
                }
                else
                {
                    MessageBox.Show("No se puede reservar");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de cédula válido");
            }
        }


        private void silla23_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CedulaTexto.Text.Trim(), out cedula))
            {
                if (Logica.asientosReservados(2, 6, cedula) == true)
                {
                    silla23.BackColor = Color.Red;
                    MessageBox.Show("Reserva realizada");
                }
                else
                {
                    MessageBox.Show("No se puede reservar");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de cédula válido");
            }
        }


        private void silla24_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CedulaTexto.Text.Trim(), out cedula))
            {
                if (Logica.asientosReservados(2, 7, cedula) == true)
                {
                    silla24.BackColor = Color.Red;
                    MessageBox.Show("Reserva realizada");
                }
                else
                {
                    MessageBox.Show("No se puede reservar");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de cédula válido");
            }
        }


        private void silla25_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CedulaTexto.Text.Trim(), out cedula))
            {
                if (Logica.asientosReservados(3, 0, cedula) == true)
                {
                    silla25.BackColor = Color.Red;
                    MessageBox.Show("Reserva realizada");
                }
                else
                {
                    MessageBox.Show("No se puede reservar");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de cédula válido");
            }
        }


        private void silla26_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CedulaTexto.Text.Trim(), out cedula))
            {
                if (Logica.asientosReservados(3, 1, cedula) == true)
                {
                    silla26.BackColor = Color.Red;
                    MessageBox.Show("Reserva realizada");
                }
                else
                {
                    MessageBox.Show("No se puede reservar");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de cédula válido");
            }
        }


        private void silla27_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CedulaTexto.Text.Trim(), out cedula))
            {
                if (Logica.asientosReservados(3, 2, cedula) == true)
                {
                    silla27.BackColor = Color.Red;
                    MessageBox.Show("Reserva realizada");
                }
                else
                {
                    MessageBox.Show("No se puede reservar");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de cédula válido");
            }
        }


        private void silla28_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CedulaTexto.Text.Trim(), out cedula))
            {
                if (Logica.asientosReservados(3, 3, cedula) == true)
                {
                    silla28.BackColor = Color.Red;
                    MessageBox.Show("Reserva realizada");
                }
                else
                {
                    MessageBox.Show("No se puede reservar");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de cédula válido");
            }
        }

        private void silla29_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CedulaTexto.Text.Trim(), out cedula))
            {
                if (Logica.asientosReservados(3, 4, cedula) == true)
                {
                    silla29.BackColor = Color.Red;
                    MessageBox.Show("Reserva realizada");
                }
                else
                {
                    MessageBox.Show("No se puede reservar");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de cédula válido");
            }
        }


        private void silla30_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CedulaTexto.Text.Trim(), out cedula))
            {
                if (Logica.asientosReservados(3, 5, cedula) == true)
                {
                    silla30.BackColor = Color.Red;
                    MessageBox.Show("Reserva realizada");
                }
                else
                {
                    MessageBox.Show("No se puede reservar");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de cédula válido");
            }
        }


        private void silla31_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CedulaTexto.Text.Trim(), out cedula))
            {
                if (Logica.asientosReservados(3, 6, cedula) == true)
                {
                    silla31.BackColor = Color.Red;
                    MessageBox.Show("Reserva realizada");
                }
                else
                {
                    MessageBox.Show("No se puede reservar");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de cédula válido");
            }
        }


        private void silla32_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CedulaTexto.Text.Trim(), out cedula))
            {
                if (Logica.asientosReservados(3, 7, cedula) == true)
                {
                    silla32.BackColor = Color.Red;
                    MessageBox.Show("Reserva realizada");
                }
                else
                {
                    MessageBox.Show("No se puede reservar");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de cédula válido");
            }
        }

        // Mediante el "?" declaramos que los valores de int, int en este caso de las posiciones puede ser NULL 
        //Esto para concordar con el eventos en Logica para ser especificos en BuscarReservaPorCedula
        private Button? ObtenerBotonSilla(int fila, int columna)
        {
            string nombreBoton = $"silla{(fila * 8) + columna + 1}";
            return this.Controls.Find(nombreBoton, true).FirstOrDefault() as Button;
        }

        private void Cancelacion_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CedulaTexto.Text.Trim(), out int cedula))
            {
                var posicion = Logica.BuscarReservaPorCedula(cedula);
                if (posicion.HasValue && Logica.Cancelar(cedula.ToString()))
                {

                    int fila = posicion.Value.Item1;
                    int columna = posicion.Value.Item2;
                    // Llamamos a 'ObtenerBotonSilla' para obtener el botón correspondiente a la posición (fila, columna) de la reserva.
                    Button? silla = ObtenerBotonSilla(fila, columna);
                    //Una vez cancelada la reservacion convertimos el boton de color Red al color DrakGreen esto si encuentra el boton
                    if (silla != null)
                    {
                        silla.BackColor = Color.DarkGreen;
                    }
                    //MNostrara este mensaje al cancelar de manera efectiva la reservacion
                    MessageBox.Show("Reserva cancelada");
                }
                else
                {
                    //En caso de no encontrar la reserva asignada a la de la matriz mostrara este mensaje
                    MessageBox.Show("Reserva no encontrada");
                }
            }
            else
            {
                //En caso de que en el TextBox no haya un valor valido mostrar el mensaje
                MessageBox.Show("Por favor, ingrese un número de cédula válido");
            }
        }



        private void ButtonInicializar_Click(object sender, EventArgs e)
        {

        }

        private void ReservacionTotal_Click(object sender, EventArgs e)
        {
            // Mediante el StringBuilder construimos el mensaje de manera eficiente
            StringBuilder mensaje = new StringBuilder("Reservaciones actuales:\n");
                
            bool hayReservas = false;

            //Recorremos la matriz para encontrar todas las reservaciones
            for (int i = 0; i < Logica.reservas.GetLength(0); i++)
            {
                for (int j = 0; j < Logica.reservas.GetLength(1); j++)
                {
                    int cedulaReservada = Logica.reservas[i, j];
                    if (cedulaReservada != 0) // El 0 indica que el asiento está libre
                    {
                        hayReservas = true;     
                        mensaje.AppendLine($"- Fila {i + 1}, Columna {j + 1}: Cédula {cedulaReservada}");
                    }
                }
            }

            // Mostramos un mensaje según haya o no reservaciones
            if (hayReservas)
            {
                MessageBox.Show(mensaje.ToString(), "Lista de Reservaciones");
            }
            else
            {
                //Este mensaje sera en caso de no haber reservcaciones
                MessageBox.Show("No hay reservaciones hechas.", "Lista de Reservaciones");
            }
        }
    }
}
