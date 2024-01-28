using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; // Para poder utilizar el "Thread.Sleep(500)" del final del código

namespace Examen_24_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Elige un ejercicio entre 1 y 4: ");
            Console.ForegroundColor = ConsoleColor.White;

            int ejercicio;
            ejercicio = int.Parse(Console.ReadLine());

            if(ejercicio == 1) // Bucle while que genere x números de salida
            {

                // Titulo
                Console.Clear();
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("EJERCICIO 1");
                Console.ForegroundColor = ConsoleColor.White;


                // Bucle A
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Bucle A: ");
                Console.ForegroundColor = ConsoleColor.White;
                int numeroA = 2;
                while(numeroA<52)
                {
                    numeroA += 10;
                    Console.Write(numeroA);

                    if(numeroA<52)
                    {
                        Console.Write(", ");
                    }
                }


                // Bucle B
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine();
                Console.WriteLine("Bucle B: ");
                Console.ForegroundColor = ConsoleColor.White;
                int numeroB = 120;
                while(numeroB>20)
                {
                    numeroB -= 20;
                    Console.Write(numeroB);

                    if(numeroB>20)
                    {
                        Console.Write(", ");
                    }
                }

                Console.ReadLine();
            }

            else if (ejercicio == 2) // Programa que muestre los 10 primeros numeros impares y multiplos de 7 entre n y m.
            {

                // Titulo
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("EJERCICIO 2");
                Console.ForegroundColor = ConsoleColor.White;

                int n, m;
                do
                {
                    Console.Write("Introduce el número n: ");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Introduce el número m: ");
                    m = int.Parse(Console.ReadLine());
                    if(n>m)
                    {
                        // Limpiar pantalla y repetir titulo, y volver arriba del do para solicitar los números si n > m
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("EJERCICIO 2");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                while (n > m);


                Console.Write("Los 10 primeros números impares y multiplos de 7 entre " + n + " y " + m + " son: ");
                int contador = 0;
                for (int i = n; i <= m && contador < 10; i++)
                {
                    if (i % 2 != 0 && i % 7 == 0)
                    {
                        Console.Write(i);
                        Console.Write(", ");

                        contador++;
                    }
                }

                if (contador < 10)
                {
                    Console.WriteLine();
                    Console.ForegroundColor= ConsoleColor.DarkYellow;
                    Console.WriteLine("Hay menos de 10 números, se muestran solo los que hay.");
                }

                Console.ReadLine();
            }

            else if(ejercicio == 3) // Programa que calcula una suma
            {
                
                // Titulo
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("EJERCICIO 3");
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("Introduce el valor de n: ");
                int n = int.Parse(Console.ReadLine());
                double suma = 0;

                if (n < 10)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("El valor de n debe ser mayor o igual a 10.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    for (int i = 10; i <= n; i += 2)
                    {
                        suma += 1 + (double)i / (Math.Pow(i, 3) + 1);
                    }
                }

                Console.WriteLine("La suma es: " + suma);

                Console.ReadLine();
            }

            else if(ejercicio == 4) // Programa que decide si dos numeros son amigos.
            {
                // TItulo
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("EJERCICIO 4");
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("Introduce el primer número: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Introduce el segundo número: ");
                int num2 = int.Parse(Console.ReadLine());

                int sumaDivisoresNum1 = 0;
                int sumaDivisoresNum2 = 0;

                for (int i = 1; i < num1; i++)
                {
                    if (num1%i == 0)
                    {
                        sumaDivisoresNum1 += i;
                    }
                }

                for (int i = 1; i < num2; i++)
                {
                    if (num2%i == 0)
                    {
                        sumaDivisoresNum2 +=i;
                    }
                }

                if (sumaDivisoresNum1 == num2 && sumaDivisoresNum2 == num1)
                {
                    Console.WriteLine(num1 + " y " + num2 + "son números amigos.");
                }
                else
                {
                    Console.WriteLine(num1 + "y " + num2 + " no son números amigos.");
                }

                Console.ReadLine();
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine();
                Console.Write("El ejercicio " + ejercicio + " no existe...");
                Thread.Sleep(1500);
            }
        }
    }
}
