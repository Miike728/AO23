using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_11_23._01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            int[] notas = new int[5];
            for(int i = 0; i < 5; i++)
            {
                Console.Write("Introduce una nota: ");
                notas[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < 5; i++) 
            {
                Console.Write(notas[i]);
                Console.Write(" ");
            }
            float suma = 0f;
            int contador = 0;
            for(int i = 0; i < 5; i++)
            {
                suma += notas[i];
                contador++;
            }
            double media = suma / contador;
                
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("La media es: " + media);

            Console.ReadLine();
        }
    }
}
