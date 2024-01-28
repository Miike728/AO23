using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _20_10_23._01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ejercicio;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Elige un ejercicio (9-101): ");
            ejercicio = int.Parse(Console.ReadLine());
            if (ejercicio == 9)
            {
                int numero;

                // Pedimos al usuario que introduzca un número
                Console.WriteLine("Introduce un número: ");
                numero = int.Parse(Console.ReadLine());

                // Comprobamos si el número es múltiplo de 2
                if (numero % 2 == 0)
                {
                    // Si lo es, imprimimos un mensaje de confirmación
                    Console.WriteLine("El número " + numero + " es múltiplo de 2");
                }

                // Comprobamos si el número es múltiplo de 3
                if (numero % 3 == 0)
                {
                    // Si lo es, imprimimos un mensaje de confirmación
                    Console.WriteLine("El número " + numero + " es múltiplo de 3");
                    Console.ReadLine();
                }
            }

            else if (ejercicio == 10)
            {
                double precio, total;
                string descuento;

                Console.Write("Introduce el precio: ");
                precio = double.Parse(Console.ReadLine());
                
            }

            else if (ejercicio == 11)
            {

            }

            else if (ejercicio == 12)
            {

            }


            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ejercicio no válido.");
                Console.ReadLine();
            }
        }
    }
}
