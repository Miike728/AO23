using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boletin10
{
    public partial class ej2 : Form
    {
        //Varibles:
        // 1GMI

        // Guardar en un array las asignaturas de 1GMI
        string[] asignaturas1GMI = { "Sistemas operativos monopuesto", "Aplicaciones ofimáticas", "Redes locales", "Montaje y mantenimiento de equipos", "Formación y orientación laboral" };

        // 2GMI

        // Guardar en un array las asignaturas de 2GMI
        string[] asignaturas2GMI = { "Sistemas operativos en red", "Servicios en red", "Seguridad informática", "Aplicaciones web", "Empresa e iniciativa emprendedora" };


        public ej2()
        {
            InitializeComponent();
        }

        private void ej2_Load(object sender, EventArgs e)
        {

        }

        private void radio1GMI_CheckedChanged(object sender, EventArgs e)
        {
            // Cuando se seleccione 1GMI, mostrar las asignaturas de 1GMI en el listBox
            listBoxAsignaturas.Items.Clear(); // Limpiar listBox
            // Añadir las asignaturas de 1GMI (del array) al listBox
            listBoxAsignaturas.Items.AddRange(asignaturas1GMI); // AddRange añade automáticamente todo el array
        }

        private void radio2GMI_CheckedChanged(object sender, EventArgs e)
        {
            listBoxAsignaturas.Items.Clear(); // Limpiar listBox
            listBoxAsignaturas.Items.AddRange(asignaturas2GMI);
        }

        private void listBoxAsignaturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si el índice seleccionado es 0 (SOM) y se ha seleccionado 1GMI, mostrar formulario de SOM
            if (listBoxAsignaturas.SelectedIndex == 0 && radio1GMI.Checked)
            {
                //Abrir SOM
                ej2_SOM SOM = new ej2_SOM();
                SOM.Show();
            }
            // indice 1 (AO) y 1GMI
            if (listBoxAsignaturas.SelectedIndex == 1 && radio1GMI.Checked)
            {
                //Abrir AO
                ej2_AO AO = new ej2_AO();
                AO.Show();
            }
            // indice 2 (RL) y 1GMI
            if (listBoxAsignaturas.SelectedIndex == 2 && radio1GMI.Checked)
            {
                //Abrir RL
                ej2_RL RL = new ej2_RL();
                RL.Show();
            }
            // indice 3 (MME) y 1GMI
            if (listBoxAsignaturas.SelectedIndex == 3 && radio1GMI.Checked)
            {
                //Abrir MME
                ej2_MME MME = new ej2_MME();
                MME.Show();
            }
            // indice 4 (FOL) y 1GMI
            if (listBoxAsignaturas.SelectedIndex == 4 && radio1GMI.Checked)
            {
                //Abrir FOL
                ej2_FOL FOL = new ej2_FOL();
                FOL.Show();
            }

            // 2GMI
            // indice 0 (SOR) y 2GMI
            if (listBoxAsignaturas.SelectedIndex == 0 && radio2GMI.Checked)
            {
                //Abrir SOR
                ej2_SOR SOR = new ej2_SOR();
                SOR.Show();
            }
            // indice 1 (SR) y 2GMI
            if (listBoxAsignaturas.SelectedIndex == 1 && radio2GMI.Checked)
            {
                //Abrir SR
                ej2_SR SR = new ej2_SR();
                SR.Show();
            }
            // indice 2 (SI) y 2GMI
            if (listBoxAsignaturas.SelectedIndex == 2 && radio2GMI.Checked)
            {
                //Abrir SI
                ej2_SI SI = new ej2_SI();
                SI.Show();
            }
            // indice 3 (AW) y 2GMI
            if (listBoxAsignaturas.SelectedIndex == 3 && radio2GMI.Checked)
            {
                //Abrir AW
                ej2_AW AW = new ej2_AW();
                AW.Show();
            }
            // indice 4 (EIE) y 2GMI
            if (listBoxAsignaturas.SelectedIndex == 4 && radio2GMI.Checked)
            {
                //Abrir EIE
                ej2_EIE EIE = new ej2_EIE();
                EIE.Show();
            }

        }
    }
}
