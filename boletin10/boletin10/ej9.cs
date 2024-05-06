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
        // Variables
        string[] crema = { "Champiñones", "Puerros", "Zanahoria" };
        string[,] cremaPrecios = { { "Champiñones", "4" }, { "Puerros", "5" }, { "Zanahoria", "4,75" } };
        string[] ensalada = {"Primavera", "Romana", "César" };
        string[,] ensaladaPrecios = { { "Primavera", "3" }, { "Romana", "4" }, { "César", "4,5" } };
        string[] empanada = { "Pulpo", "Zamburiñas", "Carne", "Choco" };
        string[,] empanadaPrecios = { { "Pulpo", "6" }, { "Zamburiñas", "7" }, { "Carne", "3" }, { "Choco", "3,5" } };
        string[] pescado = { "Merluza a la plancha", "Lenguado", "Besugo", "Bacalao al horno" };
        string[,] pescadoPrecios = { { "Merluza a la plancha", "4,5" }, { "Lenguado", "4,5" }, { "Besugo", "6" }, { "Bacalao al horno", "6" } };
        string[] carne = { "Milanesa", "Chuleta", "San Jacobos", "Solomillo" };
        string[,] carnePrecios = { { "Milanesa", "4,5" }, { "Chuleta", "7,5" }, { "San Jacobos", "4,5" }, { "Solomillo", "8,5" } };
        string[] pasta = { "Spaguetti Bolognesa", "Macarrones carbonara", "Trofie al pesto" };
        string[,] pastaPrecios = { { "Spaguetti Bolognesa", "9" }, { "Macarrones carbonara", "9,5" }, { "Trofie al pesto", "10,5" } };
        string[] postre = { "Fruta/Yogurt", "Brownie Chocolate con helado", "Tarta de Santiago", "Tarta semifría de chocolate y queso" };
        string[,] postrePrecios = { { "Fruta/Yogurt", "1,5" }, { "Brownie Chocolate con helado", "3,5" }, { "Tarta de Santiago", "3,5" }, { "Tarta semifría de chocolate y queso", "3,5" } };
        string[] cafe = { "Con leche", "Cortado", "Solo", "Descafeinado" };
        string[,] cafePrecios = { { "Con leche", "1" }, { "Cortado", "1" }, { "Solo", "1" }, { "Descafeinado", "1" } };

        int primerPlato, segundoPlato, bebida, postreCafe; // Totales

        public ej9()
        {
            InitializeComponent();
        }

        private void comboBoxPrimerPlato_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbtnCrema_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
