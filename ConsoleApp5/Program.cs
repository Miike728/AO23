using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 100;

            while (i < 550)
            {
                if (i % 10 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(i + " ");
                    i++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write(i + " ");
                    i++;
                }
                System.Threading.Thread.Sleep(1);
            }
    
            Console.ReadLine();
        }
    }
}
