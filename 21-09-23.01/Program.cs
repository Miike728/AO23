using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_09_23._01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion variables
            byte n1;

            //Inicializar variables
            n1 = 10;
            byte n2 = n1;

            //Declarar varias variables
            short num1, num2, num3;
            num1 = 9;
            num2 = 10;
            num3 = 5;



            //Modificar variables
            num1 = (short)(num1 + 1); //Cambia tipo de variable a short y modifca el valor
            
            int x1 = 10;
            x1 = x1 + 1;



            //abcd
            double abc;
            double xyz;
            Console.Write("Introduce el valor 1: ");
            abc = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Introduce el valor 2: ");
            xyz = double.Parse(Console.ReadLine());
            abc = abc + xyz;
            Console.WriteLine("Total=" + abc);

            Console.ReadLine();

        }
    }
}
