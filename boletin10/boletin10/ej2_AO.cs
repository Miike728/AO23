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
    public partial class ej2_AO : Form
    {
        // Temario de aplicaciones ofimáticas
        string[] temario = { "Procesadores de texto", "Hojas de cálculo", "Bases de datos", "Presentaciones", "Programación C#" };
        string profesor = "Ramón Ríos y Martín García";
        public ej2_AO()
        {
            InitializeComponent();
        }

        private void ej2_AO_Load(object sender, EventArgs e)
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
