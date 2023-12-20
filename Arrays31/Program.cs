using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays31
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Introduce el numero de ejercicio: ");
            int ejercicio = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("EJERCICIO " + ejercicio);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();


            if (ejercicio == 31) //No terminado
            {

                int n = 0;

                do
                {
                    Console.Write("Ingresa el valor de n: ");
                    n = int.Parse(Console.ReadLine());

                }
                while (n > 10 || n < 0);

                int[] array = new int[n];
                Random random = new Random();
                Console.Write("Números: ");

                for (int i = 0; i < n; i++)
                {
                    array[i] = random.Next(0, 289);
                    Console.Write(array[i] + ", ");
                }


                Console.ReadLine();
            }

            if (ejercicio == 32)
            {
                int[] calificaciones = new int[10];

                for (int i = 0; i < calificaciones.Length; i++)
                {
                    calificaciones[i] = i + 1;
                }

                double media = 0;
                for (int i = 0; i < calificaciones.Length; i++)
                {
                    media += calificaciones[i];
                }
                media /= calificaciones.Length;

                int valoresPorEncimaDeLaMedia = 0;
                for (int i = 0; i < calificaciones.Length; i++)
                {
                    if (calificaciones[i] > media)
                    {
                        valoresPorEncimaDeLaMedia++;
                    }
                }
                double porcentaje = (double)valoresPorEncimaDeLaMedia / calificaciones.Length * 100;

                Console.WriteLine("Media: " + media);

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Nota: ");
                if (media < 5)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Suspenso.");
                }
                else if (media <= 6)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Aprobado.");
                }
                else if (media <= 8)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Notable.");
                }
                else if (media <= 10)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Sobresaliente.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: nota no válida.");
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("El porcentaje de valores por encima de la media es de " + porcentaje + "%");

            }

            if (ejercicio == 33)
            {

            }

            if (ejercicio == 34)
            {
                int[] array1 = new int[5];
                int[] array2 = new int[5];

                for (int i = 0; i < array1.Length; i++)
                {
                    Console.Write("Introduce el valor para la posición " + i + "del primer array: ");
                    array1[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < array2.Length; i++)
                {
                    array2[i] = array1[i] + 10;
                }

                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Array 1:");
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i < array1.Length; i++)
                {
                    Console.WriteLine("array1[{0}] = {1}", i, array1[i]);
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Array 2:");
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i < array2.Length; i++)
                {
                    Console.WriteLine("array2[{0}] = {1}", i, array2[i]);
                }
            }

            if (ejercicio == 35)
            {
                int[] array = new int[4];

                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("Introduce el valor para la posición " + i + " del array: ");
                    array[i] = int.Parse(Console.ReadLine());
                }

                double modulo = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    modulo += Math.Pow(array[i], 2);
                }
                modulo = Math.Sqrt(modulo);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("El módulo del array es " + modulo);
            }

            if (ejercicio == 36)
            {
                int[] array = new int[5];

                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("Introduce el valor para la posición " + i + "del array: ");
                    array[i] = int.Parse(Console.ReadLine());
                }

                int posicion = -1;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < 0)
                    {
                        posicion = i;
                        break;
                    }
                }

                Console.WriteLine();

                if (posicion == -1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("No hay números negativos en el array");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("El primer número negativo está en la posicion " + posicion + " y su valor es " + array[posicion]);
                }
            }

            Console.ReadLine();
        }
    }
}
