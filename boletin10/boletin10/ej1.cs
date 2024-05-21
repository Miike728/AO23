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
    public partial class ej1 : Form
    {
        //Variable total
        int total = 0;
        //Varibles para los precios
        int precioLaserJet = 100;
        int precioBigNotebook = 500;
        int precioSmartDesktop = 200;
        int precioDigicam = 80;
        int precioMP4 = 300;
        int precioModem = 150;

        //Variables para las cantidades
        int cantLaserJet = 0;
        int cantBigNotebook = 0;
        int cantSmartDesktop = 0;
        int cantDigicam = 0;
        int cantMP4 = 0;
        int cantModem = 0;

        public ej1()
        {
            InitializeComponent();
        }

        private void ej1_Load(object sender, EventArgs e)
        {
            
        }

        private void chkLaserJet_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkBigNotebook_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void chkSmartDesktop_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void chkDigicam_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void chkMP4_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void chkModem_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Si chkLaserJet está seleccionado, sumar al total el precio de LaserJet * la cantidad
            if (chkLaserJet.Checked)
            {
                cantLaserJet = (int)numericLaserJet.Value;
                total += precioLaserJet * cantLaserJet;
            }
            if (chkBigNotebook.Checked)
            {
                cantBigNotebook = (int)numericBigNotebook.Value;
                total += precioBigNotebook * cantBigNotebook;
            }
            if (chkSmartDesktop.Checked)
            {
                cantSmartDesktop = (int)numericSmartDesktop.Value;
                total += precioSmartDesktop * cantSmartDesktop;
            }
            if (chkDigicam.Checked)
            {
                cantDigicam = (int)numericDigicam.Value;
                total += precioDigicam * cantDigicam;
            }
            if (chkMP4.Checked)
            {
                cantMP4 = (int)numericMP4.Value;
                total += precioMP4 * cantMP4;
            }
            if (chkModem.Checked)
            {
                cantModem = (int)numericModem.Value;
                total += precioModem * cantModem;
            }

            //Mostrar el total en el textbox
            txtTotal.Text = "$" + total.ToString();
            total = 0; // Despues de mostrar el total, reiniciar la variable para el siguiente calculo
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Limpiar los checkbox, numeric y el textbox
            chkLaserJet.Checked = false;
            chkBigNotebook.Checked = false;
            chkSmartDesktop.Checked = false;
            chkDigicam.Checked = false;
            chkMP4.Checked = false;
            chkModem.Checked = false;
            numericLaserJet.Value = 0;
            numericBigNotebook.Value = 0;
            numericSmartDesktop.Value = 0;
            numericDigicam.Value = 0;
            numericMP4.Value = 0;
            numericModem.Value = 0;
            txtTotal.Text = "";
            total = 0;
        }

        private void numericLaserJet_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
