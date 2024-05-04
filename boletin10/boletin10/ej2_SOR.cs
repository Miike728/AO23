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
    public partial class ej2_SOR : Form
    {
        // Temario de sistemas operativos en red
        string[] temario = { "Introducción a los sistemas operativos en red", "Instalación de sistemas operativos en red", "Configuración de sistemas operativos en red", "Administración de sistemas operativos en red", "Optimización de sistemas operativos en red" };
        string profesor = "Enrique Prieto";

        public ej2_SOR()
        {
            InitializeComponent();
        }

        private void ej2_SOR_Load(object sender, EventArgs e)
        {
            // Limpiar listBox y textBox
            listBoxTemario.Items.Clear();
            txtProfesor.Clear();

            // Añadir el temario al listBox
            listBoxTemario.Items.AddRange(temario);

            // Mostrar el profesor en el textBox
            txtProfesor.Text = profesor;
        }
    }
}
