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
    {// Variables
        int lado, cuadrado, ladoMayor, ladoMenor, rectangulo, base1, altura, triangulo;
        string resultado;

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
            try // Control de errores
            {
                altura = int.Parse(txtAltura.Text); // Convertir a int, y guardar en variable
            }
            catch (Exception) { }
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            // Hacer el calculo y mostrarlo en el textbox
            triangulo = base1 * altura;
            resultado = triangulo.ToString();
            txtResultado.Text = resultado;
        }

        private void ej3_Load(object sender, EventArgs e)
        {

        }

        public ej3()
        {
            InitializeComponent();
        }

        private void txtLadoMenor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ladoMenor = int.Parse(txtLadoMenor.Text); // Convertir a int y guardar en variable
            }
            catch (Exception) { }
        }

        private void txtBase_TextChanged(object sender, EventArgs e)
        {
            try
            {
                base1 = int.Parse(txtBase.Text); // Convertir a int y guardar en variable
            }
            catch (Exception) { }
        }

        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            // Calculo del rectangulo y mostrar en el textbox
            rectangulo = ladoMayor * ladoMenor;
            resultado = rectangulo.ToString();
            txtResultado.Text = resultado;
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            // Calculo del cuadrado y mostrarlo en el textbox
            cuadrado = lado * lado;
            resultado = cuadrado.ToString();
            txtResultado.Text = resultado;

        }

        private void txtLadoMayor_TextChanged(object sender, EventArgs e)
        {
            // Convertir a int y `guardar, con control de errores
            try
            {
                ladoMayor = int.Parse(txtLadoMayor.Text);
            }
            catch (Exception) { }
        }

        private void txtLado_TextChanged(object sender, EventArgs e)
        {
            // Igual que el anterior
            try
            {
                lado = int.Parse(txtLado.Text);
            }
            catch (Exception) { }

        }
    }
}
