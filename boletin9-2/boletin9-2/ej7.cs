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
    public partial class ej7 : Form
    {
        double euros, dolares; // Variables

        private void txtEuros_TextChanged(object sender, EventArgs e)
        {
            try // Try para evitar errores
            {
                euros = Convert.ToDouble(txtEuros.Text); // Convertir a double
            }
            catch (Exception)
            {
            }
        }

        private void txtDolares_TextChanged(object sender, EventArgs e)
        {
            try // Try para evitar errores
            {
                dolares = Convert.ToDouble(txtDolares.Text); // Convertir a double el texto
            }
            catch (Exception)
            {
            }
        }

        private void btnDolares_Click(object sender, EventArgs e)
        {
            // Convertir a dolares
            dolares = euros * 1.06; // Cambio a dia 13/04/2024
            txtDolares.Text = dolares.ToString(); // Mostrar en el textbox
        }

        private void btnEuros_Click(object sender, EventArgs e)
        {
            // Convertir a euros y redondear a 2 decimales
            euros = Math.Round(dolares / 1.06, 2);
            txtEuros.Text = euros.ToString();
        }

        public ej7()
        {
            InitializeComponent();
        }

    }
}
