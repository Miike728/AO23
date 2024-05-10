using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 100;

            while (i < 1500)
            {
                if (i % 2 == 0) 
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    i++;
                    Console.Write(i + " ");
                }
                else
                {                    
                    Console.ForegroundColor = ConsoleColor.Red;
                    i++;
                    Console.Write(i + " ");
                }
                System.Threading.Thread.Sleep(1);
            }


            Console.ReadLine();
        }
    }
}
