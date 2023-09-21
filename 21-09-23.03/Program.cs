using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_09_23._03
{
    class Program
    {
        static void Main(string[] args)
        {
            string dni;
            byte edad;

            Console.Write("Introduce el DNI: ");
            dni = Console.ReadLine();
            Console.WriteLine();


            Console.Write("Introduce la edad: ");
            edad = byte.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("DNI: " + dni);
            Console.WriteLine(" | Edad: " + edad);

            Console.ReadKey();

        }
    }
}
