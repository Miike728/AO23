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
    public partial class ej2_AW : Form
    {
        // Temario de aplicaciones web
        string[] temario = { "Introducción a las aplicaciones web", "Desarrollo de aplicaciones web", "Implantación de aplicaciones web", "Mantenimiento de aplicaciones web", "Optimización de aplicaciones web" };
        string profesor = "Daniel Rivas";

        public ej2_AW()
        {
            InitializeComponent();
        }

        private void ej2_AW_Load(object sender, EventArgs e)
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
