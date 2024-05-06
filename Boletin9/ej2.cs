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
    public partial class ej2 : Form
    {
        // Variables
        int dia, mes, año;
        string mesTexto;

        private void txtMes_TextChanged(object sender, EventArgs e)
        {
            try //Evitar que el programa se cierre si no se puede convertir a int
            {
                mes = int.Parse(txtMes.Text); // pasa de string a int
        }
            catch (Exception) { }
}

        private void txtAño_TextChanged(object sender, EventArgs e)
        {
            try //Evitar que el programa se cierre si no se puede convertir a int
            {
                año = int.Parse(txtAño.Text);
            }
            catch (Exception) { }
            
        }

        private void txtDia_TextChanged(object sender, EventArgs e)
        {
            try //Evitar que el programa se cierre si no se puede convertir a int
            {
                dia = int.Parse(txtDia.Text);
        }
            catch (Exception) { }
}

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar los textbox
            txtDia.Text = "";
            txtMes.Text = "";
            txtAño.Text = "";
            txtSalida.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {

            if (mes == 1)
            {
                mesTexto = "Enero";
            }
            else if (mes == 2)
            {
                mesTexto = "Febrero";
            }
            else if (mes == 3)
            {
                mesTexto = "Marzo";
            }
            else if (mes == 4)
            {
                mesTexto = "Abril";
            }
            else if (mes == 5)
            {
                mesTexto = "Mayo";
            }
            else if (mes == 6)
            {
                mesTexto = "Junio";
            }
            else if (mes == 7)
            {
                mesTexto = "Julio";
            }
            else if (mes == 8)
            {
                mesTexto = "Agosto";
            }
            else if (mes == 9)
            {
                mesTexto = "Septiembre";
            }
            else if (mes == 10)
            {
                mesTexto = "Octubre";
            }
            else if (mes == 11)
            {
                mesTexto = "Noviembre";
            }
            else if (mes == 12)
            {
                mesTexto = "Diciembre";
            }

            txtSalida.Text = dia + " de " + mesTexto + " de " + año; // Mostrar el resultado en el textbox

        }

        public ej2()
        {
            InitializeComponent();
        }
    }
}
