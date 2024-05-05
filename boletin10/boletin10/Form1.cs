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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Abrir ej1
            ej1 ej1 = new ej1();
            ej1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Abrir ej2
            ej2 ej2 = new ej2();
            ej2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ej3 ej3 = new ej3();
            ej3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ej4 ej4 = new ej4();
            ej4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ej5 ej5 = new ej5();
            ej5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ej6 ej6 = new ej6();
            ej6.Show();
        }
    }
}
