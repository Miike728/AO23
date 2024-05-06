using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletin9
{
    public partial class ej1 : Form
    {
        // Variables
        string nombre, correo, resultado; //variables para nombre, correo, y la suma de los dos


        public ej1()
        {
            InitializeComponent();
        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            // Guardar los valores de los textbox en las variables
            nombre = txtNombre.Text;
            correo = txtCorreo.Text;

            // Guardar el resultado en la variable resultado
            resultado = "Nombre: " + nombre + "  Correo: " + correo;
            
            // Mostrar el resultado en un MessageBox
            MessageBox.Show(resultado);

        }
    }
}
