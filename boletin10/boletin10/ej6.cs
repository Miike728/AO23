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
    public partial class ej6 : Form
    {
        public ej6()
        {
            InitializeComponent();
        }

        // Según el radiobutton seleccionado, mostrar una imagen de los recursos
        private void radioTigre_CheckedChanged(object sender, EventArgs e)
        {
            // Si está seleccionado, mostrar la imagen del tigre
            if (radioTigre.Checked)
            {
                pictureBox.Image = Properties.Resources.tigre; // Imagen de los recursos, añadidos en el proyecto en la carpeta Resources
            }
        }

        private void radioLobo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioLobo.Checked)
            {
                pictureBox.Image = Properties.Resources.lobo;
            }
        }

        private void radioGato_CheckedChanged(object sender, EventArgs e)
        {
            if (radioGato.Checked)
            {
                pictureBox.Image = Properties.Resources.gato;
            }
        }

        private void ej6_Load(object sender, EventArgs e)
        {

        }
    }
}
