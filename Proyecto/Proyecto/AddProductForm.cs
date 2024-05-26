using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proyecto
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void rbtnOrdenador_CheckedChanged(object sender, EventArgs e)
        {
            // Mostrar groupDatosOrdenador y ocultar groupDatosMovil
            groupDatosOrdenador.Visible = true;
            groupDatosMovil.Visible = false;
        }

        private void rbtnMovil_CheckedChanged(object sender, EventArgs e)
        {
            // Mostrar groupDatosMovil y ocultar groupDatosOrdenador
            groupDatosMovil.Visible = true;
            groupDatosOrdenador.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Variables
            bool camposRellenos = false;
            bool codigoRepetido = false;

            // Funcion guardar
            // Si está seleccionado rbtnOrdenador
            if (rbtnOrdenador.Checked)
            {
                // Comprobar campos rellenos
                if (txtCodigoPC.Text == "" || txtMarcaPC.Text == "" || txtGPUPC.Text == "" || txtRAMPC.Text == "" || txtAlmacenamientoPC.Text == "" || txtProcesadorPC.Text == "" || txtPrecioPC.Text == "")
                {
                    MessageBox.Show("Por favor, rellene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                } // Si está todo bien, marcar camposRellenos como true
                else
                {
                    camposRellenos = true;
                }
                // Comprobar que en ningun campo haya un ;
                if (txtCodigoPC.Text.Contains(";") || txtMarcaPC.Text.Contains(";") || txtGPUPC.Text.Contains(";") || txtRAMPC.Text.Contains(";") || txtAlmacenamientoPC.Text.Contains(";") || txtProcesadorPC.Text.Contains(";") || txtPrecioPC.Text.Contains(";"))
                {
                    MessageBox.Show("No se permiten ; en los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Comprobar si el codigo ya existe
                if (File.Exists("Ordenadores.txt"))
                {
                    StreamReader sr = new StreamReader("Ordenadores.txt");
                    // Recorrer el archivo buscando el codigo antes del primer ;
                    while (!sr.EndOfStream)
                    {
                        string linea = sr.ReadLine();
                        string[] campos = linea.Split(';');
                        if (campos[0] == txtCodigoPC.Text)
                        {
                            codigoRepetido = true;
                            break;
                        }
                    }
                    sr.Close();
                }
                // Si el codigo ya existe, mostrar mensaje de error
                if (codigoRepetido)
                {
                    MessageBox.Show("El código introducido ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Si los campos están rellenos y el codigo no existe, guardar en el archivo
                if (camposRellenos && !codigoRepetido)
                {
                    // Si no hay imagen, mostrar mensaje preguntando si guardar sin imagen o no
                    if (pictureBox1.Image == null)
                    {
                        DialogResult result = MessageBox.Show("¿Desea guardar el producto sin imagen?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.No) // Si elige no, no guardar
                        {
                            return;
                        } // Si elige si, guardar
                        else
                        {
                            StreamWriter sw = new StreamWriter("Ordenadores.txt", true);
                            sw.WriteLine(txtCodigoPC.Text + ";" + txtMarcaPC.Text + ";" + txtGPUPC.Text + ";" + txtRAMPC.Text + ";" + txtAlmacenamientoPC.Text + ";" + txtProcesadorPC.Text + ";" + txtPrecioPC.Text);
                            sw.Close();
                            MessageBox.Show("Ordenador guardado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiarCampos();
                            // reiniciar variables
                            camposRellenos = false;
                            codigoRepetido = false;
                            return;
                        }
                    }
                    else
                    {
                        StreamWriter sw = new StreamWriter("Ordenadores.txt", true);
                        sw.WriteLine(txtCodigoPC.Text + ";" + txtMarcaPC.Text + ";" + txtGPUPC.Text + ";" + txtRAMPC.Text + ";" + txtAlmacenamientoPC.Text + ";" + txtProcesadorPC.Text + ";" + txtPrecioPC.Text);
                        sw.Close();
                        // Guardar imagen en la carpeta ImagenesOrdenadores con el codigo como nombre
                        // Crear carpeta si no existe
                        if (!Directory.Exists("ImagenesOrdenadores"))
                        {
                            Directory.CreateDirectory("ImagenesOrdenadores");
                        }
                        // Guardar conservando la extension jpg o png
                        string extension = Path.GetExtension(ofd.FileName);
                        pictureBox1.Image.Save("ImagenesOrdenadores\\" + txtCodigoPC.Text + extension);
                        MessageBox.Show("Ordenador guardado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarCampos();
                        // reiniciar variables
                        camposRellenos = false;
                        codigoRepetido = false;
                        return;
                    }
                }
            }
            // Si está seleccionado rbtnMovil
            else if (rbtnMovil.Checked)
            {
                // Comprobar campos rellenos
                if (txtCodigoMovil.Text == "" || txtMarcaMovil.Text == "" || txtModeloMovil.Text == "" || txtRAMMovil.Text == "" || txtAlmacenamientoMovil.Text == "" || txtCamaraMovil.Text == "" || txtProcesadorMovil.Text == "" || txtPrecioMovil.Text == "")
                {
                    MessageBox.Show("Por favor, rellene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                } // Si está todo bien, marcar camposRellenos como true
                else
                {
                    camposRellenos = true;
                }
                // Comprobar que en ningun campo haya un ;
                if (txtCodigoMovil.Text.Contains(";") || txtMarcaMovil.Text.Contains(";") || txtModeloMovil.Text.Contains(";") || txtRAMMovil.Text.Contains(";") || txtAlmacenamientoMovil.Text.Contains(";") || txtCamaraMovil.Text.Contains(";") || txtProcesadorMovil.Text.Contains(";") || txtPrecioMovil.Text.Contains(";"))
                {
                    MessageBox.Show("No se permiten ; en los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Comprobar si el codigo ya existe
                if (File.Exists("Moviles.txt"))
                {
                    StreamReader sr = new StreamReader("Moviles.txt");
                    // Recorrer el archivo buscando el codigo antes del primer ;
                    while (!sr.EndOfStream)
                    {
                        string linea = sr.ReadLine();
                        string[] campos = linea.Split(';');
                        if (campos[0] == txtCodigoMovil.Text)
                        {
                            codigoRepetido = true;
                            break;
                        }
                    }
                    sr.Close();
                }
                // Si el codigo ya existe, mostrar mensaje de error
                if (codigoRepetido)
                {
                    MessageBox.Show("El código introducido ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Si los campos están rellenos y el codigo no existe, guardar en el archivo
                if (camposRellenos && !codigoRepetido)
                {
                    // Si no hay imagen, mostrar mensaje preguntando si guardar sin imagen o no
                    if (pictureBox1.Image == null)
                    {
                        DialogResult result = MessageBox.Show("¿Desea guardar el producto sin imagen?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.No) // Si elige no, no guardar
                        {
                            return;
                        } // Si elige si, guardar
                        else
                        {
                            StreamWriter sw = new StreamWriter("Moviles.txt", true);
                            sw.WriteLine(txtCodigoMovil.Text + ";" + txtMarcaMovil.Text + ";" + txtModeloMovil.Text + ";" + txtRAMMovil.Text + ";" + txtAlmacenamientoMovil.Text + ";" + txtCamaraMovil.Text + ";" + txtProcesadorMovil.Text + ";" + txtPrecioMovil.Text);
                            sw.Close();
                            MessageBox.Show("Móvil guardado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiarCampos();
                            // reiniciar variables
                            camposRellenos = false;
                            codigoRepetido = false;
                            return;
                        }
                    }
                    else
                    {
                        StreamWriter sw = new StreamWriter("Moviles.txt", true);
                        sw.WriteLine(txtCodigoMovil.Text + ";" + txtMarcaMovil.Text + ";" + txtModeloMovil.Text + ";" + txtRAMMovil.Text + ";" + txtAlmacenamientoMovil.Text + ";" + txtCamaraMovil.Text + ";" + txtProcesadorMovil.Text + ";" + txtPrecioMovil.Text);
                        sw.Close();
                        // Guardar imagen en la carpeta ImagenesMoviles con el codigo como nombre
                        // Crear carpeta si no existe
                        if (!Directory.Exists("ImagenesMoviles"))
                        {
                            Directory.CreateDirectory("ImagenesMoviles");
                        }
                        // Guardar conservando la extension jpg o png
                        string extension = Path.GetExtension(ofd.FileName);
                        pictureBox1.Image.Save("ImagenesMoviles\\" + txtCodigoMovil.Text + extension);
                        MessageBox.Show("Móvil guardado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarCampos();
                        // reiniciar variables
                        camposRellenos = false;
                        codigoRepetido = false;
                        return; 
                    }
                }
            }
        }

        // Funcion limpiar campos de los dos grupos
        private void limpiarCampos()
        {
            txtCodigoPC.Text = "";
            txtMarcaPC.Text = "";
            txtGPUPC.Text = "";
            txtRAMPC.Text = "";
            txtAlmacenamientoPC.Text = "";
            txtProcesadorPC.Text = "";
            txtPrecioPC.Text = "";
            txtCodigoMovil.Text = "";
            txtMarcaMovil.Text = "";
            txtModeloMovil.Text = "";
            txtRAMMovil.Text = "";
            txtAlmacenamientoMovil.Text = "";
            txtCamaraMovil.Text = "";
            txtProcesadorMovil.Text = "";
            txtPrecioMovil.Text = "";
            pictureBox1.Image = null;
            lblNingunaImagenCargada.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Limpiar campos
            limpiarCampos();
            // Cerrar formulario
            this.Close();
        }

        public static OpenFileDialog ofd = new OpenFileDialog(); // Crear cuadro de dialogo para seleccionar imagen

        private void btnImagenPC_Click(object sender, EventArgs e)
        {
            // Abrir cuadro de dialogo para seleccionar imagen
            ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Mostrar imagen seleccionada en pictureBox
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
            // Si se seleccionó una imagen, esconder el lbl
            if (pictureBox1.Image != null)
            {
                lblNingunaImagenCargada.Visible = false;
            }
        }

        private void btnImagenMovil_Click(object sender, EventArgs e)
        {
            // Abrir cuadro de dialogo para seleccionar imagen
            ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Mostrar imagen seleccionada en pictureBox
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
            // Si se seleccionó una imagen, esconder el lbl
            if (pictureBox1.Image != null)
            {
                lblNingunaImagenCargada.Visible = false;
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
