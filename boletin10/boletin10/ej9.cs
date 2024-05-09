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
        double[] cremaPrecio = { 4, 5, 4,75 };
        string[] ensalada = {"Primavera", "Romana", "César" };
        double[] ensaladaPrecio = { 3, 4, 4,5 };
        string[] empanada = { "Pulpo", "Zamburiñas", "Carne", "Choco" };
        double[] empanadaPrecio = { 6, 7, 3, 3,5 };
        string[] pescado = { "Merluza a la plancha", "Lenguado", "Besugo", "Bacalao al horno" };
        double[] pescadoPrecio = { 4,5, 4,5, 6, 6 };
        string[] carne = { "Milanesa", "Chuleta", "San Jacobos", "Solomillo" };
        double[] carnePrecio = { 4,5, 7,5, 4,5, 8,5 };
        string[] pasta = { "Spaguetti Bolognesa", "Macarrones carbonara", "Trofie al pesto" };
        double[] pastaPrecio = { 9, 9,5, 10,5 };
        string[] postre = { "Fruta/Yogurt", "Brownie Chocolate con helado", "Tarta de Santiago", "Tarta semifría de chocolate y queso" };
        double[] postrePrecio = { 1,5, 3,5, 3,5, 3,5 };
        string[] cafe = { "Con leche", "Cortado", "Solo", "Descafeinado" };
        double[] cafePrecio = { 1, 1, 1, 1 };
        string[] bebida = { "Agua", "Refresco", "Vino" };
        double[] bebidaPrecio = { 1, 1,5, 1,5 }; // No hay precios en el boletin

        int primerPlato = 0, segundoPlato = 0, bebidaT = 0, postreCafe = 0; // Totales
        double precioCrema = 0, precioEnsalada = 0, precioEmpanada = 0, precioPescado = 0, precioCarne = 0, precioPasta = 0, precioPostre = 0, precioCafe = 0, precioBebida = 0; // Precios
        double total; // Total

        private void ej9_Load(object sender, EventArgs e)
        {
            // Cargar imagenes desde resources
            pictureBoxPostreCafe.Image = Properties.Resources.donut;
            pictureBoxPrimerPlato.Image = Properties.Resources.ensalada;
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

        private void btnCalcularCambio_Click(object sender, EventArgs e)
        {
            if (txtEntregadoCliente.Text == "") // Si no se ha introducido el dinero entregado
            {
                MessageBox.Show("Introduce el dinero entregado por el cliente"); // Mostrar error
            }
            else
            {
                double cambio = Convert.ToDouble(txtEntregadoCliente.Text) - Convert.ToDouble(total); // Calcular el cambio
                MessageBox.Show("Cambio: " + cambio + " €"); // Mostrar el cambio
            }
        }

        private void rbtnAgua_CheckedChanged(object sender, EventArgs e)
        {
            bebidaT = 0; // Index del agua
            lblPrecioBebida.Text = bebidaPrecio[bebidaT] + " €";

            precioBebida = bebidaPrecio[bebidaT];
        }

        private void rbtnRefresco_CheckedChanged(object sender, EventArgs e)
        {
            bebidaT = 1; // Index del refresco
            lblPrecioBebida.Text = bebidaPrecio[bebidaT] + " €";

            precioBebida = bebidaPrecio[bebidaT];
        }

        private void rbtnVino_CheckedChanged(object sender, EventArgs e)
        {
            bebidaT = 2; // Index del vino
            lblPrecioBebida.Text = bebidaPrecio[bebidaT] + " €";

            precioBebida = bebidaPrecio[bebidaT];
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
            // Si está seleccionado el radiobutton de crema
            if (rbtnCrema.Checked)
            {
                primerPlato = comboBoxPrimerPlato.SelectedIndex; // Guardar el índice seleccionado
                lblPrecioPrimerPlato.Text = cremaPrecio[primerPlato] + " €"; // Mostrar el precio del índice seleccionado del array de precios
                precioCrema = cremaPrecio[primerPlato]; // Guardar el precio en la variable

            }
            // Si está seleccionado el radiobutton de ensalada
            if (rbtnEnsalada.Checked)
            {
                primerPlato = comboBoxPrimerPlato.SelectedIndex;
                lblPrecioPrimerPlato.Text = ensaladaPrecio[primerPlato] + " €";

                precioEnsalada = ensaladaPrecio[primerPlato];
            }
            // Si está seleccionado el radiobutton de empanada
            if (rbtnEmpanada.Checked)
            {
                primerPlato = comboBoxPrimerPlato.SelectedIndex;
                lblPrecioPrimerPlato.Text = empanadaPrecio[primerPlato] + " €";

                precioEmpanada = empanadaPrecio[primerPlato];
            }
        }

        private void comboBoxSegundoPlato_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si está seleccionado el radiobutton de pescado
            if (rbtnPescado.Checked)
            {
                segundoPlato = comboBoxSegundoPlato.SelectedIndex;
                lblPrecioSegundoPlato.Text = pescadoPrecio[segundoPlato] + " €";

                precioPescado = pescadoPrecio[segundoPlato];
            }
            // Si está seleccionado el radiobutton de carne
            if (rbtnCarne.Checked)
            {
                segundoPlato = comboBoxSegundoPlato.SelectedIndex;
                lblPrecioSegundoPlato.Text = carnePrecio[segundoPlato] + " €";

                precioCarne = carnePrecio[segundoPlato];
            }
            // Si está seleccionado el radiobutton de pasta
            if (rbtnPasta.Checked)
            {
                segundoPlato = comboBoxSegundoPlato.SelectedIndex;
                lblPrecioSegundoPlato.Text = pastaPrecio[segundoPlato] + " €";

                precioPasta = pastaPrecio[segundoPlato];
            }

        }

        private void btnCalcularCuenta_Click(object sender, EventArgs e)
        {
            // Sumar el subtotal de las variables de los platos
            double subtotal = precioCrema + precioEnsalada + precioEmpanada + precioPescado + precioCarne + precioPasta + precioPostre + precioCafe + precioBebida;
            // APlicar el iva del 11%
            double iva = subtotal * 0.11;
            // Sumar el total
            total = subtotal + iva;

            // Mostrar message box con subtotal, iva y total
            MessageBox.Show("Subtotal: " + subtotal + " €\nIVA: " + iva + " €\nTotal: " + total + " €");
            // Mostrar parte del cambio
            lblEntregadoCliente.Visible = true;
            txtEntregadoCliente.Visible = true;
            btnCalcularCambio.Visible = true;
            txtEntregadoCliente.Focus(); // Poner el foco en el textbox
        }

        private void comboBoxCafe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbtnCafe.Checked) // Para evitar que se ejecute si no está seleccionado
            {
                postreCafe = comboBoxCafe.SelectedIndex;
                lblPrecioPostreCafe.Text = cafePrecio[postreCafe] + " €";

                precioCafe = cafePrecio[postreCafe];
            }
        }

        private void comboBoxPostre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbtnPostre.Checked) // Para evitar que se ejecute si no está seleccionado
            {
                postreCafe = comboBoxPostre.SelectedIndex;
                lblPrecioPostreCafe.Text = postrePrecio[postreCafe] + " €";

                precioPostre = postrePrecio[postreCafe];
            }
        }

        public ej9()
        {
            InitializeComponent();
        }
    }
}
