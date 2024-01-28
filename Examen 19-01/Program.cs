using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_19_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ejercicio;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Introduce el número del ejercicio: ");
            Console.ForegroundColor= ConsoleColor.Green;
            ejercicio = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Ejercicio: " + ejercicio);
            Console.ForegroundColor = ConsoleColor.White;

            if (ejercicio == 1) // Algoritmo que busca el primer impar de un array y lo eleva al cuadrado
            {
                // Crear array y variable encontrado
                int[] array = new int[9] { 2, 4, 7, 8, 3, 1, 5, 19, 1 };
                bool encontrado = false;

                // Buscar el primer número impar
                foreach (int i in array)
                {
                    if (i % 2 != 0) 
                    {   
                        array[i] = (i * i);
                        Console.WriteLine("El primer número impar es: " + i);
                        Console.WriteLine("El primer número impar elevado al cuadrado es: " + array[i]);
                        encontrado = true;
                        break;
                    }
                }
                
                if (!encontrado) // Si no hay ninguno, error
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("No hay ningún número impar en el array");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.ReadLine();
            }

            else if (ejercicio == 2) // Calcular la desviación
            {

                // Crear array y variable
                int[] array = new int[10] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
                double suma = 0;

                // Sumar todos los valores del array en variable suma
                for (int i = array.Length - 5; i < array.Length; i++)
                {
                    suma += array[i];
                }

                // Calcular media
                Console.ForegroundColor = ConsoleColor.Blue;
                double media = suma / array.Length;
                Console.WriteLine("Media: " + media);

                Console.ForegroundColor= ConsoleColor.White;
                Console.WriteLine("Desviaciones respecto a la media:");
                Console.WriteLine();

                // escribir en pantalla números y desviaciones de la media
                for (int i = array.Length - 5; i < array.Length; i++)
                {
                    Console.WriteLine("Número original: " + array[i]);
                    double desviacion = array[i] - media;
                    Console.WriteLine("Desviacion: " + desviacion);
                    Console.WriteLine("--------------------");
                }

                Console.ReadLine();
            }

            else if (ejercicio == 3) // Copiar valores de un array que son múltiplos de 3 en otro array
            {
                Console.WriteLine("No terminado");
                /*
                // Crear arrays
                int[] array = new int[10] { 2, 3, 5, 9, 14, 15, 92, 31, 26, 6 };
                int[] array2 = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
                int arrayT = 0;

                // Buscar múltiplos de 3 y copiarlos
                foreach (int i in array)
                {
                    if (i % 3 == 0)
                    {
                        array[i] = arrayT;
                        for (int n = 1; i < array.Length; n++)
                        {
                            array[n] = arrayT;
                        }
                    }
                }


                Console.ReadLine();
                */
            }

            else if (ejercicio == 4) // Calcular el % de negativos en un array
            {
                // Crear array
                int[] array = new int[7] { -5, 10, -3, 4, -1, 6, -2 };

                int contador = 0;
                // Buscar negativos
                foreach (int i in array)
                {
                    if (i < 0)
                    {
                        contador++;
                    }
                }

                double porcentajeNegativos = (double)contador / array.Length * 100;
                Console.WriteLine("El porcentaje de números negativos es: " + porcentajeNegativos + "%");

            Console.ReadLine();
            }

            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ejercicio " + ejercicio + " no válido.");
                Console.ReadLine();
            }
        }
    }
}
