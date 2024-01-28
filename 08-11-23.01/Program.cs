using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Security.Cryptography;

namespace _08_11_23._01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 15;
            int m = 30;
            int suma = 0;
            for (int i = n; i <= m; i++) 
            {
                suma = suma + i;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(i + " ");

            }
            Console.WriteLine();
            Console.Write("La suma es: " + suma);
            Console.ReadKey();
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();

            int sumaImpares = 0;
            for (int i = n; i <= m; i++)
            {
                if (i % 2 != 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write(i + " ");
                    sumaImpares = sumaImpares + i;
                }
                
            }

            Console.WriteLine();
            Console.Write("La suma de los numeros impares es: " + sumaImpares);
            Console.ReadKey();
        }

    }
}
