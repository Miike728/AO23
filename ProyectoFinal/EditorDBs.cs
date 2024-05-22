using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class EditorDBs : Form
    {
        public EditorDBs()
        {
            InitializeComponent();
        }

        private void comboSelectorDBs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Aquí se selecciona la base de datos a la que se quiere acceder, y se muestra en el DataGridView la tabla (son archivos de txt) que se selecciona

            // Limpiar el DataGridView
            dataGridDBs.Rows.Clear();
            // Seg´un la base de datos seleccionada, se añaden las filas correspondientes (de los txts), en los txt el formato es: Componente, Precio
            switch (comboSelectorDBs.SelectedItem.ToString())
            {
                case "Fuentes Sin certificacion":
                    // Limpiar el DataGridView
                    dataGridDBs.Rows.Clear();
                    // Eliminar columnas anteriores
                    dataGridDBs.Columns.Clear();
                    // Añadir la columna componente y precio
                    dataGridDBs.Columns.Add("Componente", "Componente");
                    dataGridDBs.Columns.Add("Precio", "Precio");
                    // Leer el archivo de texto y añadir las filas al DataGridView
                    string[] fuentesSinCertificacion = System.IO.File.ReadAllLines("SinCertificacion.txt");
                    foreach (string fuente in fuentesSinCertificacion)
                    {
                        string[] fuenteSplit = fuente.Split(',');
                        dataGridDBs.Rows.Add(fuenteSplit[0], fuenteSplit[1]);
                    }
                    break;
                case "Fuentes 80+":
                    // Limpiar el DataGridView
                    dataGridDBs.Rows.Clear();
                    // Eliminar columnas anteriores
                    dataGridDBs.Columns.Clear();
                    // Añadir la columna componente y precio
                    dataGridDBs.Columns.Add("Componente", "Componente");
                    dataGridDBs.Columns.Add("Precio", "Precio");
                    // Leer el archivo de texto y añadir las filas al DataGridView
                    string[] fuentes80Plus = System.IO.File.ReadAllLines("80Plus.txt");
                    foreach (string fuente in fuentes80Plus)
                    {
                        string[] fuenteSplit = fuente.Split(',');
                        dataGridDBs.Rows.Add(fuenteSplit[0], fuenteSplit[1]);
                    }
                    break;
                case "Fuentes 80+ Bronze":
                    // Limpiar el DataGridView
                    dataGridDBs.Rows.Clear();
                    // Eliminar columnas anteriores
                    dataGridDBs.Columns.Clear();
                    // Añadir la columna componente y precio
                    dataGridDBs.Columns.Add("Componente", "Componente");
                    dataGridDBs.Columns.Add("Precio", "Precio");
                    // Leer el archivo de texto y añadir las filas al DataGridView
                    string[] fuentes80PlusBronze = System.IO.File.ReadAllLines("80PlusBronze.txt");
                    foreach (string fuente in fuentes80PlusBronze)
                    {
                        string[] fuenteSplit = fuente.Split(',');
                        dataGridDBs.Rows.Add(fuenteSplit[0], fuenteSplit[1]);
                    }
                    break;
                case "Fuentes 80+ Silver":
                    // Limpiar el DataGridView
                    dataGridDBs.Rows.Clear();
                    // Eliminar columnas anteriores
                    dataGridDBs.Columns.Clear();
                    // Añadir la columna componente y precio
                    dataGridDBs.Columns.Add("Componente", "Componente");
                    dataGridDBs.Columns.Add("Precio", "Precio");
                    // Leer el archivo de texto y añadir las filas al DataGridView
                    string[] fuentes80PlusSilver = System.IO.File.ReadAllLines("80PlusSilver.txt");
                    foreach (string fuente in fuentes80PlusSilver)
                    {
                        string[] fuenteSplit = fuente.Split(',');
                        dataGridDBs.Rows.Add(fuenteSplit[0], fuenteSplit[1]);
                    }
                    break;
                case "Fuentes 80+ Gold":
                    // Limpiar el DataGridView
                    dataGridDBs.Rows.Clear();
                    // Eliminar columnas anteriores
                    dataGridDBs.Columns.Clear();
                    // Añadir la columna componente y precio
                    dataGridDBs.Columns.Add("Componente", "Componente");
                    dataGridDBs.Columns.Add("Precio", "Precio");
                    // Leer el archivo de texto y añadir las filas al DataGridView
                    string[] fuentes80PlusGold = System.IO.File.ReadAllLines("80PlusGold.txt");
                    foreach (string fuente in fuentes80PlusGold)
                    {
                        string[] fuenteSplit = fuente.Split(',');
                        dataGridDBs.Rows.Add(fuenteSplit[0], fuenteSplit[1]);
                    }
                    break;
                case "Fuentes 80+ Platinum":
                    // Limpiar el DataGridView
                    dataGridDBs.Rows.Clear();
                    // Eliminar columnas anteriores
                    dataGridDBs.Columns.Clear();
                    // Añadir la columna componente y precio
                    dataGridDBs.Columns.Add("Componente", "Componente");
                    dataGridDBs.Columns.Add("Precio", "Precio");
                    // Leer el archivo de texto y añadir las filas al DataGridView
                    string[] fuentes80PlusPlatinum = System.IO.File.ReadAllLines("80PlusPlatinum.txt");
                    foreach (string fuente in fuentes80PlusPlatinum)
                    {
                        string[] fuenteSplit = fuente.Split(',');
                        dataGridDBs.Rows.Add(fuenteSplit[0], fuenteSplit[1]);
                    }
                    break;
                case "HHDs":
                    // Limpiar el DataGridView
                    dataGridDBs.Rows.Clear();
                    // Eliminar columnas anteriores
                    dataGridDBs.Columns.Clear();
                    // Añadir la columna componente y precio
                    dataGridDBs.Columns.Add("Componente", "Componente");
                    dataGridDBs.Columns.Add("Precio", "Precio");
                    // Leer el archivo de texto y añadir las filas al DataGridView
                    string[] hhds = System.IO.File.ReadAllLines("HDD.txt");
                    foreach (string hhd in hhds)
                    {
                        string[] hhdSplit = hhd.Split(',');
                        dataGridDBs.Rows.Add(hhdSplit[0], hhdSplit[1]);
                    }
                    break;
                case "SSDs":
                    // Limpiar el DataGridView
                    dataGridDBs.Rows.Clear();
                    // Eliminar columnas anteriores
                    dataGridDBs.Columns.Clear();
                    // Añadir la columna componente y precio
                    dataGridDBs.Columns.Add("Componente", "Componente");
                    dataGridDBs.Columns.Add("Precio", "Precio");
                    // Leer el archivo de texto y añadir las filas al DataGridView
                    string[] ssds = System.IO.File.ReadAllLines("SSD.txt");
                    foreach (string ssd in ssds)
                    {
                        string[] ssdSplit = ssd.Split(',');
                        dataGridDBs.Rows.Add(ssdSplit[0], ssdSplit[1]);
                    }
                    break;
                case "GPUs Nvidia":
                    // Limpiar el DataGridView
                    dataGridDBs.Rows.Clear();
                    // Eliminar columnas anteriores
                    dataGridDBs.Columns.Clear();
                    // Añadir la columna componente y precio
                    dataGridDBs.Columns.Add("Componente", "Componente");
                    dataGridDBs.Columns.Add("Precio", "Precio");
                    // Leer el archivo de texto y añadir las filas al DataGridView
                    string[] gpusNvidia = System.IO.File.ReadAllLines("NVIDIAgpu.txt");
                    foreach (string gpu in gpusNvidia)
                    {
                        string[] gpuSplit = gpu.Split(',');
                        dataGridDBs.Rows.Add(gpuSplit[0], gpuSplit[1]);
                    }
                    break;
                case "GPUs AMD":
                    // Limpiar el DataGridView
                    dataGridDBs.Rows.Clear();
                    // Eliminar columnas anteriores
                    dataGridDBs.Columns.Clear();
                    // Añadir la columna componente y precio
                    dataGridDBs.Columns.Add("Componente", "Componente");
                    dataGridDBs.Columns.Add("Precio", "Precio");
                    // Leer el archivo de texto y añadir las filas al DataGridView
                    string[] gpusAMD = System.IO.File.ReadAllLines("AMDgpu.txt");
                    foreach (string gpu in gpusAMD)
                    {
                        string[] gpuSplit = gpu.Split(',');
                        dataGridDBs.Rows.Add(gpuSplit[0], gpuSplit[1]);
                    }
                    break;
                case "Placas AM3":
                    // Limpiar el DataGridView
                    dataGridDBs.Rows.Clear();
                    // Eliminar columnas anteriores
                    dataGridDBs.Columns.Clear();
                    // Añadir la columna componente y precio
                    dataGridDBs.Columns.Add("Componente", "Componente");
                    dataGridDBs.Columns.Add("Precio", "Precio");
                    // Leer el archivo de texto y añadir las filas al DataGridView
                    string[] placasAM3 = System.IO.File.ReadAllLines("PlacaAM3.txt");
                    foreach (string placa in placasAM3)
                    {
                        string[] placaSplit = placa.Split(',');
                        dataGridDBs.Rows.Add(placaSplit[0], placaSplit[1]);
                    }
                    break;
                case "Placas AM4":
                    // Limpiar el DataGridView
                    dataGridDBs.Rows.Clear();
                    // Eliminar columnas anteriores
                    dataGridDBs.Columns.Clear();
                    // Añadir la columna componente y precio
                    dataGridDBs.Columns.Add("Componente", "Componente");
                    dataGridDBs.Columns.Add("Precio", "Precio");
                    // Leer el archivo de texto y añadir las filas al DataGridView
                    string[] placasAM4 = System.IO.File.ReadAllLines("PlacaAM4.txt");
                    foreach (string placa in placasAM4)
                    {
                        string[] placaSplit = placa.Split(',');
                        dataGridDBs.Rows.Add(placaSplit[0], placaSplit[1]);
                    }
                    break;
                case "Placas AM5":
                    // Limpiar el DataGridView
                    dataGridDBs.Rows.Clear();
                    // Eliminar columnas anteriores
                    dataGridDBs.Columns.Clear();
                    // Añadir la columna componente y precio
                    dataGridDBs.Columns.Add("Componente", "Componente");
                    dataGridDBs.Columns.Add("Precio", "Precio");
                    // Leer el archivo de texto y añadir las filas al DataGridView
                    string[] placasAM5 = System.IO.File.ReadAllLines("PlacaAM5.txt");
                    foreach (string placa in placasAM5)
                    {
                        string[] placaSplit = placa.Split(',');
                        dataGridDBs.Rows.Add(placaSplit[0], placaSplit[1]);
                    }
                    break;
                case "Placas LGA1151":
                    // Limpiar el DataGridView
                    dataGridDBs.Rows.Clear();
                    // Eliminar columnas anteriores
                    dataGridDBs.Columns.Clear();
                    // Añadir la columna componente y precio
                    dataGridDBs.Columns.Add("Componente", "Componente");
                    dataGridDBs.Columns.Add("Precio", "Precio");
                    // Leer el archivo de texto y añadir las filas al DataGridView
                    string[] placasLGA1151 = System.IO.File.ReadAllLines("PlacaLGA1151.txt");
                    foreach (string placa in placasLGA1151)
                    {
                        string[] placaSplit = placa.Split(',');
                        dataGridDBs.Rows.Add(placaSplit[0], placaSplit[1]);
                    }
                    break;
                case "Placas LGA1200":
                    // Limpiar el DataGridView
                    dataGridDBs.Rows.Clear();
                    // Eliminar columnas anteriores
                    dataGridDBs.Columns.Clear();
                    // Añadir la columna componente y precio
                    dataGridDBs.Columns.Add("Componente", "Componente");
                    dataGridDBs.Columns.Add("Precio", "Precio");
                    // Leer el archivo de texto y añadir las filas al DataGridView
                    string[] placasLGA1200 = System.IO.File.ReadAllLines("PlacaLGA1200.txt");
                    foreach (string placa in placasLGA1200)
                    {
                        string[] placaSplit = placa.Split(',');
                        dataGridDBs.Rows.Add(placaSplit[0], placaSplit[1]);
                    }
                    break;
                case "Placas LGA1700":
                    // Limpiar el DataGridView
                    dataGridDBs.Rows.Clear();
                    // Eliminar columnas anteriores
                    dataGridDBs.Columns.Clear();
                    // Añadir la columna componente y precio
                    dataGridDBs.Columns.Add("Componente", "Componente");
                    dataGridDBs.Columns.Add("Precio", "Precio");
                    // Leer el archivo de texto y añadir las filas al DataGridView
                    string[] placasLGA1700 = System.IO.File.ReadAllLines("PlacaLGA1700.txt");
                    foreach (string placa in placasLGA1700)
                    {
                        string[] placaSplit = placa.Split(',');
                        dataGridDBs.Rows.Add(placaSplit[0], placaSplit[1]);
                    }
                    break;
                case "RAM AM3":
                    // Limpiar el DataGridView
                    dataGridDBs.Rows.Clear();
                    // Eliminar columnas anteriores
                    dataGridDBs.Columns.Clear();
                    // Añadir la columna componente y precio
                    dataGridDBs.Columns.Add("Componente", "Componente");
                    dataGridDBs.Columns.Add("Precio", "Precio");
                    // Leer el archivo de texto y añadir las filas al DataGridView
                    string[] ramAM3 = System.IO.File.ReadAllLines("RAM-AM3.txt");
                    foreach (string ram in ramAM3)
                    {
                        string[] ramSplit = ram.Split(',');
                        dataGridDBs.Rows.Add(ramSplit[0], ramSplit[1]);
                    }
                    break;
                case "RAM AM4":
                    // Limpiar el DataGridView
                    dataGridDBs.Rows.Clear();
                    // Eliminar columnas anteriores
                    dataGridDBs.Columns.Clear();
                    // Añadir la columna componente y precio
                    dataGridDBs.Columns.Add("Componente", "Componente");
                    dataGridDBs.Columns.Add("Precio", "Precio");
                    // Leer el archivo de texto y añadir las filas al DataGridView
                    string[] ramAM4 = System.IO.File.ReadAllLines("RAM-AM4.txt");
                    foreach (string ram in ramAM4)
                    {
                        string[] ramSplit = ram.Split(',');
                        dataGridDBs.Rows.Add(ramSplit[0], ramSplit[1]);
                    }
                    break;
                case "RAM AM5":
                    // Limpiar el DataGridView
                    dataGridDBs.Rows.Clear();
                    // Eliminar columnas anteriores
                    dataGridDBs.Columns.Clear();
                    // Añadir la columna componente y precio
                    dataGridDBs.Columns.Add("Componente", "Componente");
                    dataGridDBs.Columns.Add("Precio", "Precio");
                    // Leer el archivo de texto y añadir las filas al DataGridView
                    string[] ramAM5 = System.IO.File.ReadAllLines("RAM-AM5.txt");
                    foreach (string ram in ramAM5)
                    {
                        string[] ramSplit = ram.Split(',');
                        dataGridDBs.Rows.Add(ramSplit[0], ramSplit[1]);
                    }
                    break;
                case "RAM LGA1151":
                    // Limpiar el DataGridView
                    dataGridDBs.Rows.Clear();
                    // Eliminar columnas anteriores
                    dataGridDBs.Columns.Clear();
                    // Añadir la columna componente y precio
                    dataGridDBs.Columns.Add("Componente", "Componente");
                    dataGridDBs.Columns.Add("Precio", "Precio");
                    // Leer el archivo de texto y añadir las filas al DataGridView
                    string[] ramLGA1151 = System.IO.File.ReadAllLines("RAM-LGA1151.txt");
                    foreach (string ram in ramLGA1151)
                    {
                        string[] ramSplit = ram.Split(',');
                        dataGridDBs.Rows.Add(ramSplit[0], ramSplit[1]);
                    }
                    break;
                case "RAM LGA1200":
                    // Limpiar el DataGridView
                    dataGridDBs.Rows.Clear();
                    // Eliminar columnas anteriores
                    dataGridDBs.Columns.Clear();
                    // Añadir la columna componente y precio
                    dataGridDBs.Columns.Add("Componente", "Componente");
                    dataGridDBs.Columns.Add("Precio", "Precio");
                    // Leer el archivo de texto y añadir las filas al DataGridView
                    string[] ramLGA1200 = System.IO.File.ReadAllLines("RAM-LGA1200.txt");
                    foreach (string ram in ramLGA1200)
                    {
                        string[] ramSplit = ram.Split(',');
                        dataGridDBs.Rows.Add(ramSplit[0], ramSplit[1]);
                    }
                    break;
                case "RAM LGA1700":
                    // Limpiar el DataGridView
                    dataGridDBs.Rows.Clear();
                    // Eliminar columnas anteriores
                    dataGridDBs.Columns.Clear();
                    // Añadir la columna componente y precio
                    dataGridDBs.Columns.Add("Componente", "Componente");
                    dataGridDBs.Columns.Add("Precio", "Precio");
                    // Leer el archivo de texto y añadir las filas al DataGridView
                    string[] ramLGA1700 = System.IO.File.ReadAllLines("RAM-LGA1700.txt");
                    foreach (string ram in ramLGA1700)
                    {
                        string[] ramSplit = ram.Split(',');
                        dataGridDBs.Rows.Add(ramSplit[0], ramSplit[1]);
                    }
                    break;
                case "Procesadores AM3":
                    // Limpiar el DataGridView
                    dataGridDBs.Rows.Clear();
                    // Eliminar columnas anteriores
                    dataGridDBs.Columns.Clear();
                    // Añadir la columna componente y precio
                    dataGridDBs.Columns.Add("Componente", "Componente");
                    dataGridDBs.Columns.Add("Precio", "Precio");
                    // Leer el archivo de texto y añadir las filas al DataGridView
                    string[] procesadoresAM3 = System.IO.File.ReadAllLines("ProcesadorAM3.txt");
                    foreach (string procesador in procesadoresAM3)
                    {
                        string[] procesadorSplit = procesador.Split(',');
                        dataGridDBs.Rows.Add(procesadorSplit[0], procesadorSplit[1]);
                    }
                    break;
                case "Procesadores AM4":
                    // Limpiar el DataGridView
                    dataGridDBs.Rows.Clear();
                    // Eliminar columnas anteriores
                    dataGridDBs.Columns.Clear();
                    // Añadir la columna componente y precio
                    dataGridDBs.Columns.Add("Componente", "Componente");
                    dataGridDBs.Columns.Add("Precio", "Precio");
                    // Leer el archivo de texto y añadir las filas al DataGridView
                    string[] procesadoresAM4 = System.IO.File.ReadAllLines("ProcesadorAM4.txt");
                    foreach (string procesador in procesadoresAM4)
                    {
                        string[] procesadorSplit = procesador.Split(',');
                        dataGridDBs.Rows.Add(procesadorSplit[0], procesadorSplit[1]);
                    }
                    break;
                case "Procesadores AM5":
                    // Limpiar el DataGridView
                    dataGridDBs.Rows.Clear();
                    // Eliminar columnas anteriores
                    dataGridDBs.Columns.Clear();
                    // Añadir la columna componente y precio
                    dataGridDBs.Columns.Add("Componente", "Componente");
                    dataGridDBs.Columns.Add("Precio", "Precio");
                    // Leer el archivo de texto y añadir las filas al DataGridView
                    string[] procesadoresAM5 = System.IO.File.ReadAllLines("ProcesadorAM5.txt");
                    foreach (string procesador in procesadoresAM5)
                    {
                        string[] procesadorSplit = procesador.Split(',');
                        dataGridDBs.Rows.Add(procesadorSplit[0], procesadorSplit[1]);
                    }
                    break;
                case "Procesadores LGA1151":
                    // Limpiar el DataGridView
                    dataGridDBs.Rows.Clear();
                    // Eliminar columnas anteriores
                    dataGridDBs.Columns.Clear();
                    // Añadir la columna componente y precio
                    dataGridDBs.Columns.Add("Componente", "Componente");
                    dataGridDBs.Columns.Add("Precio", "Precio");
                    // Leer el archivo de texto y añadir las filas al DataGridView
                    string[] procesadoresLGA1151 = System.IO.File.ReadAllLines("ProcesadorLGA1151.txt");
                    foreach (string procesador in procesadoresLGA1151)
                    {
                        string[] procesadorSplit = procesador.Split(',');
                        dataGridDBs.Rows.Add(procesadorSplit[0], procesadorSplit[1]);
                    }
                    break;
                case "Procesadores LGA1200":
                    // Limpiar el DataGridView
                    dataGridDBs.Rows.Clear();
                    // Eliminar columnas anteriores
                    dataGridDBs.Columns.Clear();
                    // Añadir la columna componente y precio
                    dataGridDBs.Columns.Add("Componente", "Componente");
                    dataGridDBs.Columns.Add("Precio", "Precio");
                    // Leer el archivo de texto y añadir las filas al DataGridView
                    string[] procesadoresLGA1200 = System.IO.File.ReadAllLines("ProcesadorLGA1200.txt");
                    foreach (string procesador in procesadoresLGA1200)
                    {
                        string[] procesadorSplit = procesador.Split(',');
                        dataGridDBs.Rows.Add(procesadorSplit[0], procesadorSplit[1]);
                    }
                    break;
                case "Procesadores LGA1700":
                    // Limpiar el DataGridView
                    dataGridDBs.Rows.Clear();
                    // Eliminar columnas anteriores
                    dataGridDBs.Columns.Clear();
                    // Añadir la columna componente y precio
                    dataGridDBs.Columns.Add("Componente", "Componente");
                    dataGridDBs.Columns.Add("Precio", "Precio");
                    // Leer el archivo de texto y añadir las filas al DataGridView
                    string[] procesadoresLGA1700 = System.IO.File.ReadAllLines("ProcesadorLGA1700.txt");
                    foreach (string procesador in procesadoresLGA1700)
                    {
                        string[] procesadorSplit = procesador.Split(',');
                        dataGridDBs.Rows.Add(procesadorSplit[0], procesadorSplit[1]);
                    }
                    break;
                case "Refrigeraciones aire":
                    // Limpiar el DataGridView
                    dataGridDBs.Rows.Clear();
                    // Eliminar columnas anteriores
                    dataGridDBs.Columns.Clear();
                    // Añadir la columna componente y precio
                    dataGridDBs.Columns.Add("Componente", "Componente");
                    dataGridDBs.Columns.Add("Precio", "Precio");
                    // Leer el archivo de texto y añadir las filas al DataGridView
                    string[] refrigeracionesAire = System.IO.File.ReadAllLines("RefrigeracionAire.txt");
                    foreach (string refrigeracion in refrigeracionesAire)
                    {
                        string[] refrigeracionSplit = refrigeracion.Split(',');
                        dataGridDBs.Rows.Add(refrigeracionSplit[0], refrigeracionSplit[1]);
                    }
                    break;
                case "Refrigeraciones liquidas":
                    // Limpiar el DataGridView
                    dataGridDBs.Rows.Clear();
                    // Eliminar columnas anteriores
                    dataGridDBs.Columns.Clear();
                    // Añadir la columna componente y precio
                    dataGridDBs.Columns.Add("Componente", "Componente");
                    dataGridDBs.Columns.Add("Precio", "Precio");
                    // Leer el archivo de texto y añadir las filas al DataGridView
                    string[] refrigeracionesLiquidas = System.IO.File.ReadAllLines("RefrigeracionLiquida.txt");
                    foreach (string refrigeracion in refrigeracionesLiquidas)
                    {
                        string[] refrigeracionSplit = refrigeracion.Split(',');
                        dataGridDBs.Rows.Add(refrigeracionSplit[0], refrigeracionSplit[1]);
                    }
                    break;
                case "Cajas ATX":
                    // Limpiar el DataGridView
                    dataGridDBs.Rows.Clear();
                    // Eliminar columnas anteriores
                    dataGridDBs.Columns.Clear();
                    // Añadir la columna componente y precio
                    dataGridDBs.Columns.Add("Componente", "Componente");
                    dataGridDBs.Columns.Add("Precio", "Precio");
                    // Leer el archivo de texto y añadir las filas al DataGridView
                    string[] cajasATX = System.IO.File.ReadAllLines("CajaATX.txt");
                    foreach (string caja in cajasATX)
                    {
                        string[] cajaSplit = caja.Split(',');
                        dataGridDBs.Rows.Add(cajaSplit[0], cajaSplit[1]);
                    }
                    break;
                case "Cajas MicroATX":
                    // Limpiar el DataGridView
                    dataGridDBs.Rows.Clear();
                    // Eliminar columnas anteriores
                    dataGridDBs.Columns.Clear();
                    // Añadir la columna componente y precio
                    dataGridDBs.Columns.Add("Componente", "Componente");
                    dataGridDBs.Columns.Add("Precio", "Precio");
                    // Leer el archivo de texto y añadir las filas al DataGridView
                    string[] cajasMicroATX = System.IO.File.ReadAllLines("CajaMicroATX.txt");
                    foreach (string caja in cajasMicroATX)
                    {
                        string[] cajaSplit = caja.Split(',');
                        dataGridDBs.Rows.Add(cajaSplit[0], cajaSplit[1]);
                    }
                    break;
                }
        }


        private void EditorDBs_Load(object sender, EventArgs e)
            {
            // Añadir las bases de datos al ComboBox, las opciones posibles son:
            // Nombre | Archivo
            // Fuentes Sin certificacion | SinCertificacion.txt
            // Fuentes 80+ | 80Plus.txt
            // Fuentes 80+ Bronze | 80PlusBronze.txt
            // Fuentes 80+ Silver | 80PlusSilver.txt
            // Fuentes 80+ Gold | 80PlusGold.txt
            // Fuentes 80+ Platinum | 80PlusPlatinum.txt
            // HHDs | HDD.txt
            // SSDs | SSD.txt
            // GPUs Nvidia | NVIDIAgpu.txt
            // GPUs AMD | AMDgpu.txt
            // Placas AM3 | PlacaAM3.txt
            // Placas AM4 | PlacaAM4.txt
            // Placas AM5 | PlacaAM5.txt
            // Placas LGA1151 | PlacaLGA1151.txt
            // Placas LGA1200 | PlacaLGA1200.txt
            // Placas LGA1700 | PlacaLGA1700.txt
            // RAM AM3 | RAM-AM3.txt
            // RAM AM4 | RAM-AM4.txt
            // RAM AM5 | RAM-AM5.txt
            // RAM LGA1151 | RAM-LGA1151.txt
            // RAM LGA1200 | RAM-LGA1200.txt
            // RAM LGA1700 | RAM-LGA1700.txt
            // Procesadores AM3 | ProcesadorAM3.txt
            // Procesadores AM4 | ProcesadorAM4.txt
            // Procesadores AM5 | ProcesadorAM5.txt
            // Procesadores LGA1151 | ProcesadorLGA1151.txt
            // Procesadores LGA1200 | ProcesadorLGA1200.txt
            // Procesadores LGA1700 | ProcesadorLGA1700.txt
            // Refrigeraciones aire | RefrigeracionAire.txt
            // Refrigeraciones liquidas | RefrigeracionLiquida.txt
            // Cajas ATX | CajaATX.txt
            // Cajas MicroATX | CajaMicroATX.txt

            // Limpiar el ComboBox
            comboSelectorDBs.Items.Clear();
            // Añadir las bases de datos al ComboBox
            comboSelectorDBs.Items.Add("Fuentes Sin certificacion");
            comboSelectorDBs.Items.Add("Fuentes 80+");
            comboSelectorDBs.Items.Add("Fuentes 80+ Bronze");
            comboSelectorDBs.Items.Add("Fuentes 80+ Silver");
            comboSelectorDBs.Items.Add("Fuentes 80+ Gold");
            comboSelectorDBs.Items.Add("Fuentes 80+ Platinum");
            comboSelectorDBs.Items.Add("HHDs");
            comboSelectorDBs.Items.Add("SSDs");
            comboSelectorDBs.Items.Add("GPUs Nvidia");
            comboSelectorDBs.Items.Add("GPUs AMD");
            comboSelectorDBs.Items.Add("Placas AM3");
            comboSelectorDBs.Items.Add("Placas AM4");
            comboSelectorDBs.Items.Add("Placas AM5");
            comboSelectorDBs.Items.Add("Placas LGA1151");
            comboSelectorDBs.Items.Add("Placas LGA1200");
            comboSelectorDBs.Items.Add("Placas LGA1700");
            comboSelectorDBs.Items.Add("RAM AM3");
            comboSelectorDBs.Items.Add("RAM AM4");
            comboSelectorDBs.Items.Add("RAM AM5");
            comboSelectorDBs.Items.Add("RAM LGA1151");
            comboSelectorDBs.Items.Add("RAM LGA1200");
            comboSelectorDBs.Items.Add("RAM LGA1700");
            comboSelectorDBs.Items.Add("Procesadores AM3");
            comboSelectorDBs.Items.Add("Procesadores AM4");
            comboSelectorDBs.Items.Add("Procesadores AM5");
            comboSelectorDBs.Items.Add("Procesadores LGA1151");
            comboSelectorDBs.Items.Add("Procesadores LGA1200");
            comboSelectorDBs.Items.Add("Procesadores LGA1700");
            comboSelectorDBs.Items.Add("Refrigeraciones aire");
            comboSelectorDBs.Items.Add("Refrigeraciones liquidas");
            comboSelectorDBs.Items.Add("Cajas ATX");
            comboSelectorDBs.Items.Add("Cajas MicroATX");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Guardar los cambios 
        }
    }
}
