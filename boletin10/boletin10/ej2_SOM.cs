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
    public partial class ej2_SOM : Form
    {
        // Temario de sistemas operativos monopuesto
        string[] temario = { "Introducción a los sistemas operativos", "Instalación de sistemas operativos", "Configuración de sistemas operativos", "Administración de sistemas operativos", "Optimización de sistemas operativos" };
        string profesor = "Enrique Prieto";

        public ej2_SOM()
        {
            InitializeComponent();
        }

        private void ej2_SOM_Load(object sender, EventArgs e)
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
