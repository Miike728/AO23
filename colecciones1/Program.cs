using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colecciones1
{
    internal class Program
    {
        // Funcion para salto de linea
        private static void Salto()
        {
            Console.WriteLine();
        }

        // Funcion para doble salto de linea
        private static void DobleSalto()
        {
            Console.WriteLine();
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Colecciones 1:");
            Console.ForegroundColor = ConsoleColor.White;
            DobleSalto();

            // Crear una lista de int  random entre 1 y 25
            List<int> numeros = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 20; i++) // Lista de 20 nums
            {
                numeros.Add(random.Next(1, 26));
            }

            // Mostrar lista
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Lista de números: ");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (int numero in numeros)
            {
                Console.Write(numero + " ");
            }
            DobleSalto();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("--------------------------------------------");
            Salto();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Apartado A:");
            Salto();

            // Buscar el numero 2 en la lista y mostrar su posición
            int posicion = numeros.IndexOf(2);
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (posicion != -1)
            {
                Console.Write("El número 2 está en la posición ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(posicion);
            }
            else
            {
                Console.WriteLine("El número 2 no está en la lista");
            }
            Salto();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("--------------------------------------------");
            Salto();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Apartado B:");
            Salto();

            // Sumar todos los números de la lista
            int suma = 0;
            foreach (int numero in numeros)
            {
                suma += numero;
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("La suma de los números es ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(suma);
            Salto();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("--------------------------------------------");
            Salto();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Apartado C:");
            Salto();

            // Calcular la media de los número
            double media = suma / (double)numeros.Count;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("La media de los números es ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(media);
            Salto();
            
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("--------------------------------------------");
            Salto();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Apartado D:");
            Salto();

            // Caclulaar porcentaje de numeros mayores de 20
            int mayores20 = 0;
            foreach (int numero in numeros)
            {
                if (numero > 20)
                {
                    mayores20++;
                }
            }
            double porcentaje = (mayores20 / (double)numeros.Count) * 100;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("El porcentaje de números mayores de 20 es ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(porcentaje + "%");
            Salto();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("--------------------------------------------");
            Salto();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Apartado E:");
            Salto();

            // Mostrar valores sin repeticiones
            List<int> valoresUnicos = new List<int>();
            foreach (int numero in numeros)
            {
                if (!valoresUnicos.Contains(numero)) // Si el número no está en la lista de valores únicos
                {
                    valoresUnicos.Add(numero); // Añadirlo
                }
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Valores únicos: ");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (int numero in valoresUnicos)
            {
                Console.Write(numero + " ");
            }
            DobleSalto();


            Console.ReadLine();
        }
    }
}
