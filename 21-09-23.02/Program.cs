using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_09_23._02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            double base1;
            double altura;

            inicio:

            // Entrada base
            Console.Write("Base del triángulo: ");
            base1 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            // Entrada altura
            Console.Write("Altura del triángulo: ");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine();

            // Calcular el área
            double area = base1 * altura / 2;

            // Imprimir el área
            Console.WriteLine("El área del triángulo es de: " + area);
            Console.ReadLine();
            //if (Console.ReadKey().Key != ConsoleKey.R) ;
            //{
            //    goto inicio;
            //}
        }
    }
}
