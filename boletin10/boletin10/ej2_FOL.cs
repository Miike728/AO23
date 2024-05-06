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
    public partial class ej2_FOL : Form
    {
        // Temario de formación y orientación laboral
        string[] temario = { "Búsqueda de empleo", "Contratos de trabajo", "Seguridad social", "Prevención de riesgos laborales", "Derechos y deberes" };
        string profesor = "Daniel Rivas";

        public ej2_FOL()
        {
            InitializeComponent();
        }

        private void ej2_FOL_Load(object sender, EventArgs e)
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
