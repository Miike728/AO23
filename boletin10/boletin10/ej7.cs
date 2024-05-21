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
    public partial class ej7 : Form
    {
        // Variables
        int posicionInicial = 10; // Posición inicial del pictureBox

        public ej7()
        {
            InitializeComponent();
        }

        private void ej7_Load(object sender, EventArgs e)
        {
            timer1.Start(); // Iniciar timer
            pictureBox.Image = Properties.Resources.donut; // Poner imagen dado1 al pictureBox
            pictureBox.Left = posicionInicial; // Poner pictureBox en posición inicial
        }

        private void timer1_Tick(object sender, EventArgs e) // Mover picturebox cada tick (1000ms)
        {
            pictureBox.Left += 10; // Se suma 10 al valor de la propiedad Left

        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            timer1.Stop(); // Al pulsar, detener timer
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            // Al pulsar, reiniciar timer y poner pictureBox en su posición inicial
            timer1.Stop();
            timer1.Start();
            pictureBox.Left = posicionInicial;
        }
    }
}
