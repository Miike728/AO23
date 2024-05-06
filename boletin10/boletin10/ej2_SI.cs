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
    public partial class ej2_SI : Form
    {
        // Temario de seguridad informática
        string[] temario = { "Introducción a la seguridad informática", "Seguridad en redes", "Seguridad en sistemas", "Seguridad en aplicaciones", "Seguridad en la información" };
        string profesor = "Francisco Rocha";

        public ej2_SI()
        {
            InitializeComponent();
        }

        private void ej2_SI_Load(object sender, EventArgs e)
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
