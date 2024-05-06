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
    public partial class ej4 : Form
    {
        // Variables
        int horas, minutos, segundos;


        public ej4()
        {
            InitializeComponent();
        }

        private void ej4_Load(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            // Convertir horas a minutos y segundos
            minutos = horas * 60;
            segundos = minutos * 60;
            txtMinutos.Text = minutos.ToString();
            txtSegundos.Text = segundos.ToString();

        }

        private void txtHoras_TextChanged(object sender, EventArgs e)
        {
            // Obtener horas del textbox
            try
            {
                horas = int.Parse(txtHoras.Text);
            }
            catch (Exception) { }
        }
    }
}
