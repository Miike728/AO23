using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_09_23._01
{
    class Program
    {
        static void Main(string[] args)
        {
            int base1;
            int altura;

            // Entrada base
            Console.WriteLine("Base del triángulo: ");
            base1 = int.Parse(Console.ReadLine());

            // Entrada altura
            Console.WriteLine("Altura del triángulo: ");
            altura = int.Parse(Console.ReadLine());

            // Calcular el área
            int area = base1 * altura / 2;

            // Imprimir el área
            Console.WriteLine("El área del triángulo es de: " + area);
            Console.ReadLine();

        }
    }
}
