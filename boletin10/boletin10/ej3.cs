using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boletin10
{
    public partial class ej3 : Form
    {
        public ej3()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cerrar este formulario
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Limpiar textboxs, y radio buttons
            txtMetros.Text = "";
            txtResultado.Text = "";
            radioMilimetros.Checked = false;
            radioCentimetros.Checked = false;
            radioDecimetros.Checked = false;
            radioKilometros.Checked = false;
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            // Si no hay texto en txtMetros, mostrar mensaje de error
            if (txtMetros.Text == "")
            {
                MessageBox.Show("Introduce un valor en metros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Si hay algún punto, cambiarlo por coma (para evitar errores)
            txtMetros.Text = txtMetros.Text.Replace(".", ",");

            // Si está seleccionado milímetros
            if (radioMilimetros.Checked)
            {
                txtResultado.Text = (Convert.ToDouble(txtMetros.Text) * 1000).ToString(); // Convertir a milímetros y mostrar
            }
            // Si está seleccionado centímetros
            else if (radioCentimetros.Checked)
            {
                txtResultado.Text = (Convert.ToDouble(txtMetros.Text) * 100).ToString(); // Convertir a centímetros y mostrar
            }
            // Si está seleccionado decimetros
            else if (radioDecimetros.Checked)
            {
                txtResultado.Text = (Convert.ToDouble(txtMetros.Text) * 10).ToString(); // Convertir a decimetros y mostrar
            }
            // Si está seleccionado kilómetros
            else if (radioKilometros.Checked)
            {
                txtResultado.Text = (Convert.ToDouble(txtMetros.Text) / 1000).ToString(); // Convertir a kilómetros y mostrar
            }
            // Si no se ha seleccionado ninguna opción, mostrar mensaje de error
            else
            {
                MessageBox.Show("Selecciona una opción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
