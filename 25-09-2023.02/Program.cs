using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_09_2023._02
{
    class Program
    {
        static void Main(string[] args)
        {
            byte x1 = 9;
            byte x2 = 10;
            int resultado = x1 + x2;
            byte resultado2 = (byte)(x1 + x2);


            // Si hay 2 tipos de operando, devuelve el de más capacidad
            long x3 = 900000;
            int x4 = 1000;
            int suma = (int)(x3 + x4);
            long suma2 = x3 + x4;

            // El operador / si los operandos son de tipo int devuelve nu valor de tipo int,
            // aunque el resultado no sea exacto
            int a1 = 9;
            int a2 = 5;
            double division = a1 / a2;
            double division2 = (double)(a1 / a2); //no sirve
            double division3 = (double)a1 / a2;
            Console.WriteLine("division= " + division);
            Console.WriteLine("division2= " + division2);
            Console.WriteLine("division3= " + division3);

            Console.ReadLine();

        }
    }
}
