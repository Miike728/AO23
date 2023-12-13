using System;
using System.Collections.Generic;
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


            if (ejercicio == 4)
            {

            }




            Console.ReadLine();
        }
    }
}
