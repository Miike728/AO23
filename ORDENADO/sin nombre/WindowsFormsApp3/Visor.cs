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
    public partial class Visor : Form
    {
        public Visor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void visorSeries_Load(object sender, EventArgs e)
        {
            StreamReader lector = new StreamReader(globals.ruta);

            string line = "";
            while(line != null)
            {
                line = lector.ReadLine();
                if (line != null)
                {
                    visorSeries.Items.Add(line.Split('*')[0]);
                }
            }
            lector.Close();
        }
    }
}
