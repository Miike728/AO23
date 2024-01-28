using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce el valor del array: ");
            int a1 = int.Parse(Console.ReadLine());
            int[] array = new int[a1];

            array[array.Length - 1] = 25;
            array[0] = 90;

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }
            Console.WriteLine();


            Console.ReadLine();



            int[] array2 = new int[100];

            Random generador = new Random();
            int num = generador.Next(0, 11);

            for (int i = 0; i < 100; i++)
            {

                array2[i] = generador.Next(1, 11);

                Console.Write(array2[i] + ", ");

            }

            Console.ReadLine();


            string[] a18 = new string[10];
            a18[0] = "abcdefg";
            int contador18 = 0;
            for(int i=0;i<a18.Length;i++)
            {
                if (a18[i] is null)
                {
                    contador18++;
                }
            }
            Console.Write("Posiciones vacías: " + contador18);

            Console.ReadLine();

        }
    }
}
