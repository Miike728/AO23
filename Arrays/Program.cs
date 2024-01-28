using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {

        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Introduce el numero de ejercicio: ");
            int ejercicio = int.Parse(Console.ReadLine());
            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine();


            if (ejercicio == 14)
            {
                int[] array = { 1, 2, 3, 4, 5 };
                int suma = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    suma += array[i] * array[i];
                }

                Console.WriteLine("La suma de los cuadrados es: " + suma);
            }


            if (ejercicio == 15)
            {
                int[] array = { -1, 2, -3, 4, 5 }; 
                int suma = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] >= 0)
                    {
                        suma += array[i];
                    }
                }

                Console.WriteLine("La suma de los valores no negativos es: " + suma);
            }


            if (ejercicio == 17)
            {
                Random random = new Random();
                int[] array = new int[15]; //Tamaño

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(1, 100); //Rango
                }

                int contadorImpares = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0)
                    {
                        contadorImpares++;
                    }
                }


                double porcentajeImpares = (double)contadorImpares / array.Length * 100;

                Console.WriteLine("Array generado: [{0}]", string.Join(", ", array)); //For
                Console.WriteLine("Porcentaje de impares: " + porcentajeImpares + "%");

            }


            if (ejercicio == 26)
            {
                int[] array1 = { 1, 2, 3, 4, 5 };
                int[] array2 = { 1, 2, 3, 4, 5 };
                bool sonIguales = true;
                if (array1.Length == array2.Length)
                {
                    for (int i = 0; i < array1.Length; i++)
                    {
                        if (array1[i] != array2[i])
                        {
                            sonIguales = false;
                            break;
                        }
                    }
                }
                else { sonIguales = false; }

                if (sonIguales)
                {
                    Console.WriteLine("Los arrays son iguales");
                }
                else
                {
                    Console.WriteLine("Los arrays NO son iguales");
                }
            }


            if (ejercicio == 3)
            {
                int[] a = { 7, 2, 4, 8, 3, 9, 1, 5, 6 };
                int menor;
                menor = a[0];

                for (int i = 1; i < a.Length; i++)
                {
                    if (menor > a[i])
                    {
                        menor = a[i];
                    }

                }
                Console.Write(menor);

            }


            if (ejercicio == 31)
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
                Console.Write("Toma tus numeritos: ");

                for (int i = 0;  i < n; i++)
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
                    Console.ForegroundColor= ConsoleColor.Blue;
                    Console.Write("El primer número negativo está en la posicion " + posicion + " y su valor es " + array[posicion]);
                }
            }

            if (ejercicio == 38)
            {

            }

            Console.ReadLine();
        }
    }
}
