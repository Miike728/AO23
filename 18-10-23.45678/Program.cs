using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_10_23._45678
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ejercicio;
            Console.Write("Elige un ejercicio (4-8): ");
            ejercicio = int.Parse(Console.ReadLine());
            Console.Clear();

            if (ejercicio == 4)
            {
                double num1, num2, num3;
                Console.Write("Introduce el primer numero: ");
                num1 = double.Parse(Console.ReadLine());
                Console.Write("Introduce el segundo numero: ");
                num2 = double.Parse(Console.ReadLine());
                Console.Write("Introduce el tercer numero: ");
                num3 = double.Parse(Console.ReadLine());

                Console.ReadLine();
            }
            else if (ejercicio == 5)
            {

            }
            else if (ejercicio == 6)
            {

            }
            else if (ejercicio == 7)
            { 
                
            }
            else if (ejercicio == 8)
            {

            }
            else
            {
                Console.WriteLine("Ejercicio no válido."); Console.ReadLine();
            }
        }
    }
}
