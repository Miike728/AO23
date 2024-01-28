using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace B5
{
    internal class Program
    {

        static void writeTitle(String titular)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine(titular);
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void Main(string[] args)
        {
            int ejercicio;

            string repetirMain;
            // Bucle do-while para repetir el programa completo
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Elige un ejercicio (5-12): ");
                Console.ForegroundColor = ConsoleColor.White;
                ejercicio = int.Parse(Console.ReadLine());


                //EJERCICIO 5
                if (ejercicio == 5)
                {
                    string repetir;
                    // Bucle do-while para repetir el ejercicio
                    do
                    {
                        writeTitle("EJERCICIO 5");

                        Thread.Sleep(150);
                        int numero = 320;

                        while (numero >= 160)
                        {
                            Console.WriteLine(numero);
                            numero -= 20;
                        }

                        // Preguntar al usuario si quiere repetir
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("¿Quieres repetir este ejercicio? (S/N): ");
                        repetir = Console.ReadLine();
                    } while (repetir == "s");
                }


                //EJERCICIO 6
                else if (ejercicio == 6)
                {
                    string repetir;
                    // Bucle do-while para repetir el ejercicio
                    do
                    {
                        writeTitle("EJERCICIO 6");

                        Thread.Sleep(150);

                        for (int i = 0; i<=100; i++)
                        {
                            if(i % 5 == 0 && i % 7 == 0)
                            {
                                Console.WriteLine(i);
                            }
                        }

                        // Preguntar al usuario si quiere repetir
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("¿Quieres repetir este ejercicio? (S/N): ");
                        repetir = Console.ReadLine();
                    } while (repetir == "s");
                }


                //EJERCICIO 7
                else if (ejercicio == 7)
                {
                    string repetir;
                    // Bucle do-while para repetir el ejercicio
                    do
                    {
                        writeTitle("EJERCICIO 7");

                        int numero;
                        Console.Write("Introduzca un número: ");
                        numero = int.Parse(Console.ReadLine());

                        for(int i = 1; i <=10; i++)
                        {
                            Console.ForegroundColor= ConsoleColor.Blue;
                            Console.WriteLine(numero + "x" + i + "=" + numero * i);
                        }

                        // Preguntar al usuario si quiere repetir
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("¿Quieres repetir este ejercicio? (S/N): ");
                        repetir = Console.ReadLine();
                    } while (repetir == "s");
                }


                //EJERCICIO 8
                else if (ejercicio == 8)
                {
                    string repetir;
                    // Bucle do-while para repetir el ejercicio
                    do
                    {
                        writeTitle("EJERCICIO 8");

                        int numero, cuadrado, cubo;

                        Console.Write("Introduce un número: ");
                        numero = int.Parse(Console.ReadLine());
                        cuadrado = numero * numero;
                        cubo = numero * numero * numero;

                        Console.WriteLine("Número | Cuadrado | Cubo");
                        Console.WriteLine("------- | -------- | --------");

                        for (int i = 0; i < 5; i++)
                        {
                            numero = numero + 1;
                            Console.WriteLine("{0} | {1} | {2}", numero, cuadrado, cubo);
                        }
                            // Preguntar al usuario si quiere repetir
                            Console.WriteLine();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("¿Quieres repetir este ejercicio? (S/N): ");
                        repetir = Console.ReadLine();
                    } while (repetir == "s");
                }


                //EJERCICIO 9
                else if (ejercicio == 9)
                {
                    string repetir;
                    // Bucle do-while para repetir el ejercicio
                    do
                    {
                        writeTitle("EJERCICIO 9");




                        // Preguntar al usuario si quiere repetir
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("¿Quieres repetir este ejercicio? (S/N): ");
                        repetir = Console.ReadLine();
                    } while (repetir == "s");
                }


                //EJERCICIO 10
                else if (ejercicio == 10)
                {
                    string repetir;
                    // Bucle do-while para repetir el ejercicio
                    do
                    {
                        writeTitle("EJERCICIO 10");

                        int m = -1;
                        int suma = 0, contador = 0;

                        do
                        {
                            if(contador==0)
                            {
                                Console.Write("Introduce un número positivo: ");
                                m = int.Parse(Console.ReadLine());
                            }
                            else if (contador==1)
                            {
                                Console.Write("Introduce UN NÚMERO POSITIVO: ");
                                m = int.Parse(Console.ReadLine());
                            }
                            else if (contador == 2)
                            {
                                Console.Write("Repito, introduce un número POSITIVO: ");
                                m = int.Parse(Console.ReadLine());
                            }
                            else
                            {
                                Console.Write("Mejor no introduzcas nada");
                                Thread.Sleep(1000);
                                break;
                            }
                            contador++;

                        } while (m < 0 && contador <= 3);
                      
                        if(m > 0)
                        {
                            for (int i = 1; i <= m; i++)
                            {
                                suma += i;
                            }
                            Console.WriteLine("La suma de los primeros {0} números es {1}", m, suma);
                        }

                        // Preguntar al usuario si quiere repetir
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("¿Quieres repetir este ejercicio? (S/N): ");
                        repetir = Console.ReadLine();
                    } while (repetir == "s");
                }


                //EJERCICIO 11
                else if (ejercicio == 11)
                {
                    string repetir;
                    // Bucle do-while para repetir el ejercicio
                    do
                    {
                        writeTitle("EJERCICIO 11");



                        // Preguntar al usuario si quiere repetir
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("¿Quieres repetir este ejercicio? (S/N): ");
                        repetir = Console.ReadLine();
                    } while (repetir == "s");
                }


                //EJERCICIO 12
                else if (ejercicio == 12)
                {
                    string repetir;
                    // Bucle do-while para repetir el ejercicio
                    do
                    {
                        writeTitle("EJERCICIO 12");

                        int n;
                        int suma = 0;

                        Console.Write("Introduce un número: ");
                        n = int.Parse(Console.ReadLine());

                        for (int i = 1; i <= n; i++)
                        {
                            if (n % i == 0)
                            {
                                suma += i;
                            }
                        }
                        Console.Write("La suma de los divisores de {0} es {1}", n, suma);

                        // Preguntar al usuario si quiere repetir
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("¿Quieres repetir este ejercicio? (S/N): ");
                        repetir = Console.ReadLine();
                    } while (repetir == "s");
                }



                //EJERCICIO 15
                else if (ejercicio == 15)
                {
                    string repetir;
                    // Bucle do-while para repetir el ejercicio
                    do
                    {
                        writeTitle("EJERCICIO 15");



                        // Preguntar al usuario si quiere repetir
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("¿Quieres repetir este ejercicio? (S/N): ");
                        repetir = Console.ReadLine();
                    } while (repetir == "s");
                }


                //EJERCICIO 22
                else if (ejercicio == 22)
                {
                    string repetir;
                    // Bucle do-while para repetir el ejercicio
                    do
                    {
                        writeTitle("EJERCICIO 22");
                        for (int i = 0; i < 10; i++)
                        {
                            for (int j = 0; j < 10; j++)
                            {
                                Console.Write("* ");

                            }
                            Console.WriteLine();
                        }

                        // Preguntar al usuario si quiere repetir
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("¿Quieres repetir este ejercicio? (S/N): ");
                        repetir = Console.ReadLine();
                    } while (repetir == "s");
                }


                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("El ejercicio \"" + ejercicio + "\" no es válido.");
                    Thread.Sleep(1000);
                }

                // Preguntar al usuario si quiere repetir el programa completo
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("¿Quieres reiniciar el programa? (S/N): ");
                repetirMain = Console.ReadLine();
            } while (repetirMain == "s");
        }
    }
}
