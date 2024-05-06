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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEj1_Click(object sender, EventArgs e)
        {
            ej1 ejercicio1 = new ej1();
            ejercicio1.ShowDialog();
        }

        private void btnEj2_Click(object sender, EventArgs e)
        {
            ej2 ejercicio2 = new ej2();
            ejercicio2.ShowDialog();
        }

        private void btnEj3_Click(object sender, EventArgs e)
        {
            ej3 ejercicio3 = new ej3();
            ejercicio3.ShowDialog();
        }

        private void btnEj4_Click(object sender, EventArgs e)
        {
            ej4 ejercicio4 = new ej4();
            ejercicio4.ShowDialog();
        }

        private void btnEj5_Click(object sender, EventArgs e)
        {
            ej5 ejercicio5 = new ej5();
            ejercicio5.ShowDialog();
        }

        private void btnEj6_Click(object sender, EventArgs e)
        {
            ej6 ejercicio6 = new ej6();
            ejercicio6.ShowDialog();
        }

        private void btnEj7_Click(object sender, EventArgs e)
        {
            ej7 ejercicio7 = new ej7();
            ejercicio7.ShowDialog();
        }

        private void btnEj8_Click(object sender, EventArgs e)
        {
            ej8 ejercicio8 = new ej8();
            ejercicio8.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
