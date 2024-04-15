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
    public partial class ej3 : Form
    {
        int lado, cuadrado, ladoMayor, ladoMenor, rectangulo, base1, altura, triangulo;
        string resultado;

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
            try
            {
                altura = int.Parse(txtAltura.Text);
            }
            catch (Exception) { }
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            triangulo = base1 * altura;
            resultado = triangulo.ToString();
            txtResultado.Text = resultado;
        }

        public ej3()
        {
            InitializeComponent();
        }

        private void txtLadoMenor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ladoMenor = int.Parse(txtLadoMenor.Text);
            }
            catch (Exception) { }
        }

        private void txtBase_TextChanged(object sender, EventArgs e)
        {
            try
            {
                base1 = int.Parse(txtBase.Text);
            }
            catch (Exception) { }
        }

        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            rectangulo = ladoMayor * ladoMenor;
            resultado = rectangulo.ToString();
            txtResultado.Text = resultado;
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            cuadrado = lado * lado;
            resultado = cuadrado.ToString();
            txtResultado.Text = resultado;

        }

        private void txtLadoMayor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ladoMayor = int.Parse(txtLadoMayor.Text);
            }
            catch (Exception) { }
        }

        private void txtLado_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lado = int.Parse(txtLado.Text);
            }
            catch (Exception) { }

        }
    }
}
