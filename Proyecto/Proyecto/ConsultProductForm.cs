using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proyecto
{
    public partial class ConsultProductForm : Form
    {
        public ConsultProductForm()
        {
            InitializeComponent();
        }

        private void txtCodigoBusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConsultProductForm_Load(object sender, EventArgs e)
        {

        }

        private void rbtnOrdenador_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrarResultados_Click(object sender, EventArgs e)
        {
            // Limpiar el listview1
            listView1.Items.Clear();
            listView1.Columns.Clear();

            // Busqueda
            // Si está selecioando el radiobutton de ordenador, mostrar los productos de la categoría ordenador en el listview1 (los ordenadores están en ordenadores.txt, con cada caracteristica separada con ; y cada ordenador separado con salto de línea)
            if (rbtnOrdenador.Checked)
            {
                // Si hay un código de producto en el textbox, mostrar solo ese producto
                if (txtCodigoBusqueda.Text != "")
                {
                    // Añadir las columnas al listview1 (Codigo, Marca, GPU, RAM, Almacenamiento, Procesador, Precio)
                    listView1.Columns.Add("Código", 75);
                    listView1.Columns.Add("Marca", 75);
                    listView1.Columns.Add("GPU", 100);
                    listView1.Columns.Add("RAM (GB)", 70);
                    listView1.Columns.Add("Almacenamiento", 100);
                    listView1.Columns.Add("Procesador", 110);
                    listView1.Columns.Add("Precio (€)", 60);

                    // Mostrar columnas
                    listView1.View = View.Details;

                    // Leer el archivo ordenadores.txt
                    string[] ordenadores = File.ReadAllLines("ordenadores.txt");
                    // Mostrar el ordenador con el código introducido en el textbox
                    foreach (string ordenador in ordenadores)
                    {
                        string[] caracteristicas = ordenador.Split(';');
                        if (caracteristicas[0] == txtCodigoBusqueda.Text)
                        {
                            ListViewItem item = new ListViewItem(caracteristicas[0]);
                            for (int i = 1; i < caracteristicas.Length; i++)
                            {
                                item.SubItems.Add(caracteristicas[i]);
                            }
                            listView1.Items.Add(item);
                        }
                    }
                }
                // Busquedas avanzadas (anidadas para poder buscar x RAM y x Marca, etc)
                else if (txtBusquedaMarca.Text != "" || txtBusquedaGPU.Text != "" || txtBusquedaRAM.Text != "" || txtBusquedaAlmacenamiento.Text != "" || txtBusquedaCPU.Text != "")
                {
                    // Añadir las columnas al listview1 (Codigo, Marca, GPU, RAM, Almacenamiento, Procesador, Precio)
                    listView1.Columns.Add("Código", 75);
                    listView1.Columns.Add("Marca", 75);
                    listView1.Columns.Add("GPU", 100);
                    listView1.Columns.Add("RAM (GB)", 70);
                    listView1.Columns.Add("Almacenamiento", 100);
                    listView1.Columns.Add("Procesador", 110);
                    listView1.Columns.Add("Precio (€)", 60);

                    // Mostrar columnas
                    listView1.View = View.Details;

                    // Leer el archivo ordenadores.txt
                    string[] ordenadores = File.ReadAllLines("ordenadores.txt");
                    // Mostrar los ordenadores que cumplan con las condiciones introducidas en los textbox
                    foreach (string ordenador in ordenadores)
                    {
                        string[] caracteristicas = ordenador.Split(';');
                        if ((txtBusquedaMarca.Text == "" || caracteristicas[1].ToLower().Contains(txtBusquedaMarca.Text.ToLower())) &&
                                                       (txtBusquedaGPU.Text == "" || caracteristicas[2].ToLower().Contains(txtBusquedaGPU.Text.ToLower())) &&
                                                                                  (txtBusquedaRAM.Text == "" || caracteristicas[3].ToLower().Contains(txtBusquedaRAM.Text.ToLower())) &&
                                                                                                             (txtBusquedaAlmacenamiento.Text == "" || caracteristicas[4].ToLower().Contains(txtBusquedaAlmacenamiento.Text.ToLower())) &&
                                                                                                                                        (txtBusquedaCPU.Text == "" || caracteristicas[5].ToLower().Contains(txtBusquedaCPU.Text.ToLower())))
                        {
                            ListViewItem item = new ListViewItem(caracteristicas[0]);
                            for (int i = 1; i < caracteristicas.Length; i++)
                            {
                                item.SubItems.Add(caracteristicas[i]);
                            }
                            listView1.Items.Add(item);
                        }
                    }
                }
                // Si no hay ninguna busqueda en los textbox, mostrar todos los productos
                else
                {
                    mostrarOrdenadores();
                }



                ///////////////////////////////////////////////
            }
            else if (rbtnMovil.Checked)
            {
                // Si hay un código de producto en el textbox, mostrar solo ese producto
                if (txtCodigoBusqueda.Text != "")
                {
                    // Añadir las columnas al listview1 (Codigo, Marca, Modelo, RAM, Almacenamiento, Pantalla, Precio)
                    listView1.Columns.Add("Código", 75);
                    listView1.Columns.Add("Marca", 75);
                    listView1.Columns.Add("Modelo", 100);
                    listView1.Columns.Add("RAM (GB)", 70);
                    listView1.Columns.Add("Almacenamiento", 100);
                    listView1.Columns.Add("Cámara", 70);
                    listView1.Columns.Add("Procesador", 70);
                    listView1.Columns.Add("Precio (€)", 60);

                    // Mostrar columnas
                    listView1.View = View.Details;

                    // Leer el archivo moviles.txt
                    string[] moviles = File.ReadAllLines("Moviles.txt");
                    // Mostrar el móvil con el código introducido en el textbox
                    foreach (string movil in moviles)
                    {
                        string[] caracteristicas = movil.Split(';');
                        if (caracteristicas[0] == txtCodigoBusqueda.Text)
                        {
                            ListViewItem item = new ListViewItem(caracteristicas[0]);
                            for (int i = 1; i < caracteristicas.Length; i++)
                            {
                                item.SubItems.Add(caracteristicas[i]);
                            }
                            listView1.Items.Add(item);
                        }
                    }
                }
                // Busquedas avanzadas (anidadas para poder buscar x RAM y x Marca, etc)
                else if (txtBusquedaMarca.Text != "" || txtBusquedaGPU.Text != "" || txtBusquedaRAM.Text != "" || txtBusquedaAlmacenamiento.Text != "" || txtBusquedaCPU.Text != "")
                {
                    // Añadir las columnas al listview1 (Codigo, Marca, Modelo, RAM, Almacenamiento, Pantalla, Precio)
                    listView1.Columns.Add("Código", 75);
                    listView1.Columns.Add("Marca", 75);
                    listView1.Columns.Add("Modelo", 100);
                    listView1.Columns.Add("RAM (GB)", 70);
                    listView1.Columns.Add("Almacenamiento", 100);
                    listView1.Columns.Add("Cámara", 70);
                    listView1.Columns.Add("Procesador", 70);
                    listView1.Columns.Add("Precio (€)", 60);

                    // Mostrar columnas
                    listView1.View = View.Details;

                    // Leer el archivo moviles.txt
                    string[] moviles = File.ReadAllLines("Moviles.txt");

                    // Mostrar los móviles que cumplan con las condiciones introducidas en los textbox
                    foreach (string movil in moviles)
                    {
                        string[] caracteristicas = movil.Split(';');
                        if ((txtBusquedaMarca.Text == "" || caracteristicas[1].ToLower().Contains(txtBusquedaMarca.Text.ToLower())) &&
                                                                                  (txtBusquedaGPU.Text == "" || caracteristicas[2].ToLower().Contains(txtBusquedaGPU.Text.ToLower())) &&
                                                                                                                                                                   (txtBusquedaRAM.Text == "" || caracteristicas[3].ToLower().Contains(txtBusquedaRAM.Text.ToLower())) &&
                                                                                                                                                                                                                                                                               (txtBusquedaAlmacenamiento.Text == "" || caracteristicas[4].ToLower().Contains(txtBusquedaAlmacenamiento.Text.ToLower())) &&
                                                                                                                                                                                                                                                                                                                                                                                                                      (txtBusquedaCPU.Text == "" || caracteristicas[5].ToLower().Contains(txtBusquedaCPU.Text.ToLower())))
                        {
                            ListViewItem item = new ListViewItem(caracteristicas[0]);
                            for (int i = 1; i < caracteristicas.Length; i++)
                            {
                                item.SubItems.Add(caracteristicas[i]);
                            }
                            listView1.Items.Add(item);
                        }
                    }
                }
                // Si no hay ninguna busqueda en los textbox, mostrar todos los productos
                else
                {
                    mostrarMoviles();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Si el rbtn de ordenadores está seleccionado, eliminar el producto seleccionado en el listview1, y actualizar el archivo de ordenadores.txt
            if (rbtnOrdenador.Checked)
            {
                // Si no hay ningún producto seleccionado, mostrar un mensaje de error, si hay uno seleccionado, preguntar si está seguro de eliminarlo
                if (listView1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Seleccione un producto para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("¿Está seguro de eliminar el producto seleccionado?", "Eliminar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // Leer el archivo ordenadores.txt
                        string[] ordenadores = File.ReadAllLines("ordenadores.txt");
                        // Crear un nuevo archivo ordenadoresT.txt
                        StreamWriter sw = new StreamWriter("ordenadoresT.txt");
                        // Recorrer los productos en el listview1
                        // Copiar todos los productos de ordenadores.txt a ordenadoresT.txt excepto el producto seleccionado
                        foreach (string ordenador in ordenadores)
                        {
                            string[] caracteristicas = ordenador.Split(';');
                            if (caracteristicas[0] != listView1.SelectedItems[0].SubItems[0].Text)
                            {
                                sw.WriteLine(ordenador);
                            }
                        }
                        // Cerrar el archivo
                        sw.Close();
                        // Eliminar el archivo ordenadores.txt
                        File.Delete("ordenadores.txt");
                        // Renombrar el archivo ordenadoresT.txt a ordenadores.txt
                        File.Move("ordenadoresT.txt", "ordenadores.txt");
                        // Actualizar el listview1
                        string codigo = listView1.SelectedItems[0].SubItems[0].Text;
                        listView1.Items.Remove(listView1.SelectedItems[0]);
                    }
                }
            }
            else if (rbtnMovil.Checked)
            {
                // Si no hay ningún producto seleccionado, mostrar un mensaje de error, si hay uno seleccionado, preguntar si está seguro de eliminarlo
                if (listView1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Seleccione un producto para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("¿Está seguro de eliminar el producto seleccionado?", "Eliminar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // Leer el archivo moviles.txt
                        string[] moviles = File.ReadAllLines("moviles.txt");
                        // Crear un nuevo archivo movilesT.txt
                        StreamWriter sw = new StreamWriter("movilesT.txt");
                        // Recorrer los productos en el listview1
                        // Copiar todos los productos de moviles.txt a movilesT.txt excepto el producto seleccionado
                        foreach (string movil in moviles)
                        {
                            string[] caracteristicas = movil.Split(';');
                            if (caracteristicas[0] != listView1.SelectedItems[0].SubItems[0].Text)
                            {
                                sw.WriteLine(movil);
                            }
                        }
                        // Cerrar el archivo
                        sw.Close();
                        // Eliminar el archivo moviles.txt
                        File.Delete("moviles.txt");
                        // Renombrar el archivo movilesT.txt a moviles.txt
                        File.Move("movilesT.txt", "moviles.txt");
                        // Actualizar el listview1
                        string codigo = listView1.SelectedItems[0].SubItems[0].Text;
                        listView1.Items.Remove(listView1.SelectedItems[0]);
                    }
                }
            }
        }

        // Función para mostrar los ordenadores
        private void mostrarOrdenadores()
        {
            // Añadir las columnas al listview1
            listView1.Columns.Add("Código", 75);
            listView1.Columns.Add("Marca", 75);
            listView1.Columns.Add("GPU", 110);
            listView1.Columns.Add("RAM (GB)", 70);
            listView1.Columns.Add("Almacenamiento", 140);
            listView1.Columns.Add("Procesador", 110);
            listView1.Columns.Add("Precio (€)", 60);

            // Mostrar columnas
            listView1.View = View.Details;

            // Leer el archivo ordenadores.txt
            string[] ordenadores = File.ReadAllLines("ordenadores.txt");
            // Mostrar los ordenadores en el listview1
            foreach (string ordenador in ordenadores)
            {
                string[] caracteristicas = ordenador.Split(';');
                ListViewItem item = new ListViewItem(caracteristicas[0]);
                for (int i = 1; i < caracteristicas.Length; i++)
                {
                    item.SubItems.Add(caracteristicas[i]);
                }
                listView1.Items.Add(item);
            }
        }

        // Función para mostrar los móviles
        private void mostrarMoviles()
        {
            // Añadir las columnas al listview1
            listView1.Columns.Add("Código", 75);
            listView1.Columns.Add("Marca", 75);
            listView1.Columns.Add("Modelo", 100);
            listView1.Columns.Add("RAM (GB)", 70);
            listView1.Columns.Add("Almacenamiento", 100);
            listView1.Columns.Add("Cámara", 70);
            listView1.Columns.Add("Procesador", 70);
            listView1.Columns.Add("Precio (€)", 60);

            // Mostrar columnas
            listView1.View = View.Details;

            // Leer el archivo moviles.txt
            string[] moviles = File.ReadAllLines("Moviles.txt");
            // Mostrar los móviles en el listview1
            foreach (string movil in moviles)
            {
                string[] caracteristicas = movil.Split(';');
                ListViewItem item = new ListViewItem(caracteristicas[0]);
                for (int i = 1; i < caracteristicas.Length; i++)
                {
                    item.SubItems.Add(caracteristicas[i]);
                }
                listView1.Items.Add(item);
            }
        }

        private void txtBusquedaMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBusquedaGPU_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBusquedaRAM_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBusquedaAlmacenamiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBusquedaCPU_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Mostrar imagen del producto seleccionado en el picturebox1
            if (listView1.SelectedItems.Count == 0)
            {
                pictureBox1.Image = null;
            }
            else
            {
                string codigo = listView1.SelectedItems[0].SubItems[0].Text;
                if (rbtnOrdenador.Checked)
                {
                    if (File.Exists("ImagenesOrdenadores\\" + codigo + ".png"))
                    {
                        pictureBox1.Image = Image.FromFile("ImagenesOrdenadores\\" + codigo + ".png");
                    }
                    else if (File.Exists("ImagenesOrdenadores\\" + codigo + ".jpg"))
                    {
                        pictureBox1.Image = Image.FromFile("ImagenesOrdenadores\\" + codigo + ".jpg");
                    }
                    else if (File.Exists("ImagenesOrdenadores\\" + codigo + ".jpeg"))
                    {
                        pictureBox1.Image = Image.FromFile("ImagenesOrdenadores\\" + codigo + ".jpeg");
                    }
                    else
                    {
                        pictureBox1.Image = Image.FromFile("ImagenesOrdenadores\\ordenador.png");
                    }
                }
                else if (rbtnMovil.Checked)
                {
                    if (File.Exists("ImagenesMoviles\\" + codigo + ".png"))
                    {
                        pictureBox1.Image = Image.FromFile("ImagenesMoviles\\" + codigo + ".png");
                    }
                    else if (File.Exists("ImagenesMoviles\\" + codigo + ".jpg"))
                    {
                        pictureBox1.Image = Image.FromFile("ImagenesMoviles\\" + codigo + ".jpg");
                    }
                    else if (File.Exists("ImagenesMoviles\\" + codigo + ".jpeg"))
                    {
                        pictureBox1.Image = Image.FromFile("ImagenesMoviles\\" + codigo + ".jpeg");
                    }
                    else
                    {
                        pictureBox1.Image = Image.FromFile("ImagenesMoviles\\movil.png");
                    }
                }
            }

        }
    }
}
