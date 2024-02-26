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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Opciones disponibles:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1 - Matrículas");
            Console.WriteLine("2 - Obtiene el número de veces que aparece un char en un string");
            Console.WriteLine("3 - DNIs");
            Console.WriteLine("4 - Leer una cadena de texto y mostrar las palabras que empiezan por b");
            Console.WriteLine("5 - Procesa un String y devuelve true si contiene el carácter “@”");
            Console.WriteLine("6 - Recibe un String y devuelve el número de palabras que contienen un Substring");
            Console.WriteLine("7 - Algoritmo que devuelva el dominio al que pertenece un email");
            Console.WriteLine("8 - Valida si un String tiene el formato AA99");
            Console.WriteLine("9 - Recibe un String y sustituye todos los espacios por el caracter *");
            Console.WriteLine("10 - Obtener el salario de cada string y comprobar que es superior a 1000");
            Console.WriteLine("11 - Ahorcado");
            Console.WriteLine("26 - Guardar y modificar registros de un fichero");
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

                num = int.Parse(dni.Substring(0, 8));
                /*
                 * for (int i = 0; i < 8; i++)
                {
                    num = num * 10 + (dni[i] - '0');
                }
                */


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
                //matriz de palabras
                string[] palabras = { "ordenador", "teclado", "raton", "monitor", "impresora", "altavoces", "auriculares", "microfono", "webcam", "pantalla", "procesador", "tarjeta", "grafica", "memoria", "disco", "fuente", "alimentacion", "placa", "base", "caja", "torre", "portatil", "tablet", "movil", "smartphone" };
                // palabra aleatoria
                Random rnd = new Random();
                int aleatorio = rnd.Next(0, palabras.Length);
                string palabra = palabras[aleatorio];
                // contador de vidas
                int vidas = 6;
                // palabra oculta
                string palabraOculta = "";
                for (int i = 0; i < palabra.Length; i++)
                {
                    palabraOculta += "_";
                }
                // letras no acertadas
                string letrasNoAcertadas = "";
                // letra introducida
                char letra;
                
                // bucle del juego
                while (vidas > 0 && palabraOculta.Contains("_"))
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ejercicio " + ejercicio);    
                    Console.WriteLine();
                    //muñeco
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("   +---+");
                    Console.WriteLine("   |   |");

                    if ( vidas == 6)
                    {
                        Console.WriteLine("   O   |");
                        Console.WriteLine("       |");
                        Console.WriteLine("       |");
                        Console.WriteLine("       |");
                    }
                    else if (vidas == 5) 
                    {
                        Console.WriteLine("   O   |");
                        Console.WriteLine("   |   |");
                        Console.WriteLine("       |");
                        Console.WriteLine("       |");

                    }
                    else if (vidas == 4)
                    {
                        Console.WriteLine("   O   |");
                        Console.WriteLine("  /|   |");
                        Console.WriteLine("       |");
                        Console.WriteLine("       |");
                    }
                    else if (vidas == 3)
                    {
                        Console.WriteLine("   O   |");
                        Console.WriteLine("  /|\\  |");
                        Console.WriteLine("       |");
                        Console.WriteLine("       |");
                    }
                    else if (vidas == 2)
                    {
                        Console.WriteLine("   O   |");
                        Console.WriteLine("  /|\\  |");
                        Console.WriteLine("   |   |");
                        Console.WriteLine("       |");
                    }
                    else if (vidas == 1)
                    {
                        Console.WriteLine("   O   |");
                        Console.WriteLine("  /|\\  |");
                        Console.WriteLine("   |   |");
                        Console.WriteLine("  /    |");
                    }
                    else
                    {
                        Console.WriteLine("   O   |");
                        Console.WriteLine("  /|\\  |");
                        Console.WriteLine("   |   |");
                        Console.WriteLine("  / \\  |");
                    }

                    Console.WriteLine("==========");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    //colores vidas
                    Console.WriteLine();
                    Console.Write("Vidas: ");
                    if (vidas == 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(vidas);
                    } else if (vidas == 5)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine(vidas);
                    } else if (vidas == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(vidas);
                    } else if (vidas == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(vidas);
                    } else if (vidas == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(vidas);
                    } else if (vidas == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(vidas);
                    } else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(vidas);
                    }
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Letras no acertadas: " + letrasNoAcertadas);
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("Palabra: " + palabraOculta);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(Environment.NewLine);
                    Console.Write("Introduce una letra: ");
                    letra = char.Parse(Console.ReadLine());
                    //comprobar si la letra está en la palabra
                    if (palabra.Contains(letra))
                    {
                        //recorrer la palabra
                        for (int i = 0; i < palabra.Length; i++)
                        {
                            //comprobar si la letra está en la palabra
                            if (palabra[i] == letra)
                            {
                                //cambiar la letra en la palabra oculta para mostrarla
                                palabraOculta = palabraOculta.Substring(0, i) + letra + palabraOculta.Substring(i + 1);                                
                            }
                        }
                    }
                    else
                    {
                        //si la letra no está en la palabra, restar una vida y añadir la letra a las no acertadas
                        letrasNoAcertadas += letra;
                        vidas--;
                    }
                }
                //si se acban las vidas o se acierta la palabra mostrar mensaje
                if (vidas == 0)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Has perdido. La palabra era " + palabra);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Has ganado. La palabra era " + palabra);
                    Console.ForegroundColor = ConsoleColor.White;
                }


            }

            if (ejercicio == 26)
            {
                // Crear un fichero con los registros
                String ruta = Directory.GetCurrentDirectory();
                String rutaFichero = ruta + "\\registros.txt";
                String[] registros = new String[50];
                StreamWriter fichero = new StreamWriter(rutaFichero);

                //Escribir los registros en el fichero
                fichero.WriteLine("12345678A*Juan Perez?25?1500");
                fichero.WriteLine("87654321B*Ramon Rios?25?2501");
                fichero.WriteLine("11111111C*Antonio Rodriguez?40?3000");
                fichero.Close();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Fichero creado en: " + rutaFichero);
                Console.WriteLine();


                //Menu con las opciones
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Menu");
                Console.WriteLine("----");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("1. Mostrar todos los registros");
                Console.WriteLine("2. Insertar nuevo registro");
                Console.WriteLine("3. Consultar por DNI");
                Console.WriteLine("4. Mostrar registros cuyo salario sea superior a 2500€");
                Console.WriteLine("5. Modificar el salario del registro con el DNI indicado.");
                Console.WriteLine("6. Eliminar registro a partir del DNI");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("Elige la opción: ");
                int apartado = 0;
                apartado = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();

                //Pasar a registros los registros del fichero
                StreamReader ficheroLectura2 = new StreamReader(rutaFichero);
                String linea2;
                int contador = 0;
                // Recorrer los registros y guardarlos en la matriz local
                while ((linea2 = ficheroLectura2.ReadLine()) != null)
                {
                    registros[contador] = linea2;
                    contador++;
                }
                ficheroLectura2.Close();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Registros pasados a la matriz local");
                Console.WriteLine();

                if (apartado == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Registros actuales:");
                    Console.WriteLine("-------------------");
                    Console.ForegroundColor = ConsoleColor.White;
                    //Inicializar el lector del fichero
                    StreamReader ficheroLectura = new StreamReader(rutaFichero);
                    String linea;
                    //Recorrer los registros y mostrarlos por pantalla
                    while ((linea = ficheroLectura.ReadLine()) != null)
                    {
                        Console.WriteLine(linea);
                    }
                    ficheroLectura.Close();
                }
                else if (apartado == 2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("Introduce el nuevo registro con el formato: dni*nombre y apellidos?edad?Salario: ");
                    String nuevoRegistro = Console.ReadLine();
                    //Añadir el nuevo registro al fichero
                    StreamWriter ficheroEscritura = new StreamWriter(rutaFichero, true);
                    ficheroEscritura.WriteLine(nuevoRegistro);
                    ficheroEscritura.Close();
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Registro añadido al fichero");
                }
                else if (apartado == 3)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("Introduce el DNI a buscar: ");
                    String dni = Console.ReadLine();
                    StreamReader ficheroLectura = new StreamReader(rutaFichero);
                    //Crear una variable para guardar la linea actual temporalmente en el siguiente bucle
                    String linea;
                    //Recorrer los registros
                    while ((linea = ficheroLectura.ReadLine()) != null)
                    {
                        //Si la linea contiene el DNI, mostrarla
                        if (linea.Contains(dni))
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("Registro encontrado: ");
                            Console.WriteLine(linea);
                        }
                    }
                    ficheroLectura.Close();
                }
                else if (apartado == 4)
                {
                    //Inicializar el lector del fichero
                    StreamReader ficheroLectura = new StreamReader(rutaFichero);
                    String linea;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Registros cuyo salario es superior a 2500 euros:");
                    Console.WriteLine("-------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.White;
                    //Recorrer los registros
                    while ((linea = ficheroLectura.ReadLine()) != null)
                    {
                        String[] campos = linea.Split('*', '?', '?');
                        if (int.Parse(campos[3]) > 2500)
                        {
                            Console.WriteLine(linea);
                        }
                    }
                    ficheroLectura.Close();
                }
                else if (apartado == 5)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("Introduce el DNI del registro a modificar: ");
                    string modificar = Console.ReadLine();

                    //Recorrer los registros
                    for (int i = 0; i < registros.Length; i++)
                    {
                        if (registros[i] != null)
                        {
                            //Dividir el registro actual en partes
                            String[] campos = registros[i].Split('*', '?', '?');

                            //Verificar si el DNI del registro actual es igual al DNI que se quiere modificar, y actualizar el salario
                            if (campos[0] == modificar)
                            {
                                //Pedir el nuevo salario
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write("Introduce el nuevo salario: ");
                                campos[3] = Console.ReadLine();
                                registros[i] = campos[0] + "*" + campos[1] + "?" + campos[2] + "?" + campos[3];

                                //Guardar el resgitro modificado en el archivo
                                StreamWriter ficheroEscritura = new StreamWriter(rutaFichero);
                                for (int i2 = 0; i2 < registros.Length; i++)
                                {
                                    if (registros[i2] != null)
                                    {
                                        ficheroEscritura.WriteLine(registros[i2]);
                                    }
                                }
                                ficheroEscritura.Close();
                                Console.WriteLine("Registro modificado y guardado en el fichero");
                            }
                        }
                    }

                }
                else if (apartado == 6)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("Introduce el DNI del registro a eliminar: ");
                    string eliminar = Console.ReadLine();
                    //Encontrar el registro a eliminar
                    for (int i = 0; i < registros.Length; i++)
                    {
                        //Si el registro no es nulo, dividirlo en partes y comprobar si el DNI es el que se quiere eliminar
                        if (registros[i] != null)
                        {
                            String[] campos = registros[i].Split('*', '?', '?');
                            //Si el DNI del registro actual es igual al DNI que se quiere eliminar, eliminar el registro de la matriz local
                            if (campos[0] == eliminar)
                            {
                                registros[i] = null;
                            }
                        }
                    }
                    //Guardar la matriz con el registro ya eliminado en el fichero
                    StreamWriter ficheroEscritura = new StreamWriter(rutaFichero);
                    //Recorrer la matriz y volcarla al fichero
                    for (int i = 0; i < registros.Length; i++)
                    {
                        if (registros[i] != null)
                        {
                            ficheroEscritura.WriteLine(registros[i]);
                        }
                    }
                    ficheroEscritura.Close();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Registro eliminado y guardado en el fichero");

                }
                else
                {
                    Console.WriteLine("Opcion no valida");
                }
            }


            Console.ReadKey();
            }
        }
    }
