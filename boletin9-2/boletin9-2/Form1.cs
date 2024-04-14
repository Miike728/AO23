using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boletin9_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ej6 ejercicio6 = new ej6();
            ejercicio6.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ej7 ejercicio7 = new ej7();
            ejercicio7.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ej8 ejercicio8 = new ej8();
            ejercicio8.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ej9 ejercicio9 = new ej9();
            ejercicio9.ShowDialog();
        }
    }
}
