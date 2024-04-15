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
    
    public partial class ej5 : Form
    {
        double num1, num2, resultado;

        private void txtCalc2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                num2 = double.Parse(txtCalc2.Text);
            }
            catch (Exception) { }
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            lblSuma.Show();
            lblMultiplicacion.Hide();
            lblResta.Hide();
            lblDividir.Hide();
            resultado = num1 + num2;
            txtResultado.Text = resultado.ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            lblResta.Show();
            lblSuma.Hide();
            lblMultiplicacion.Hide();
            lblDividir.Hide();
            resultado = num1 - num2;
            txtResultado.Text = resultado.ToString();
        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            lblMultiplicacion.Show();
            lblSuma.Hide();
            lblResta.Hide();
            lblDividir.Hide();
            resultado = num1 * num2;
            txtResultado.Text = resultado.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            lblDividir.Show();
            lblSuma.Hide();
            lblResta.Hide();
            lblMultiplicacion.Hide();
            resultado = num1 / num2;
            txtResultado.Text = resultado.ToString();
        }

        public ej5()
        {
            InitializeComponent();
            txtCalc1.Focus();
        }

        private void txtCalc1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                num1 = double.Parse(txtCalc1.Text);
            }
            catch (Exception) { }
        }
    }
}
