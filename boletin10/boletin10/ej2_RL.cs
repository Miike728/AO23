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
    public partial class ej2_RL : Form
    {
        // Temario de redes locales
        string[] temario = { "Introducción a las redes", "Modelos de red", "Protocolos de red", "Medios de transmisión", "Topologías de red" };
        string profesor = "Francisco Rocha";
        public ej2_RL()
        {
            InitializeComponent();
        }

        private void ej2_RL_Load(object sender, EventArgs e)
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
