using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_10_23._01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char continuar;
            continuar = 's';
            do
            {
                char opcion;
                
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Elige una opción (a-c):");
                opcion = char.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 'a':
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine('A');
                        break;
                    case 'b':
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("B");
                        break;
                    case 'c':
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("C");
                        break;
                    default:
                        break;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Quieres voler al menú? S/N");
                continuar = Console.ReadKey().KeyChar;

                //////if (continuar == ' ')
                //////{
                //////    continuar = 's';
                //////}

                Console.Clear();
            }
            while (continuar == 's');
        }
    }
}
