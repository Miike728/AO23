using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_10_23._45678
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ejercicio;
            Console.Write("Elige un ejercicio (4-8): ");
            ejercicio = int.Parse(Console.ReadLine());
            Console.Clear();

            if (ejercicio == 4)
            {
                double num1, num2, num3;
                Console.Write("Introduce el primer numero: ");
                num1 = double.Parse(Console.ReadLine());
                Console.Write("Introduce el segundo numero: ");
                num2 = double.Parse(Console.ReadLine());
                Console.Write("Introduce el tercer numero: ");
                num3 = double.Parse(Console.ReadLine());
                double media = (num1 + num2 + num3) / 3;
                if (media >= 5)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Alumno aprobado");
                }
                else if (media < 5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Alumno suspenso");
                }
                Console.ReadLine();
            }

            else if (ejercicio == 5)
            {
                double numero1, numero2, suma;
                Console.Write("Introduce el primer número: ");
                numero1 = double.Parse(Console.ReadLine());
                Console.Write("Introduce el segundo número: ");
                numero2 = double.Parse(Console.ReadLine());
                suma = numero1 + numero2;
                if (suma >= 0)
                {
                    double raiz = Math.Sqrt(suma);
                    Console.Write("La raíz cuadrada de la suma es: " + raiz);
                }
                else
                {
                    Console.Write("No se puede calcular la raíz cuadrada de un número negativo.");
                }

                Console.ReadLine();
            }

            else if (ejercicio == 6)
            {
                string password, defaultPassword;
                defaultPassword = "1234";

                Console.Write("Introduce la contraseña: ");
                password = Console.ReadLine();
                if (password == defaultPassword)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Contraseña correcta!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Contraseña incorrecta.");
                }
                Console.ReadLine();
            }

            else if (ejercicio == 7)
            {
                double numero1, numero2;
                Console.WriteLine("Introduce el primer número: ");
                numero1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Introduce el segundo número: ");
                numero2 = double.Parse(Console.ReadLine());
                double mayor = numero1;
                if (numero1 >= numero2)
                {
                    // El mayor es el primero
                    double resultado = Math.Pow(numero1, numero2);

                    Console.Write("El resultado es: " + resultado);
                }
                else
                {
                    // El mayor es el segundo
                    double resultado = Math.Pow(numero2, numero1);

                    Console.Write("El resultado es: " + resultado);
                }
                Console.ReadLine();
            }

            else if (ejercicio == 8)
            {
                Console.Write("Introduce la presión: ");
                double presion = double.Parse(Console.ReadLine());
                Console.Write("Introduce la temperatura: ");
                double temperatura = double.Parse(Console.ReadLine());

                if (presion > 2 && temperatura > 500)
                {
                    Console.WriteLine("Abrir válvula de seguridad");
                    Console.WriteLine("Reducir la temperatura");
                }
                else if (presion > 2)
                {
                    Console.WriteLine("Abrir válvula de seguridad");
                }
                if (temperatura > 500)
                {
                    Console.WriteLine("Reducir la temperatura");
                }
                else
                {
                    Console.WriteLine("Todo en orden");
                }
                Console.ReadLine();
            }
            else
            {
                Console.Write("Ejercicio no válido."); Console.ReadLine();
            }
        }
    }
}
