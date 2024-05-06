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
    public partial class ej2_MME : Form
    {
        // Temario de montaje y mantenimiento de equipos
        string[] temario = { "Componentes de un ordenador", "Montaje de un ordenador", "Mantenimiento de un ordenador", "Diagnóstico de averías", "Reparación de averías" };
        string profesor = "Alberto Álvarez";

        public ej2_MME()
        {
            InitializeComponent();
        }

        private void ej2_MME_Load(object sender, EventArgs e)
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
