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
    public partial class ej6 : Form
    {
        double centigrados, fahrenheit; // Variables

        public ej6()
        {
            InitializeComponent();
        }

        private void txtFahrenheit_TextChanged(object sender, EventArgs e)
        {
            try // Try catch para evitar errores
            {
                fahrenheit = Convert.ToDouble(txtFahrenheit.Text); // Convertir el texto a double para tener decimales
            }
            catch (Exception) // Si hay un error en la conversión, no hace nada y tampoco crashea
            {
            }
        }

        private void btnFahrenheit_Click(object sender, EventArgs e)
        {
            fahrenheit = (centigrados * 9 / 5) + 32; // Fórmula para convertir de centígrados a fahrenheit
            txtFahrenheit.Text = fahrenheit.ToString(); // Mostrar el resultado en el textbox
        }

        private void btnCentigrados_Click(object sender, EventArgs e)
        {
            centigrados = (fahrenheit - 32) * 5 / 9; // Fórmula para convertir de fahrenheit a centígrados
            txtCentigrados.Text = centigrados.ToString(); // Mostrar el resultado en el textbox
        }

        private void txtCentigrados_TextChanged(object sender, EventArgs e)
        {
            try // Try catch para evitar errores
            {
                centigrados = Convert.ToDouble(txtCentigrados.Text); // Convertir el texto a double
            }
            catch (Exception) // Si hay un error, no hace nada y tampoco crashea
            {
            }
        }
    }
}
