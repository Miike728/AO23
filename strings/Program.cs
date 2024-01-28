using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Introduce el numero de ejercicio: ");
            int ejercicio = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("EJERCICIO " + ejercicio);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            if (ejercicio == 1)
            {

            }
        }
    }
}
