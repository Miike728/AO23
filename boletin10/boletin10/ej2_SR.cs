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
    public partial class ej2_SR : Form
    {
        // Temario de servicios en red
        string[] temario = { "Servicios de red", "Servidores de red", "Servicios de directorio", "Servicios de acceso remoto", "Servicios de mensajería" };
        string profesor = "Francisco Rocha";

        public ej2_SR()
        {
            InitializeComponent();
        }

        private void ej2_SR_Load(object sender, EventArgs e)
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
