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
    public partial class ej2_EIE : Form
    {
        // Temario de empresa e iniciativa emprendedora
        string[] temario = { "Iniciativa emprendedora", "La empresa y su entorno", "Creación y puesta en marcha de una empresa", "Función administrativa", "Función comercial" };
        string profesor = "Daniel Rivas";

        public ej2_EIE()
        {
            InitializeComponent();
        }

        private void ej2_EIE_Load(object sender, EventArgs e)
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
