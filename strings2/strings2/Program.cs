using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // menu para seleccionar el ejercicio
            int ejercicio;
            Console.WriteLine("Introduce el número del ejercicio que quieres ejecutar: ");
            ejercicio = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ejercicio " + ejercicio + ":");
            Console.ForegroundColor = ConsoleColor.White;

            if (ejercicio == 1)
            {
                string[,] matriculas = new string[5, 5];
                Random rnd = new Random();
                int num;
                char letra1, letra2, letra3;
                string matricula;
                // rellenar la matriz
                for (int i = 0; i < matriculas.GetLength(0); i++)
                {
                    for (int j = 0; j < matriculas.GetLength(1); j++)
                    {
                        num = rnd.Next(0, 9999);
                        letra1 = (char)rnd.Next('A', 'Z');
                        letra2 = (char)rnd.Next('A', 'Z');
                        letra3 = (char)rnd.Next('R', 'Z'+1); // +1 para que incluya la Z
                        matricula = num.ToString("0000") + "-" + letra1 + letra2 + letra3;
                        matriculas[i, j] = matricula;
                    }
                }
                // mostrar la matriz
                for (int i = 0; i < matriculas.GetLength(0); i++)
                {
                    for (int j = 0; j < matriculas.GetLength(1); j++)
                    {
                        Console.Write(matriculas[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                // Mostrar las matrículas que acaban por z
                Console.WriteLine("Matrículas que acaban por Z:");
                for (int i = 0; i < matriculas.GetLength(0); i++)
                {
                    for (int j = 0; j < matriculas.GetLength(1); j++)
                    {
                        if (matriculas[i, j].EndsWith("Z"))
                        {
                            Console.Write(matriculas[i, j] + " ");
                        }
                    }
                }

            }





            Console.ReadKey();
            }
        }
    }
