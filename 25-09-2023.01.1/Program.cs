﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_09_2023._01._1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n1 = 9;
            short n1copia = n1;
            int n1copia2 = n1copia;

            float n2 = 4.5f;
            double n2copia = n2;


            int numero1 = 2400;
            short numero1Copia = (short)numero1;
            double numero2 = 5.678;
            float numero2Copia = (float)numero2;

            // overflow :(
            short n3 = 300;
            byte n3Copia = (byte)n3;

            Console.WriteLine(n3Copia);
            Console.ReadKey();

            // pérdida de precision :(
            float r1 = 9.56f;
            int r1Copia = (int)r1;
            Console.WriteLine("r1= " + r1);
            Console.WriteLine("r1Copia= " + r1Copia);
            Console.ReadKey();
            
        }
    }
}
