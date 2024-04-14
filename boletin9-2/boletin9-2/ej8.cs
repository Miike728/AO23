using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boletin9_2
{
    public partial class ej8 : Form
    {
        // Variables
        double acumulado = 0; // Variable para guardar el número acumulado
        string operacion = ""; // Variable para guardar la operación
        double numeroActual = 0; // Variable para guardar el número actual
        double memoria = 0; // Variable para guardar la memoria

        public ej8()
        {
            InitializeComponent();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtCalculadora.Text += "7"; // Añade el número 7 al final del texto
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtCalculadora.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtCalculadora.Text += "9";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtCalculadora.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtCalculadora.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtCalculadora.Text += "6";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtCalculadora.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtCalculadora.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtCalculadora.Text += "3";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtCalculadora.Text += "0";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            txtCalculadora.Text += ".";
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

        private void btnDiv_Click(object sender, EventArgs e)
        {
            acumulado = Double.Parse(txtCalculadora.Text); // Guarda el número actual en acumulado
            operacion = "/"; // Guarda la operación que se va a realizar
            txtCalculadora.Text = ""; // Limpia el texto para el siguiente número
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            acumulado = Double.Parse(txtCalculadora.Text);
            operacion = "-";
            txtCalculadora.Text = "";
        }

        private void btnMultipl_Click(object sender, EventArgs e)
        {
            acumulado = Double.Parse(txtCalculadora.Text);
            operacion = "*";
            txtCalculadora.Text = "";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            acumulado += Double.Parse(txtCalculadora.Text);
            operacion = "+";
            txtCalculadora.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            numeroActual = Double.Parse(txtCalculadora.Text); // Guarda el número actual en una variable
            switch (operacion) // Realiza la operación correspondiente
            {
                case "+": // Si la operación es suma, suma el acumulado con el número actual
                    txtCalculadora.Text = (acumulado + numeroActual).ToString();
                    break; // Break para salir del switch
                case "-": // Si la operación es resta, resta el acumulado con el número actual
                    txtCalculadora.Text = (acumulado - numeroActual).ToString();
                    break;
                case "*": // Si la operación es multiplicación, multiplica el acumulado con el número actual
                    txtCalculadora.Text = (acumulado * numeroActual).ToString();
                    break;
                case "/": // Si la operación es división, divide el acumulado con el número actual
                    if (numeroActual != 0) // Comprueba que el número actual no sea 0
                        txtCalculadora.Text = (acumulado / numeroActual).ToString(); // Divide el acumulado con el número actual
                    else // Si el número actual es 0
                        txtCalculadora.Text = "Error"; // Muestra un error
                    break;
            }
            acumulado = 0; // Reset acumulado para la siguiente operación
            operacion = ""; // Reset operación para la siguiente operación
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
            memoria = Double.Parse(txtCalculadora.Text); // Guarda el número actual en la memoria
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            txtCalculadora.Text = memoria.ToString(); // Muestra el número guardado en la memoria
        }

        private void btnMMas_Click(object sender, EventArgs e)
        {
            memoria += Double.Parse(txtCalculadora.Text); // Suma el número actual a la memoria
        }

        private void btnMMenos_Click(object sender, EventArgs e)
        {
            memoria -= Double.Parse(txtCalculadora.Text); // Resta el número actual a la memoria
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
    }
}
