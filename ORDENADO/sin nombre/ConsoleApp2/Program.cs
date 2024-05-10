using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_09_2023._01
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ejercicio 4
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("EJERCICIO 4:");
            Console.BackgroundColor = ConsoleColor.Black;

            double radio;
            const double PI = 3.141516;
            Console.Write("Introduce el radio: ");
            radio = double.Parse(Console.ReadLine());

            double area, volumen, longitud;
            Console.WriteLine();
            longitud = 2 * PI * radio;
            area = PI * (radio * radio);
            volumen = (4f / 3) * PI * (radio * radio * radio); //4f para pasar a float, si no la division pierde los decimales, tambien sirve 4.0

            Console.WriteLine("Longitud= " + longitud);
            Console.WriteLine("Área= " + area);
            Console.WriteLine("Volumen= " + volumen);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[Enter para pasar al ejercicio siguiente]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();


            ////////////////////////////////////

            //Ejercicio 5
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("EJERCICIO 5:");
            Console.BackgroundColor = ConsoleColor.Black;

            double precio;
            short cantidad;

            Console.Write("Introduce precio: ");
            precio = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Introduce cantidad: ");
            cantidad = short.Parse(Console.ReadLine());
            Console.WriteLine();

            double total;

            total = precio * cantidad;
            Console.WriteLine("Precio total: " + total);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[Enter para pasar al ejercicio siguiente]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();


            /////////////////////////////////////////

            //Ejercicio 7
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("EJERCICIO 7:");
            Console.BackgroundColor = ConsoleColor.Black;

            double temp, tempFinal;

            Console.Write("Introduce temperatura en grados Celsius: ");
            temp = double.Parse(Console.ReadLine());
            tempFinal = temp * 9 / 5 + 32;
            Console.WriteLine();

            Console.WriteLine("Temperatura en Fahrenheit: " + tempFinal);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[Enter para terminar]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();


        }
    }
}
