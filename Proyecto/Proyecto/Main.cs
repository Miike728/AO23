using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void añadirProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProductForm addForm = new AddProductForm();
            addForm.ShowDialog();
        }

        private void consultarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultProductForm consultForm = new ConsultProductForm();
            consultForm.ShowDialog();
        }
    }
}
