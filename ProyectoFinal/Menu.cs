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

namespace ProyectoFinal
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // Buscador y configurador de componentes de PC
            // Crear archivo Sockets.txt y añadir datos si no existe el archivo
            if (!File.Exists("Sockets.txt"))
            {
                StreamWriter sockets = new StreamWriter("Sockets.txt");
                sockets.WriteLine("AM3");
                sockets.WriteLine("AM4");
                sockets.WriteLine("AM5");
                sockets.WriteLine("LGA1200");
                sockets.WriteLine("LGA1151");
                sockets.WriteLine("LGA1700");
                sockets.Close();
            }
            // Archivo Procesadores-AM3.txt con precio
            if (!File.Exists("Procesadores-AM3.txt"))
            {
                StreamWriter procesadoresAM3 = new StreamWriter("Procesadores-AM3.txt");
                procesadoresAM3.WriteLine("AMD FX-6300, 50,00€");
                procesadoresAM3.WriteLine("AMD FX-8350, 70,00€");
                procesadoresAM3.WriteLine("AMD FX-9590, 100,00€");
                procesadoresAM3.Close();
            }
            // Archivo Procesadores-AM4.txt con precio
            if (!File.Exists("Procesadores-AM4.txt"))
            {
                StreamWriter procesadoresAM4 = new StreamWriter("Procesadores-AM4.txt");
                procesadoresAM4.WriteLine("AMD Ryzen 3 1200, 50,00€");
                procesadoresAM4.WriteLine("AMD Ryzen 5 1600, 70,00€");
                procesadoresAM4.WriteLine("AMD Ryzen 7 1800X, 100,00€");
                procesadoresAM4.Close();
            }
            // Archivo Procesadores-AM5.txt con precio
            if (!File.Exists("Procesadores-AM5.txt"))
            {
                StreamWriter procesadoresAM5 = new StreamWriter("Procesadores-AM5.txt");
                procesadoresAM5.WriteLine("AMD Ryzen 3 2200G, 50,00€");
                procesadoresAM5.WriteLine("AMD Ryzen 5 2600, 70,00€");
                procesadoresAM5.WriteLine("AMD Ryzen 7 2700X, 100,00€");
                procesadoresAM5.Close();
            }
            // Archivo Procesadores-LGA1200.txt con precio
            if (!File.Exists("Procesadores-LGA1200.txt"))
            {
                StreamWriter procesadoresLGA1200 = new StreamWriter("Procesadores-LGA1200.txt");
                procesadoresLGA1200.WriteLine("Intel Core i3-10100, 50,00€");
                procesadoresLGA1200.WriteLine("Intel Core i5-10400, 70,00€");
                procesadoresLGA1200.WriteLine("Intel Core i7-10700, 100,00€");
                procesadoresLGA1200.Close();
            }
            // Archivo Procesadores-LGA1151.txt con precio
            if (!File.Exists("Procesadores-LGA1151.txt"))
            {
                StreamWriter procesadoresLGA1151 = new StreamWriter("Procesadores-LGA1151.txt");
                procesadoresLGA1151.WriteLine("Intel Core i3-6100, 50,00€");
                procesadoresLGA1151.WriteLine("Intel Core i5-6600, 70,00€");
                procesadoresLGA1151.WriteLine("Intel Core i7-6700, 100,00€");
                procesadoresLGA1151.Close();
            }
            // Archivo Procesadores-LGA1700.txt con precio
            if (!File.Exists("Procesadores-LGA1700.txt"))
            {
                StreamWriter procesadoresLGA1700 = new StreamWriter("Procesadores-LGA1700.txt");
                procesadoresLGA1700.WriteLine("Intel Core i3-12100, 50,00€");
                procesadoresLGA1700.WriteLine("Intel Core i5-12400, 70,00€");
                procesadoresLGA1700.WriteLine("Intel Core i7-12700, 100,00€");
                procesadoresLGA1700.Close();
            }
            // Archivo RAM-AM3.txt
            if (!File.Exists("RAM-AM3.txt"))
            {
                StreamWriter ramAM3 = new StreamWriter("RAM-AM3.txt");
                ramAM3.WriteLine("DDR3");
                ramAM3.Close();
            }
            // Archivo Procesadores-AM3.txt 
            // Archivo RAM-AM4.txt
            if (!File.Exists("RAM-AM4.txt"))
            {
                StreamWriter ramAM4 = new StreamWriter("RAM-AM4.txt");
                ramAM4.WriteLine("DDR4");
                ramAM4.Close();
            }
            // Archivo RAM-AM5.txt
            if (!File.Exists("RAM-AM5.txt"))
            {
                StreamWriter ramAM5 = new StreamWriter("RAM-AM5.txt");
                ramAM5.WriteLine("DDR5");
                ramAM5.Close();
            }
            // Archivo RAM-LGA1200.txt
            if (!File.Exists("RAM-LGA1200.txt"))
            {
                StreamWriter ramLGA1200 = new StreamWriter("RAM-LGA1200.txt");
                ramLGA1200.WriteLine("DDR4");
                ramLGA1200.Close();
            }
            // Archivo RAM-LGA1151.txt
            if (!File.Exists("RAM-LGA1151.txt"))
            {
                StreamWriter ramLGA1151 = new StreamWriter("RAM-LGA1151.txt");
                ramLGA1151.WriteLine("DDR4");
                ramLGA1151.Close();
            }
            // Archivo RAM-LGA1700.txt
            if (!File.Exists("RAM-LGA1700.txt"))
            {
                StreamWriter ramLGA1700 = new StreamWriter("RAM-LGA1700.txt");
                ramLGA1700.WriteLine("DDR5");
                ramLGA1700.Close();
            }
            // Archivo TiposDDR3.txt
            if (!File.Exists("TiposDDR3.txt"))
            {
                StreamWriter tiposDDR3 = new StreamWriter("TiposDDR3.txt");
                tiposDDR3.WriteLine("1333 MHz");
                tiposDDR3.WriteLine("1600 MHz");
                tiposDDR3.WriteLine("1866 MHz");
                tiposDDR3.WriteLine("2133 MHz");
                tiposDDR3.WriteLine("2400 MHz");
                tiposDDR3.WriteLine("2666 MHz");
                tiposDDR3.WriteLine("3000 MHz");
                tiposDDR3.Close();
            }
            // Archivo TiposDDR4.txt
            if (!File.Exists("TiposDDR4.txt"))
            {
                StreamWriter tiposDDR4 = new StreamWriter("TiposDDR4.txt");
                tiposDDR4.WriteLine("2400 MHz");
                tiposDDR4.WriteLine("2666 MHz");
                tiposDDR4.WriteLine("3000 MHz");
                tiposDDR4.WriteLine("3200 MHz");
                tiposDDR4.WriteLine("3466 MHz");
                tiposDDR4.WriteLine("3600 MHz");
                tiposDDR4.WriteLine("3800 MHz");
                tiposDDR4.WriteLine("4000 MHz");
                tiposDDR4.WriteLine("4266 MHz");
                tiposDDR4.WriteLine("4400 MHz");
                tiposDDR4.WriteLine("4600 MHz");
                tiposDDR4.WriteLine("4800 MHz");
                tiposDDR4.Close();
            }
            // Archivo TiposDDR5.txt
            if (!File.Exists("TiposDDR5.txt"))
            {
                StreamWriter tiposDDR5 = new StreamWriter("TiposDDR5.txt");
                tiposDDR5.WriteLine("4800 MHz");
                tiposDDR5.WriteLine("5000 MHz");
                tiposDDR5.WriteLine("5200 MHz");
                tiposDDR5.WriteLine("5400 MHz");
                tiposDDR5.WriteLine("5600 MHz");
                tiposDDR5.WriteLine("5800 MHz");
                tiposDDR5.WriteLine("6000 MHz");
                tiposDDR5.WriteLine("6200 MHz");
                tiposDDR5.WriteLine("6400 MHz");
                tiposDDR5.WriteLine("6600 MHz");
                tiposDDR5.WriteLine("6800 MHz");
                tiposDDR5.WriteLine("7000 MHz");
                tiposDDR5.Close();
            }
            // Archivo TamanosRAM-DDR3.txt
            if (!File.Exists("TamanosRAM-DDR3.txt"))
            {
                StreamWriter tamanosRAMDDR3 = new StreamWriter("TamanosRAM-DDR3.txt");
                tamanosRAMDDR3.WriteLine("1GB, 1,00€");
                tamanosRAMDDR3.WriteLine("2GB, 2,00€");
                tamanosRAMDDR3.WriteLine("4GB, 3,00€");
                tamanosRAMDDR3.WriteLine("8GB, 5,00€");
                tamanosRAMDDR3.Close();
            }
            // Archivo TamanosRAM-DDR4.txt
            if (!File.Exists("TamanosRAM-DDR4.txt"))
            {
                StreamWriter tamanosRAMDDR4 = new StreamWriter("TamanosRAM-DDR4.txt");
                tamanosRAMDDR4.WriteLine("4GB, 3,00€");
                tamanosRAMDDR4.WriteLine("8GB, 5,00€");
                tamanosRAMDDR4.WriteLine("16GB, 8,00€");
                tamanosRAMDDR4.WriteLine("32GB, 12,00€");
                tamanosRAMDDR4.WriteLine("64GB, 20,00€");
                tamanosRAMDDR4.Close();
            }
            // Archivo TamanosRAM-DDR5.txt
            if (!File.Exists("TamanosRAM-DDR5.txt"))
            {
                StreamWriter tamanosRAMDDR5 = new StreamWriter("TamanosRAM-DDR5.txt");
                tamanosRAMDDR5.WriteLine("8GB, 5,00€");
                tamanosRAMDDR5.WriteLine("16GB, 8,00€");
                tamanosRAMDDR5.WriteLine("32GB, 12,00€");
                tamanosRAMDDR5.WriteLine("64GB, 20,00€");
                tamanosRAMDDR5.WriteLine("128GB, 30,00€");
                tamanosRAMDDR5.Close();
            }
            // Archivo GPU.txt
            if (!File.Exists("GPU.txt"))
            {
                StreamWriter gpu = new StreamWriter("GPU.txt");
                gpu.WriteLine("NVIDIA");
                gpu.WriteLine("AMD");
                gpu.Close();
            }
            // Archivo NVIDIAgpu.txt
            if (!File.Exists("NVIDIAgpu.txt"))
            {
                StreamWriter nvidia = new StreamWriter("NVIDIA.txt");
                nvidia.WriteLine("GTX 1080, 100,00€");
                nvidia.WriteLine("GTX 1650, 150,00€");
                nvidia.WriteLine("RTX 2080, 200,00€");
                nvidia.WriteLine("RTX 3080Ti, 250,00€");
                nvidia.WriteLine("RTX 3090, 300,00€");
                nvidia.WriteLine("Quadro RTX 8000, 400,00€");
                nvidia.Close();
            }
            // Archivo AMDgpu.txt
            if (!File.Exists("AMDgpu.txt"))
            {
                StreamWriter amd = new StreamWriter("AMD.txt");
                amd.WriteLine("RX 580, 100,00€");
                amd.WriteLine("RX 5600XT, 150,00€");
                amd.WriteLine("RX 6700XT, 200,00€");
                amd.WriteLine("RX 6800XT, 250,00€");
                amd.WriteLine("RX 6900XT, 300,00€");
                amd.WriteLine("Radeon Pro VII, 400,00€");
                amd.Close();
            }
            // Archivo Almacenamiento.txt
            if (!File.Exists("Almacenamiento.txt"))
            {
                StreamWriter almacenamiento = new StreamWriter("Almacenamiento.txt");
                almacenamiento.WriteLine("HDD");
                almacenamiento.WriteLine("SSD");
                almacenamiento.Close();
            }
            // Archivo HDD.txt
            if (!File.Exists("HDD.txt"))
            {
                StreamWriter hdd = new StreamWriter("HDD.txt");
                hdd.WriteLine("500GB, 20,00€");
                hdd.WriteLine("1TB, 30,00€");
                hdd.WriteLine("2TB, 40,00€");
                hdd.WriteLine("4TB, 60,00€");
                hdd.WriteLine("8TB, 100,00€");
                hdd.Close();
            }
            // Archivo SSD.txt
            if (!File.Exists("SSD.txt"))
            {
                StreamWriter ssd = new StreamWriter("SSD.txt");
                ssd.WriteLine("120GB, 20,00€");
                ssd.WriteLine("240GB, 30,00€");
                ssd.WriteLine("480GB, 40,00€");
                ssd.WriteLine("1TB, 60,00€");
                ssd.WriteLine("2TB, 100,00€");
                ssd.Close();
            }
            // Archivo PSU.txt
            if (!File.Exists("PSU.txt"))
            {
                StreamWriter psu = new StreamWriter("PSU.txt");
                psu.WriteLine("Sin certificación");
                psu.WriteLine("80+");
                psu.WriteLine("80+ Bronze");
                psu.WriteLine("80+ Silver");
                psu.WriteLine("80+ Gold");
                psu.WriteLine("80+ Platinum");
                psu.Close();
            }
            // Archivo SinCertificacion.txt
            if (!File.Exists("SinCertificacion.txt"))
            {
                StreamWriter sinCertificacion = new StreamWriter("SinCertificacion.txt");
                sinCertificacion.WriteLine("500W, 20,00€");
                sinCertificacion.WriteLine("600W, 30,00€");
                sinCertificacion.WriteLine("700W, 40,00€");
                sinCertificacion.WriteLine("800W, 60,00€");
                sinCertificacion.WriteLine("1000W, 100,00€");
                sinCertificacion.Close();
            }
            // Archivo 80Plus.txt
            if (!File.Exists("80Plus.txt"))
            {
                StreamWriter plus = new StreamWriter("80Plus.txt");
                plus.WriteLine("500W, 30,00€");
                plus.WriteLine("600W, 40,00€");
                plus.WriteLine("700W, 50,00€");
                plus.WriteLine("800W, 70,00€");
                plus.WriteLine("1000W, 120,00€");
                plus.Close();
            }
            // Archivo 80PlusBronze.txt
            if (!File.Exists("80PlusBronze.txt"))
            {
                StreamWriter bronze = new StreamWriter("80PlusBronze.txt");
                bronze.WriteLine("500W, 40,00€");
                bronze.WriteLine("600W, 50,00€");
                bronze.WriteLine("700W, 60,00€");
                bronze.WriteLine("800W, 80,00€");
                bronze.WriteLine("1000W, 130,00€");
                bronze.Close();
            }
            // Archivo 80PlusSilver.txt
            if (!File.Exists("80PlusSilver.txt"))
            {
                StreamWriter silver = new StreamWriter("80PlusSilver.txt");
                silver.WriteLine("500W, 50,00€");
                silver.WriteLine("600W, 60,00€");
                silver.WriteLine("700W, 70,00€");
                silver.WriteLine("800W, 90,00€");
                silver.WriteLine("1000W, 140,00€");
                silver.Close();
            }
            // Archivo 80PlusGold.txt
            if (!File.Exists("80PlusGold.txt"))
            {
                StreamWriter gold = new StreamWriter("80PlusGold.txt");
                gold.WriteLine("500W, 60,00€");
                gold.WriteLine("600W, 70,00€");
                gold.WriteLine("700W, 80,00€");
                gold.WriteLine("800W, 100,00€");
                gold.WriteLine("1000W, 150,00€");
                gold.Close();
            }
            // Archivo 80PlusPlatinum.txt
            if (!File.Exists("80PlusPlatinum.txt"))
            {
                StreamWriter platinum = new StreamWriter("80PlusPlatinum.txt");
                platinum.WriteLine("500W, 70,00€");
                platinum.WriteLine("600W, 80,00€");
                platinum.WriteLine("700W, 90,00€");
                platinum.WriteLine("800W, 110,00€");
                platinum.WriteLine("1000W, 160,00€");
                platinum.Close();
            }
            // Archivo PlacaBase.txt
            if (!File.Exists("PlacaBase.txt"))
            {
                StreamWriter placaBase = new StreamWriter("PlacaBase.txt");
                placaBase.WriteLine("ATX");
                placaBase.WriteLine("Micro ATX");
                placaBase.Close();
            }
            // Archivo PlacaAM3.txt
            if (!File.Exists("PlacaAM3.txt"))
            {
                StreamWriter placaAM3 = new StreamWriter("PlacaAM3.txt");
                placaAM3.WriteLine("ASUS M5A78L-M, 50,00€");
                placaAM3.WriteLine("Gigabyte GA-78LMT, 70,00€");
                placaAM3.WriteLine("MSI 760GMA-P34, 100,00€");
                placaAM3.Close();
            }
            // Archivo PlacaAM4.txt
            if (!File.Exists("PlacaAM4.txt"))
            {
                StreamWriter placaAM4 = new StreamWriter("PlacaAM4.txt");
                placaAM4.WriteLine("ASUS Prime A320M-K, 50,00€");
                placaAM4.WriteLine("Gigabyte B450M DS3H, 70,00€");
                placaAM4.WriteLine("MSI B450 Tomahawk, 100,00€");
                placaAM4.Close();
            }
            // Archivo PlacaAM5.txt
            if (!File.Exists("PlacaAM5.txt"))
            {
                StreamWriter placaAM5 = new StreamWriter("PlacaAM5.txt");
                placaAM5.WriteLine("ASUS Prime B550M-A, 50,00€");
                placaAM5.WriteLine("Gigabyte B550M DS3H, 70,00€");
                placaAM5.WriteLine("MSI B550-A Pro, 100,00€");
                placaAM5.Close();
            }
            // Archivo PlacaLGA1200.txt
            if (!File.Exists("PlacaLGA1200.txt"))
            {
                StreamWriter placaLGA1200 = new StreamWriter("PlacaLGA1200.txt");
                placaLGA1200.WriteLine("ASUS Prime H410M-E, 50,00€");
                placaLGA1200.WriteLine("Gigabyte B560M DS3H, 70,00€");
                placaLGA1200.WriteLine("MSI Z590-A Pro, 100,00€");
                placaLGA1200.Close();
            }
            // Archivo PlacaLGA1151.txt
            if (!File.Exists("PlacaLGA1151.txt"))
            {
                StreamWriter placaLGA1151 = new StreamWriter("PlacaLGA1151.txt");
                placaLGA1151.WriteLine("ASUS Prime Z270-P, 50,00€");
                placaLGA1151.WriteLine("Gigabyte Z370 Aorus, 70,00€");
                placaLGA1151.WriteLine("MSI Z390-A Pro, 100,00€");
                placaLGA1151.Close();
            }
            // Archivo PlacaLGA1700.txt
            if (!File.Exists("PlacaLGA1700.txt"))
            {
                StreamWriter placaLGA1700 = new StreamWriter("PlacaLGA1700.txt");
                placaLGA1700.WriteLine("ASUS Prime Z690-P, 50,00€");
                placaLGA1700.WriteLine("Gigabyte Z690 Aorus, 70,00€");
                placaLGA1700.WriteLine("MSI Z690-A Pro, 100,00€");
                placaLGA1700.Close();
            }
            // Archivo CajaATX.txt
            if (!File.Exists("CajaATX.txt"))
            {
                StreamWriter cajaATX = new StreamWriter("CajaATX.txt");
                cajaATX.WriteLine("Corsair 200R, 50,00€");
                cajaATX.WriteLine("NZXT H510, 70,00€");
                cajaATX.WriteLine("Fractal Design Meshify C, 100,00€");
                cajaATX.Close();
            }
            // Archivo CajaMicroATX.txt
            if (!File.Exists("CajaMicroATX.txt"))
            {
                StreamWriter cajaMicroATX = new StreamWriter("CajaMicroATX.txt");
                cajaMicroATX.WriteLine("Corsair 88R, 50,00€");
                cajaMicroATX.WriteLine("NZXT H210, 70,00€");
                cajaMicroATX.WriteLine("Fractal Design Define Mini C, 100,00€");
                cajaMicroATX.Close();
            }
            // Archivo Refrigeracion.txt
            if (!File.Exists("Refrigeracion.txt"))
            {
                StreamWriter refrigeracion = new StreamWriter("Refrigeracion.txt");
                refrigeracion.WriteLine("Aire");
                refrigeracion.WriteLine("Líquida");
                refrigeracion.Close();
            }
            // Archivo RefrigeracionAire.txt
            if (!File.Exists("RefrigeracionAire.txt"))
            {
                StreamWriter refrigeracionAire = new StreamWriter("RefrigeracionAire.txt");
                refrigeracionAire.WriteLine("Cooler Master Hyper 212, 50,00€");
                refrigeracionAire.WriteLine("Noctua NH-D15, 70,00€");
                refrigeracionAire.WriteLine("be quiet! Dark Rock Pro 4, 100,00€");
                refrigeracionAire.Close();
            }
            // Archivo RefrigeracionLiquida.txt
            if (!File.Exists("RefrigeracionLiquida.txt"))
            {
                StreamWriter refrigeracionLiquida = new StreamWriter("RefrigeracionLiquida.txt");
                refrigeracionLiquida.WriteLine("Corsair H60, 50,00€");
                refrigeracionLiquida.WriteLine("NZXT Kraken X63, 70,00€");
                refrigeracionLiquida.WriteLine("Cooler Master MasterLiquid ML360R, 100,00€");
                refrigeracionLiquida.Close();
            }
        }
    }
}
