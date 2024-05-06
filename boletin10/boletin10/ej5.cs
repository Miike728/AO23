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
    public partial class ej5 : Form
    {
        // Contadores
        int ContadorMañana, ContadorNoche;

        public ej5()
        {
            InitializeComponent();
        }

        private void ej5_Load(object sender, EventArgs e)
        {
            // Añadir los elementos al combobox
            comboTurno.Items.Add("Mañana");
            comboTurno.Items.Add("Noche");
        }

        private void comboTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboTurno.SelectedIndex == 0) // Si el turno es mañana (indice 0)
            {
                listBoxMañana.Items.Add(txtEmpleado.Text); // Añadir el empleado a la lista de la mañana
            }
            else if (comboTurno.SelectedIndex == 1) // Si el turno es noche (indice 1)
            {
                listBoxNoche.Items.Add(txtEmpleado.Text); // Añadir el empleado a la lista de la noche
            }
            
            // Recalcular el total de cada lista
            foreach (string item in listBoxMañana.Items) // Calcular el total de empleados en la lista
            {
                ContadorMañana++;
            }
            txtTotalMañana.Text = ContadorMañana.ToString(); // Escribir el total en el textbox
            ContadorMañana = 0; // Reiniciar el contador

            foreach (string item in listBoxNoche.Items)
            {
                ContadorNoche++;
            }
            txtTotalNoche.Text = ContadorNoche.ToString();
            ContadorNoche = 0;

        }

        private void btnMañanaANoche_Click(object sender, EventArgs e)
        {
            if (listBoxMañana.SelectedIndex != -1) // Si hay un empleado seleccionado
            {
                listBoxNoche.Items.Add(listBoxMañana.SelectedItem); // Añadir el empleado a la lista de la noche
                listBoxMañana.Items.Remove(listBoxMañana.SelectedItem); // Eliminar el empleado de la lista de la mañana
            }

            // Recalcular el total de cada lista
            foreach (string item in listBoxMañana.Items) // Calcular el total de empleados en la lista
            {
                ContadorMañana++;
            }
            txtTotalMañana.Text = ContadorMañana.ToString(); // Escribir el total en el textbox
            ContadorMañana = 0; // Reiniciar el contador

            foreach (string item in listBoxNoche.Items)
            {
                ContadorNoche++;
            }
            txtTotalNoche.Text = ContadorNoche.ToString();
            ContadorNoche = 0;
        }

        private void btnNocheAMañana_Click(object sender, EventArgs e)
        {
            if (listBoxNoche.SelectedIndex != -1) // El inverso del anterior
            {
                listBoxMañana.Items.Add(listBoxNoche.SelectedItem); // Añadir empleado a la lista mañana
                listBoxNoche.Items.Remove(listBoxNoche.SelectedItem); // Eliminar empleado de la lista noche
            }

            // Recalcular el total de cada lista
            foreach (string item in listBoxMañana.Items) // Calcular el total de empleados en la lista
            {
                ContadorMañana++;
            }
            txtTotalMañana.Text = ContadorMañana.ToString(); // Escribir el total en el textbox
            ContadorMañana = 0; // Reiniciar el contador

            foreach (string item in listBoxNoche.Items)
            {
                ContadorNoche++;
            }
            txtTotalNoche.Text = ContadorNoche.ToString();
            ContadorNoche = 0;
        }

        private void btnTodoNocheAMañana_Click(object sender, EventArgs e)
        {
            foreach (string item in listBoxNoche.Items) // Añadir todos los elementos de la lista de la noche a la de la mañana
            {
                listBoxMañana.Items.Add(item);
            }
            // Eliminar todo de la lista
            while (listBoxNoche.Items.Count > 0) // Mientras haya algo en la lista
            {
                listBoxNoche.Items.RemoveAt(0); // Eliminar el primer elemento
            }

            // Recalcular el total de cada lista
            foreach (string item in listBoxMañana.Items) // Calcular el total de empleados en la lista
            {
                ContadorMañana++;
            }
            txtTotalMañana.Text = ContadorMañana.ToString(); // Escribir el total en el textbox
            ContadorMañana = 0; // Reiniciar el contador

            foreach (string item in listBoxNoche.Items)
            {
                ContadorNoche++;
            }
            txtTotalNoche.Text = ContadorNoche.ToString();
            ContadorNoche = 0;
        }

        private void btnTodoMañanaANoche_Click(object sender, EventArgs e)
        {
            foreach (string item in listBoxMañana.Items) // Añadir todos los elementos de la lista de la mañana a la lista de la noche
            {
                listBoxNoche.Items.Add(item);
            }
            //foreach (string item in listBoxMañana.Items) // Eliminar todos los elementos de la lista
            //{
            //    listBoxMañana.Items.Remove(item);
            //}
            // Eliminar todo de la lista (no se puede hacer con un foreach porque se modifica la listay da error, solo conseguí de esta forma)
            while (listBoxMañana.Items.Count > 0) // Mientras haya algo en la lista
            {
                listBoxMañana.Items.RemoveAt(0); // Eliminar el primer elemento
            }

            // Recalcular el total de cada lista
            foreach (string item in listBoxMañana.Items) // Calcular el total de empleados en la lista
            {
                ContadorMañana++;
            }
            txtTotalMañana.Text = ContadorMañana.ToString(); // Escribir el total en el textbox
            ContadorMañana = 0; // Reiniciar el contador

            foreach (string item in listBoxNoche.Items)
            {
                ContadorNoche++;
            }
            txtTotalNoche.Text = ContadorNoche.ToString();
            ContadorNoche = 0;
        }
    }
}
