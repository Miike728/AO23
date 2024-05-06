using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletin9
{
    public partial class ej8 : Form
    {
        // Variables
        double acumulado = 0; // Variable para guardar el número acumulado
        string operacion = ""; // Variable para guardar la operación
        double numeroActual = 0; // Variable para guardar el número actual
        double memoria = 0; // Variable para guardar la memoria
        bool nuevaOperacion = false; // Variables para indicar si hay una operación pendiente

        public ej8()
        {
            InitializeComponent();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (nuevaOperacion) // Si hay una nueva operación
            {
                txtCalculadora.Text = "7"; // Añade el número al texto
                nuevaOperacion = false; // Pone en false la variable para continuar
            }
            else
            {
                txtCalculadora.Text += "7"; // Si no hay nueva operación, añade el número al texto únicamente
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (nuevaOperacion)
            {
                txtCalculadora.Text = "8";
                nuevaOperacion = false;
            }
            else
            {
                txtCalculadora.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (nuevaOperacion)
            {
                txtCalculadora.Text = "9";
                nuevaOperacion = false;
            }
            else
            {
                txtCalculadora.Text += "9";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (nuevaOperacion)
            {
                txtCalculadora.Text = "4";
                nuevaOperacion = false;
            }
            else
            {
                txtCalculadora.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (nuevaOperacion)
            {
                txtCalculadora.Text = "5";
                nuevaOperacion = false;
            }
            else
            {
                txtCalculadora.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (nuevaOperacion)
            {
                txtCalculadora.Text = "6";
                nuevaOperacion = false;
            }
            else
            {
                txtCalculadora.Text += "6";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (nuevaOperacion)
            {
                txtCalculadora.Text = "1";
                nuevaOperacion = false;
            }
            else
            {
                txtCalculadora.Text += "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (nuevaOperacion)
            {
                txtCalculadora.Text = "2";
                nuevaOperacion = false;
            }
            else
            {
                txtCalculadora.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (nuevaOperacion)
            {
                txtCalculadora.Text = "3";
                nuevaOperacion = false;
            }
            else
            {
                txtCalculadora.Text += "3";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (nuevaOperacion)
            {
                txtCalculadora.Text = "0";
                nuevaOperacion = false;
            }
            else
            {
                txtCalculadora.Text += "0";
            }
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            txtCalculadora.Text += ","; // Coma para que funcione, punto no funciona
        }

        private void btnC_Click(object sender, EventArgs e)
        {

            try
            {
                txtCalculadora.Text = txtCalculadora.Text.Remove(txtCalculadora.Text.Length - 1); // Elimina el último caracter, buscando el índice de la longitud del texto y restando 1
            }
            catch (Exception) // Si no hay texto, no hace nada
            { }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            // Elimina todo el texto
            txtCalculadora.Text = "";
        }

        private void txtCalculadora_TextChanged(object sender, EventArgs e)
        {

        }

        // Función para realizar el cálculo
        private void RealizarCalculo()
        {
            double numeroActual = double.Parse(txtCalculadora.Text); // Obtiene el número actual y lo guarda en una variable
            switch (operacion) // Realiza la operación correspondiente según la variable operación
            {
                case "+":
                    acumulado += numeroActual; // Suma el número actual al acumulado
                    break;
                case "-":
                    acumulado -= numeroActual; // Resta el número actual al acumulado
                    break;
                case "*":
                    acumulado *= numeroActual; // Multiplica el número actual al acumulado
                    break;
                case "/":
                    if (numeroActual != 0) // Si el número actual no es 0, divide el acumulado por el actual
                        acumulado /= numeroActual;
                    else
                    {
                        txtCalculadora.Text = "Error"; // Si se intenta dividir por 0, aparece unerror
                        return;
                    }
                    break;
                default:
                    acumulado = numeroActual; // Si no hay operación, el acumulado es el número actual, para poder seguir
                    break;
            }
            txtCalculadora.Text = acumulado.ToString(); // Muestra el resultado acumulado en el texto
            nuevaOperacion = true; // Marca que el siguiente número deberá iniciar una nueva operación
        }

        // Botones de operaciones
        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (!nuevaOperacion) // Si no hay una nueva operación
                RealizarCalculo(); // Realiza el cálculo en la función
            operacion = "/"; //Define la operación
        }

        private void btnResta_Click(object sender, EventArgs e)
        { 
            if (!nuevaOperacion) // Si no hay una nueva operación
                RealizarCalculo(); // Realiza el cálculo en la función
            operacion = "-"; //Define la operación
        }

        private void btnMultipl_Click(object sender, EventArgs e)
        {
            if (!nuevaOperacion) // Si no hay una nueva operación
                RealizarCalculo(); // Realiza el cálculo en la función
            operacion = "*"; //Define la operación
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (!nuevaOperacion) // Si no hay una nueva operación
                RealizarCalculo(); // Realiza el cálculo en la función
            operacion = "+"; //Define la operación
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            RealizarCalculo(); // Completa el cálculo final
            operacion = ""; // Resetea la operación
            nuevaOperacion = true; // Permite iniciar una nueva operaación
        }

        private void btnPorcent_Click(object sender, EventArgs e)
        {
            numeroActual = Double.Parse(txtCalculadora.Text); // Guarda el número actual en una variable

            double porcentaje = acumulado * (numeroActual / 100); // Calcula el porcentaje del acumulado.

            txtCalculadora.Text = (acumulado + porcentaje).ToString(); // Suma el porcentaje al acumulado.


            acumulado = 0; // Limpiar acumulado
            operacion = ""; // Limpiar operación
        }

        private void btnBinario_Click(object sender, EventArgs e)
        {
            try
            {
                long numero = long.Parse(txtCalculadora.Text); // Convierte el texto a entero. Variable long para números grandes.
                string binario = Convert.ToString(numero, 2); // Convierte el número a binario, y guarda en variable.
                txtCalculadora.Text = binario; // Muestra el resultado binario.
            }
            catch (Exception) // Si da error, no hace nada.
            {
                MessageBox.Show("Error. Número muy largo o no válido."); // Muestra un mensaje de error.
            }

            acumulado = 0; // Limpiar acumulado
            operacion = ""; // Limpiar operación
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            try // Evitar crash si no hay número
            {
                memoria = Double.Parse(txtCalculadora.Text); // Guarda el número actual en la memoria
            }
            catch (Exception) // Si hay error, no hace nada
            {
                MessageBox.Show("Error. Ningún número para guardar."); // Muestra un mensaje de error
            }
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            txtCalculadora.Text = memoria.ToString(); // Muestra el número guardado en la memoria
            nuevaOperacion = false;
        }

        private void btnMMas_Click(object sender, EventArgs e)
        {
            memoria += Double.Parse(txtCalculadora.Text); // Suma el número actual a la memoria
            txtCalculadora.Text = memoria.ToString(); // Muestra el resultado en el texto
        }

        private void btnMMenos_Click(object sender, EventArgs e)
        {
            memoria -= Double.Parse(txtCalculadora.Text); // Resta el número actual a la memoria
            txtCalculadora.Text = memoria.ToString(); // Muestra el resultado en el texto
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            memoria = 0; // Vacía la memoria
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            // Calcula la raíz cuadrada del número actual
            txtCalculadora.Text = Math.Sqrt(Double.Parse(txtCalculadora.Text)).ToString();
        }

        private void btnCos_Click(object sender, EventArgs e)
        {

        }

        private void btnSen_Click(object sender, EventArgs e)
        {

        }
    }
}
