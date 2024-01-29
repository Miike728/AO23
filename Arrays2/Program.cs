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
                int[,] array44 = new int[3, 3];
                Random random44 = new Random();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Números generados:");
                for (int i = 0; i < array44.GetLength(0); i++)
                {
                    for (int j = 0; j < array44.GetLength(1); j++)
                    {
                        array44[i, j] = random44.Next(0, 50);
                        Console.Write(array44[i, j] + " ");
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
                        Console.Write("Ya me cansé.");
                        Thread.Sleep(3);
                        exit();
                    }
                    fila = int.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                    contador++;
                }
                Console.WriteLine();

                Console.Write("Valores de la fila elegida (" + fila + "): ");
                for (int i = 0; i < array44.GetLength(0); i++)
                {
                    Console.Write(array44[fila, i] + " ");
                }
                Console.WriteLine();

                for (int i = 0; i < array44.GetLength(0); i++)
                {
                    array44[i, array44.GetLength(0) - 1] = 0;
                }

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Array modificado con ceros:");
                for (int i = 0; i < array44.GetLength(0); i++)
                {
                    for (int j = 0; j < array44.GetLength(1); j++)
                    {
                        Console.Write(array44[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();

                int suma = 0;
                for (int i = 0; i < array44.GetLength(0); i++)
                {
                    suma += array44[0, i];
                }
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Suma de los valores de la primera fila: " + suma);

                Console.ForegroundColor = ConsoleColor.White;

                int contador44 = 0;
                for (int i = 0; i < array44.GetLength(0); i++)
                {
                    if (array44[i, 1] == 0)
                    {
                        contador44++;
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Ceros en la segunda columna: " + contador44);
                Console.WriteLine();

                int suma2 = 0;
                for (int i = 0; i < array44.GetLength(0); i++)
                {
                    for (int j = 0; j < array44.GetLength(1); j++)
                    {
                        suma2 += array44[j, i];
                    }
                }

                Console.WriteLine("Suma: " + suma2);
                double media2 = suma2 / (array44.Length);
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

            if (ejercicio == 55)
            {
                int[,] array = new int[5, 5];
                Random rand = new Random();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Números generados:");
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = rand.Next(1, 100);
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                int contador = 0;
                while (contador < 3)
                {
                    int x = rand.Next(0, 5);
                    int y = rand.Next(0, 5);
                    if (array[x, y] != 0)
                    {
                        array[x, y] = 0;
                        contador++;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Array con 3 ceros:");
                Console.ForegroundColor = ConsoleColor.Blue;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {

                        if (array[i, j] == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(array[i, j] + " ");
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        else
                        {
                            Console.Write(array[i, j] + " ");
                        }
                    }
                    Console.WriteLine();
                }
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine();
                Console.WriteLine("Tienes 6 vidas, cada vez que falles se restará una. Si aciertas las 3 posiciones ganas");
                Console.ForegroundColor = ConsoleColor.Blue;
                int vidas = 6;
                int aciertos = 0;
                while (aciertos < 3 && vidas > 0)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Introduce la coordenada X: ");
                    int x = int.Parse(Console.ReadLine());
                    Console.Write("Introduce la coordenada Y: ");
                    int y = int.Parse(Console.ReadLine());

                    while (x < 0 || x > 4 || y < 0 || y > 4)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Error, las coordenadas deben estar entre 0 y 4");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Introduce la coordenada X: ");
                        x = int.Parse(Console.ReadLine());
                        Console.Write("Introduce la coordenada Y: ");
                        y = int.Parse(Console.ReadLine());
                    }
                    

                    if (array[x, y] == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Has acertado!");
                        aciertos++;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Has fallado...");
                        vidas--;
                    }
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Te quedan " + vidas + " vidas");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                }
                Console.ForegroundColor = ConsoleColor.White;
                if (aciertos == 3)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Has ganado!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Has perdido...");
                }

            }



            if (ejercicio == 99)
            {
                

            }

            Console.ReadLine();
        }

        private static void exit()
        {
            throw new NotImplementedException();
        }
    }
}
