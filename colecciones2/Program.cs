using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colecciones2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Colecciones 2");
            Console.WriteLine();

            Console.Write("Ejercicio: ");
            int ejercicio = int.Parse(Console.ReadLine());

            if (ejercicio == 2)
            {
                // Crear una lista de tareas
                List<string> tareasString = new List<string>();

                // Introducir tarea desde consola
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Introduce una tarea (o 'fin' para terminar): ");
                Console.ForegroundColor = ConsoleColor.White;
                string tarea = Console.ReadLine();
                while (tarea != "fin")
                {
                    tareasString.Add(tarea);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Introduce una tarea (o 'fin' para terminar): ");
                    Console.ForegroundColor = ConsoleColor.White;
                    tarea = Console.ReadLine();
                }

                // Completar tarea: Elimina esa tarea y la pasa a una lista donde se almacenan las tareas completadas
                List<string> tareasCompletadas = new List<string>();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Tareas pendientes:");
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i < tareasString.Count; i++)
                {
                    Console.WriteLine(tareasString[i]);
                }

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Introduce el nombre de la tarea que quieres completar (o 'fin' para terminar): ");
                Console.ForegroundColor = ConsoleColor.White;
                string tareaCompletada = Console.ReadLine();
                while (tareaCompletada != "fin")
                {
                    tareasCompletadas.Add(tareaCompletada);
                    tareasString.Remove(tareaCompletada);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Tareas pendientes:");
                    Console.ForegroundColor = ConsoleColor.White;
                    for (int i = 0; i < tareasString.Count; i++)
                    {
                        Console.WriteLine(tareasString[i]);
                    }
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Introduce el nombre de la tarea que quieres completar (o 'fin' para terminar): ");
                    Console.ForegroundColor = ConsoleColor.White;
                    tareaCompletada = Console.ReadLine();
                }


                // Contar tareas pendintes
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Tareas pendientes: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(tareasString.Count);
                Console.WriteLine();

                // Mostrar tareas pendientes
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Tareas pendientes:");
                for (int i = 0; i < tareasString.Count; i++)
                {
                    Console.WriteLine(tareasString[i]);
                }
                Console.WriteLine();

                // Mostrar tareas completadas
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Tareas completadas:");
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i < tareasCompletadas.Count; i++)
                {
                    Console.WriteLine(tareasCompletadas[i]);
                }
            }

            else if (ejercicio == 3)
            {

            }

            else if (ejercicio == 4)
            {

            }

            else if (ejercicio == 5)
            {

            }

            else
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Ejercicio no válido.");
            }

            Console.ReadLine();
        }
    }
}
