using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        string ruta = Directory.GetCurrentDirectory() + "\\series.txt";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
                
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            int valoracion = int.Parse(txtValoracion.Text);

            StreamWriter escritor = new StreamWriter(ruta, true);
            escritor.WriteLine(titulo + "*" + valoracion);
            escritor.Close();
        }

        private void btnVisor_Click(object sender, EventArgs e)
        {
            Visor vs =new Visor();
            vs.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
