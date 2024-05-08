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
    public partial class ej9 : Form
    {
        // Arrays de platos y precios
        string[] crema = { "Champiñones", "Puerros", "Zanahoria" };
        string[] cremaPrecio = { "4", "5", "4,75" };
        string[] ensalada = {"Primavera", "Romana", "César" };
        string[] ensaladaPrecio = { "3", "4", "4,5" };
        string[] empanada = { "Pulpo", "Zamburiñas", "Carne", "Choco" };
        string[] empanadaPrecio = { "6", "7", "3", "3,5" };
        string[] pescado = { "Merluza a la plancha", "Lenguado", "Besugo", "Bacalao al horno" };
        string[] pescadoPrecio = { "4,5", "4,5", "6", "6" };
        string[] carne = { "Milanesa", "Chuleta", "San Jacobos", "Solomillo" };
        string[] carnePrecio = { "4,5", "7,5", "4,5", "8,5" };
        string[] pasta = { "Spaguetti Bolognesa", "Macarrones carbonara", "Trofie al pesto" };
        string[] pastaPrecio = { "9", "9,5", "10,5" };
        string[] postre = { "Fruta/Yogurt", "Brownie Chocolate con helado", "Tarta de Santiago", "Tarta semifría de chocolate y queso" };
        string[] postrePrecio = { "1,5", "3,5", "3,5", "3,5" };
        string[] cafe = { "Con leche", "Cortado", "Solo", "Descafeinado" };
        string[] cafePrecio = { "1", "1", "1", "1" };
        string[] bebida = { "Agua", "Refresco", "Vino" };
        string[] bebidaPrecio = { "1", "1,5", "1,5" }; // No hay precios en el boletin

        int primerPlato, segundoPlato, bebidaT, postreCafe; // Totales

        private void ej9_Load(object sender, EventArgs e)
        {

        }

        private void rbtnEnsalada_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxPrimerPlato.Items.Clear(); // Limpiar el combobox
            comboBoxPrimerPlato.Items.AddRange(ensalada); // Añadir los elementos del array ensalada
        }

        private void rbtnEmpanada_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxPrimerPlato.Items.Clear();
            comboBoxPrimerPlato.Items.AddRange(empanada);
        }

        private void rbtnPescado_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxSegundoPlato.Items.Clear();
            comboBoxSegundoPlato.Items.AddRange(pescado);
        }

        private void rbtnCarne_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxSegundoPlato.Items.Clear();
            comboBoxSegundoPlato.Items.AddRange(carne);
        }

        private void rbtnPasta_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxSegundoPlato.Items.Clear();
            comboBoxSegundoPlato.Items.AddRange(pasta);
        }

        private void rbtnCrema_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxPrimerPlato.Items.Clear();
            comboBoxPrimerPlato.Items.AddRange(crema);
        }

        private void rbtnAgua_CheckedChanged(object sender, EventArgs e)
        {
            bebidaT = 0; // Inde del agua
            lblPrecioBebida.Text = bebidaPrecio[bebidaT] + " €";
        }

        private void rbtnRefresco_CheckedChanged(object sender, EventArgs e)
        {
            bebidaT = 1; // Inde del refresco
            lblPrecioBebida.Text = bebidaPrecio[bebidaT] + " €";
        }

        private void rbtnVino_CheckedChanged(object sender, EventArgs e)
        {
            bebidaT = 2; // Inde del vino
            lblPrecioBebida.Text = bebidaPrecio[bebidaT] + " €";
        }

        private void rbtnPostre_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxPostre.Items.Clear();
            comboBoxPostre.Items.AddRange(postre);
        }

        private void rbtnCafe_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxCafe.Items.Clear();
            comboBoxCafe.Items.AddRange(cafe);
        }

        private void comboBoxPrimerPlato_SelectedIndexChanged(object sender, EventArgs e)
        {
            primerPlato = comboBoxPrimerPlato.SelectedIndex; // Guardar el índice seleccionado
            lblPrecioPrimerPlato.Text = cremaPrecio[primerPlato] + " €"; // Mostrar el precio del índice seleccionado del array de precios
        }

        private void comboBoxSegundoPlato_SelectedIndexChanged(object sender, EventArgs e)
        {
            segundoPlato = comboBoxSegundoPlato.SelectedIndex;
            lblPrecioSegundoPlato.Text = pastaPrecio[segundoPlato];
        }

        private void btnCalcularCuenta_Click(object sender, EventArgs e)
        {
            // Sumar el subtotal de los precios
            double subtotal = Convert.ToDouble(cremaPrecio[primerPlato]) + Convert.ToDouble(pastaPrecio[segundoPlato]) + Convert.ToDouble(bebidaPrecio[bebidaT]) + Convert.ToDouble(postrePrecio[postreCafe]);
        }

        private void comboBoxCafe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbtnCafe.Checked) // Para evitar que se ejecute si no está seleccionado
            {
                postreCafe = comboBoxCafe.SelectedIndex;
                lblPrecioPostreCafe.Text = cafePrecio[postreCafe] + " €";
            }
        }

        private void comboBoxPostre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbtnPostre.Checked) // Para evitar que se ejecute si no está seleccionado
            {
                postreCafe = comboBoxPostre.SelectedIndex;
                lblPrecioPostreCafe.Text = postrePrecio[postreCafe] + " €";
            }
        }

        public ej9()
        {
            InitializeComponent();
        }
    }
}
