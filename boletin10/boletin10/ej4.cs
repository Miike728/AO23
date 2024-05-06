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
    public partial class ej4 : Form
    {
        public ej4()
        {
            InitializeComponent();
        }

        private void ej4_Load(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            // Si no hay texto en el textbox, mostrar error
            if (txtCampo.Text == "")
            {
                MessageBox.Show("Introduce un valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Si está seleccionado el radioComboBox, guardar el valor en el ComboBox
            else if (radioComboBox.Checked)
            {
                comboBoxRegistros.Items.Add(txtCampo.Text);
            }
            // Si está seleccionado el radioListBox, guardar el valor en el ListBox
            else if (radioListBox.Checked)
            {
                listBoxRegistros.Items.Add(txtCampo.Text);
            }
            // Si no está seleccionado ninguno, mostrar error
            else
            {
                MessageBox.Show("Selecciona una opción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("registros.txt"); // Crear archivo
            file.WriteLine("Registros del ComboBox:"); // Escribir en el archivo
            foreach (var item in comboBoxRegistros.Items) // Para cada item en el ComboBox
            {
                file.WriteLine(item); // Escribir el item en el archivo
            }
            file.WriteLine(""); // Espacio en blanco
            file.WriteLine("Registros del ListBox:");
            foreach (var item in listBoxRegistros.Items) // Lo mismo para el ListBox
            {
                file.WriteLine(item);
            }
            file.Close(); // Cerrar el archivo para liberar recursos
        }
    }
}
