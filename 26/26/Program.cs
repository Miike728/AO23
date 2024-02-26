using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace _26
{
    internal class Program
    {
        static void Main(string[] args)
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
            //rehacer el menu con colores y decoracion:
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
                    String[] campos = linea.Split('*','?','?');
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
                //Eliminar registro. A partir del DNI se elimina el registro primero de la matriz y después se vuelca al fichero ya eliminado.
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

            Console.ReadKey();
        }
    }
}
