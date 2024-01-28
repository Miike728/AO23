using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce 3 valores:");
            double a, b, c;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            double media, modulo;
            media = (a + b + c) / 3;
            modulo = Math.Sqrt(a * a + b * b + c * c);
            modulo = Math.Round(modulo, 2);
            int menor2 = (int)Math.Min(a, b);
            int menor = (int)Math.Min(menor2, c);

            Console.WriteLine(media);
            Console.WriteLine(modulo);
            Console.WriteLine(menor);
            Console.ReadLine();

        }
    }
}
