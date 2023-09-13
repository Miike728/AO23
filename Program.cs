using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //abc
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.White;
            
            //Cambiar titulo
            Console.Title = "ABC";

            Console.WriteLine("abc");

            Console.Beep(20000, 2000);

            /*a
             * b
             * c
             */
            Console.ReadLine();

        }
    }
}
