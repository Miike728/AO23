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
            int base1;
            int altura;
            
            // Entrada base
            Console.Write("Base del triángulo: ");
            base1 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Entrada altura
            Console.Write("Altura del triángulo: ");
            altura = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Calcular el área
            int area = base1 * altura / 2;

            // Imprimir el área
            Console.WriteLine("El área del triángulo es de: " + area);
            Console.ReadLine();

        }
    }
}
