using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace strings2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ejercicio;
            Console.Write("Introduce el número del ejercicio: ");
            ejercicio = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ejercicio " + ejercicio + ":");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            if (ejercicio == 1)
            {
                string[,] matriculas = new string[5, 5];
                Random rnd = new Random();
                int num;
                char letra1, letra2, letra3;
                string matricula;

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
                // Mostrar la matriz
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Matrículas generadas: ");
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i < matriculas.GetLength(0); i++)
                {
                    for (int j = 0; j < matriculas.GetLength(1); j++)
                    {
                        Console.Write(matriculas[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();


                // Mostrar las matrículas que acaban por z
                Console.Write("Matrículas que acaban por Z: ");
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
                Console.WriteLine(Environment.NewLine); // doble salto de línea

                // Mostrar las matrículas que contienen el número 34
                Console.Write("Matrículas que contienen el número 34: ");
                for (int i = 0; i < matriculas.GetLength(0); i++)
                {
                    for (int j = 0; j < matriculas.GetLength(1); j++)
                    {
                        if (matriculas[i, j].Contains("34"))
                        {
                            Console.Write(matriculas[i, j] + " ");
                        }
                    }
                }
                Console.WriteLine(Environment.NewLine);


                 // Mostrar solo la parte numérica de las matrículas
                Console.WriteLine("Parte numérica de las matrículas: ");
                for (int i = 0; i < matriculas.GetLength(0); i++)
                {
                    for (int j = 0; j < matriculas.GetLength(1); j++)
                    {
                        Console.Write(matriculas[i, j].Substring(0, 4) + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(Environment.NewLine);

                // Mostrar solo la parte alfabética de las matrículas
                Console.WriteLine("Parte alfabética de las matrículas: ");
                for (int i = 0; i < matriculas.GetLength(0); i++)
                {
                    for (int j = 0; j < matriculas.GetLength(1); j++)
                    {
                        Console.Write(matriculas[i, j].Substring(5, 3) + " ");
                    }
                    Console.WriteLine();
                }

                // Volcar los datos de la matriz a un fichero
                string ruta = "matriculas.txt";
                StreamWriter fichero = new StreamWriter(ruta);
                for (int i = 0; i < matriculas.GetLength(0); i++)
                {
                    for (int j = 0; j < matriculas.GetLength(1); j++)
                    {
                        fichero.Write(matriculas[i, j] + " ");
                    }
                    fichero.WriteLine();
                }
                fichero.Close();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Matrículas volcadas a " + ruta);
                Console.ForegroundColor = ConsoleColor.White;


            }

            if (ejercicio == 2)
            {
                string cadena;
                char caracter;
                int contador = 0;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Introduce una cadena: ");
                cadena = Console.ReadLine();
                Console.Write("Introduce un caracter: ");
                Console.ForegroundColor = ConsoleColor.White;
                caracter = char.Parse(Console.ReadLine());

                for (int i = 0; i < cadena.Length; i++)
                {
                    if (cadena[i] == caracter)
                    {
                        contador++;
                    }
                }

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("El caracter " + caracter + " aparece " + contador + " veces en la cadena " + cadena);
                Console.ForegroundColor = ConsoleColor.White;
            }

            if (ejercicio == 3)
            {
                string dni;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Introduce un DNI: ");
                Console.ForegroundColor = ConsoleColor.White;
                dni = Console.ReadLine();

                if (dni.Length != 9)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("El DNI debe tener 9 caracteres.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    if (char.IsDigit(dni[8]))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("El último caracter debe ser una letra.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            if (!char.IsDigit(dni[i]))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Los 8 primeros caracteres deben ser números.");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("El formato del DNI es correcto.");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            }
                        }
                    }
                }

                string letras = "TRWAGMYFPDXBNJZSQVHLCKE";
                int num = 0;

                for (int i = 0; i < 8; i++)
                {
                    num = num * 10 + (dni[i] - '0');
                }

                char letra = dni[8];
                letra = char.ToUpper(letra);
                char letraCorrecta = letras[num % 23];

                if (letra != letraCorrecta)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("La letra del DNI no es correcta. La letra correcta es " + letraCorrecta);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("La letra del DNI es correcta.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                
            }

            if (ejercicio == 4)
            {
                string cadena;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Introduce una cadena de texto: ");
                Console.ForegroundColor = ConsoleColor.White;
                cadena = Console.ReadLine();
                string[] palabras = cadena.Split(' ');
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Palabras que empiezan por b: ");
                Console.ForegroundColor = ConsoleColor.White;

                for (int i = 0; i < palabras.Length; i++)
                {
                    if (palabras[i].StartsWith("b") || palabras[i].StartsWith("B"))
                    {
                        Console.WriteLine(palabras[i]);
                    }
                }
            }

            if (ejercicio == 5)
            {
                string cadena;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Introduce una cadena de texto: ");
                Console.ForegroundColor = ConsoleColor.White;
                cadena = Console.ReadLine();

                if (cadena.Contains("@"))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("La cadena contiene el carácter @");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("La cadena no contiene el carácter @");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            if (ejercicio == 6)
            {
                string cadena;
                string subcadena;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Introduce una cadena de texto: ");
                Console.ForegroundColor = ConsoleColor.White;
                cadena = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Introduce una subcadena: ");
                Console.ForegroundColor = ConsoleColor.White;
                subcadena = Console.ReadLine();
                string[] palabras = cadena.Split(' ');
                int contador = 0;

                for (int i = 0; i < palabras.Length; i++)
                {
                    if (palabras[i].Contains(subcadena))
                    {
                        contador++;
                    }
                }
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("El número de palabras que contienen " + subcadena + " es " + contador);
                Console.ForegroundColor = ConsoleColor.White;
            }

            if (ejercicio == 7)
            {
                string email;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Introduce un email: ");
                Console.ForegroundColor = ConsoleColor.White;
                email = Console.ReadLine();
                string[] partes = email.Split('@');
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("El dominio del email es " + partes[1]);
                Console.ForegroundColor = ConsoleColor.White;
            }

            if (ejercicio == 8)
            {
                string codigo;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Introduce un código: ");
                Console.ForegroundColor = ConsoleColor.White;
                codigo = Console.ReadLine();

                if (codigo.Length != 4)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("El código debe tener 4 caracteres.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    if (char.IsDigit(codigo[0]) || char.IsDigit(codigo[1]) || char.IsLetter(codigo[2]) || char.IsLetter(codigo[3]))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("El código debe tener el formato AA99");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("El código tiene el formato correcto.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }

            if (ejercicio == 9)
            {
                string cadena;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Introduce una cadena de texto: ");
                Console.ForegroundColor = ConsoleColor.White;
                cadena = Console.ReadLine();
                cadena = cadena.Replace(" ", "*");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("La cadena resultante es " + cadena);
                Console.ForegroundColor = ConsoleColor.White;
            }

            if (ejercicio == 10)
            {
                string string1 = "Pedro Jimenez*14Julio1990?2500";
                string string2 = "Maria Benitez*9070!06Agosto1998";
                string[] partes1 = string1.Split('*');
                string[] partes2 = string2.Split('*');
                string[] salario1 = partes1[1].Split('?');
                string[] salario2 = partes2[1].Split('!');
                int salario1num = int.Parse(salario1[1]);
                int salario2num = int.Parse(salario2[0]);

                if (salario1num > 1000)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("El salario de Pedro Jimenez es " + salario1num);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("El salario de Pedro Jimenez es inferior a 1000.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                
                if (salario2num > 1000)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("El salario de Maria Benitez es " + salario2num);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("El salario de Maria Benitez es inferior a 1000.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            // ejercicio 11 y 26
            if (ejercicio == 11)
            {

            }

            if (ejercicio == 26)
            {

            }


            Console.ReadKey();
            }
        }
    }
