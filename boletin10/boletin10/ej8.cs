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
    public partial class ej8 : Form
    {
        // Variables
        Random rnd = new Random();
        int dado1, dado2, dado3, dado4;

        private void pictureDado2_Click(object sender, EventArgs e)
        {

        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            // Lanzar los dados al pulsar el botón
            dado1 = rnd.Next(1, 7); // Genera un número aleatorio entre 1 y 6, 7 porque el límite es exclusivo
            dado2 = rnd.Next(1, 7);
            dado3 = rnd.Next(1, 7);
            dado4 = rnd.Next(1, 7);

            // Muestra la imagen correspondiente a cada dado
            // Dado 1
            switch (dado1)
            {
                case 1:
                    pictureDado1.Image = Properties.Resources.dado1;
                    break;
                case 2:
                    pictureDado1.Image = Properties.Resources.dado2;
                    break;
                case 3:
                    pictureDado1.Image = Properties.Resources.dado3;
                    break;
                case 4:
                    pictureDado1.Image = Properties.Resources.dado4;
                    break;
                case 5:
                    pictureDado1.Image = Properties.Resources.dado5;
                    break;
                case 6:
                    pictureDado1.Image = Properties.Resources.dado6;
                    break;
            }
            // Dado 2
            switch (dado2)
            {
                case 1:
                    pictureDado2.Image = Properties.Resources.dado1;
                    break;
                case 2:
                    pictureDado2.Image = Properties.Resources.dado2;
                    break;
                case 3:
                    pictureDado2.Image = Properties.Resources.dado3;
                    break;
                case 4:
                    pictureDado2.Image = Properties.Resources.dado4;
                    break;
                case 5:
                    pictureDado2.Image = Properties.Resources.dado5;
                    break;
                case 6:
                    pictureDado2.Image = Properties.Resources.dado6;
                    break;
            }
            // Dado 3
            switch (dado3)
            {
                case 1:
                    pictureDado3.Image = Properties.Resources.dado1;
                    break;
                case 2:
                    pictureDado3.Image = Properties.Resources.dado2;
                    break;
                case 3:
                    pictureDado3.Image = Properties.Resources.dado3;
                    break;
                case 4:
                    pictureDado3.Image = Properties.Resources.dado4;
                    break;
                case 5:
                    pictureDado3.Image = Properties.Resources.dado5;
                    break;
                case 6:
                    pictureDado3.Image = Properties.Resources.dado6;
                    break;
            }
            // Dado 4
            switch (dado4)
            {
                case 1:
                    pictureDado4.Image = Properties.Resources.dado1;
                    break;
                case 2:
                    pictureDado4.Image = Properties.Resources.dado2;
                    break;
                case 3:
                    pictureDado4.Image = Properties.Resources.dado3;
                    break;
                case 4:
                    pictureDado4.Image = Properties.Resources.dado4;
                    break;
                case 5:
                    pictureDado4.Image = Properties.Resources.dado5;
                    break;
                case 6:
                    pictureDado4.Image = Properties.Resources.dado6;
                    break;
            }
        }

        public ej8()
        {
            InitializeComponent();
        }

        private void ej8_Load(object sender, EventArgs e) // Lanzar los dados al cargar el form
        {
            dado1 = rnd.Next(1, 7); // Genera un número aleatorio entre 1 y 6, 7 porque el límite es exclusivo
            dado2 = rnd.Next(1, 7);
            dado3 = rnd.Next(1, 7);
            dado4 = rnd.Next(1, 7);

            // Muestra la imagen correspondiente a cada dado
            // Dado 1
            switch (dado1)
            {
                case 1:
                    pictureDado1.Image = Properties.Resources.dado1;
                    break;
                case 2:
                    pictureDado1.Image = Properties.Resources.dado2;
                    break;
                case 3:
                    pictureDado1.Image = Properties.Resources.dado3;
                    break;
                case 4:
                    pictureDado1.Image = Properties.Resources.dado4;
                    break;
                case 5:
                    pictureDado1.Image = Properties.Resources.dado5;
                    break;
                case 6:
                    pictureDado1.Image = Properties.Resources.dado6;
                    break;
            }
            // Dado 2
            switch (dado2)
            {
                case 1:
                    pictureDado2.Image = Properties.Resources.dado1;
                    break;
                case 2:
                    pictureDado2.Image = Properties.Resources.dado2;
                    break;
                case 3:
                    pictureDado2.Image = Properties.Resources.dado3;
                    break;
                case 4:
                    pictureDado2.Image = Properties.Resources.dado4;
                    break;
                case 5:
                    pictureDado2.Image = Properties.Resources.dado5;
                    break;
                case 6:
                    pictureDado2.Image = Properties.Resources.dado6;
                    break;
            }
            // Dado 3
            switch (dado3)
            {
                case 1:
                    pictureDado3.Image = Properties.Resources.dado1;
                    break;
                case 2:
                    pictureDado3.Image = Properties.Resources.dado2;
                    break;
                case 3:
                    pictureDado3.Image = Properties.Resources.dado3;
                    break;
                case 4:
                    pictureDado3.Image = Properties.Resources.dado4;
                    break;
                case 5:
                    pictureDado3.Image = Properties.Resources.dado5;
                    break;
                case 6:
                    pictureDado3.Image = Properties.Resources.dado6;
                    break;
            }
            // Dado 4
            switch (dado4)
            {
                case 1:
                    pictureDado4.Image = Properties.Resources.dado1;
                    break;
                case 2:
                    pictureDado4.Image = Properties.Resources.dado2;
                    break;
                case 3:
                    pictureDado4.Image = Properties.Resources.dado3;
                    break;
                case 4:
                    pictureDado4.Image = Properties.Resources.dado4;
                    break;
                case 5:
                    pictureDado4.Image = Properties.Resources.dado5;
                    break;
                case 6:
                    pictureDado4.Image = Properties.Resources.dado6;
                    break;
            }
        }
    }
}
