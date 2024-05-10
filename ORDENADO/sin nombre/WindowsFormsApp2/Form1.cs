using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text;
            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Introduce un DNI","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDNI.Focus();
                return;
            }
            dni = dni.Trim();
            dni = dni.ToUpper();
            

        }
    }
}
