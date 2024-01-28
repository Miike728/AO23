using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Arrays2
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

            if (ejercicio == 44)
            {
                int [,] cebolla = new int[3, 3];
                Random lechuga = new Random();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Números generados:");
                for (int i = 0;  i < cebolla.GetLength(0); i++)
                {
                    for (int j = 0; j < cebolla.GetLength(1); j++)
                    {
                        cebolla[i, j] = lechuga.Next(0, 50);
                        Console.Write(  cebolla[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();

                Console.Write("Elige una fila (entre 0 y 2): ");
                int fila = int.Parse(Console.ReadLine());
                Console.WriteLine();
                int contador = 0;
                while (fila < 0 || fila > 2)    
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    if (contador == 0)
                    {
                        Console.Write("Error, elige una fila entre 0 y 2: ");
                    }
                    else if (contador == 1)
                    {
                        Console.Write("Error otra vez, elige una fila entre 0 y 2: ");
                    }
                    else if (contador == 2)
                    {
                        Console.Write("Error, te pido por favor que elijas de una vez una fila entre 0 y 2: ");
                    }
                    else
                    {
                        Console.Write("Ya me cansé, nos vemos");
                        Thread.Sleep(3);
                        exit();
                    }
                    fila = int.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                    contador++;
                }
                Console.WriteLine();

                Console.Write("Valores de la fila elegida (" + fila + "): ");
                for (int i = 0; i < cebolla.GetLength(0); i++)
                {
                    Console.Write(cebolla[fila, i] + " ");
                }
                Console.WriteLine();

                for (int i = 0; i < cebolla.GetLength(0); i++)
                {
                    cebolla[i, cebolla.GetLength(0) - 1] = 0;
                }

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Array modificado con ceros:");
                for (int i = 0; i < cebolla.GetLength(0); i++)
                {
                    for (int j = 0; j < cebolla.GetLength(1); j++)
                    {
                        Console.Write(cebolla[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();

                int suma = 0;
                for (int i = 0; i < cebolla.GetLength(0); i++)
                {
                    suma += cebolla[0, i];
                }
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Suma de los valores de la primera fila: " + suma);

                Console.ForegroundColor = ConsoleColor.White;

                int contador44 = 0;
                for (int i = 0; i< cebolla.GetLength(0); i++)
                {
                    if (cebolla[i, 1]  == 0)
                    {
                        contador44++;
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Ceros en la segunda columna: " + contador44);
                Console.WriteLine();

                int suma2 = 0;
                for (int i = 0; i < cebolla.GetLength(0); i++)
                {
                    for (int j = 0;j < cebolla.GetLength(1);j++)
                    {
                        suma2 += cebolla[j, i];
                    }
                }

                Console.WriteLine("Suma: " + suma2);
                double media2 = suma2 / (cebolla.Length);
                Console.WriteLine("Media: " + media2);

            }

            if (ejercicio == 46)
            {
                int[,] array = new int[3, 3];
                Random rand = new Random();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Números generados:");
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = rand.Next(0, 100);
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();

                int[,] arrayT = new int[3, 3];

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        arrayT[i, j] = array[j, i];

                    }
                }


                Console.WriteLine("Matriz traspuesta:");
                for (int i = 0; i < arrayT.GetLength(0); i++)
                {
                    for (int j = 0; j < arrayT.GetLength(1); j++)
                    {
                        Console.Write(arrayT[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();

            }




            Console.ReadLine();
        }

        private static void exit()
        {
            throw new NotImplementedException();
        }
    }
}
