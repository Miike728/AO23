using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int ejercicio;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Elige un ejercicio (4-101): ");
            Console.ForegroundColor= ConsoleColor.White;
            ejercicio = int.Parse(Console.ReadLine());


            //EJERCICIO 4
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

            //EJERCICIO 5
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

            //EJERCICIO 6
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

            //EJERCICIO 7
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
                    Console.ReadLine();
                }
            }

            //EJERCICIO 8
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

            //EJERCICIO 9
            else if (ejercicio == 9)
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

            //EJERCICIO 10
            else if (ejercicio == 10)
            {
                double precio;
                double descuento;

                Console.Write("Introduce el precio: ");
                precio = double.Parse(Console.ReadLine());
                if (precio < 100)
                {
                    descuento = 0.1;
                }
                else
                {
                    descuento = 0.15;
                }
                double precioFinal = precio - (descuento * precio);
                Console.WriteLine("Descuento aplicado: " + descuento*100 + "%");
                Console.WriteLine("Precio final: " + precioFinal);
                Console.ReadLine();
            }

            //EJERCICIO 11
            else if (ejercicio == 11)
            {
                    
            }

            //EJERCICIO 12
            else if (ejercicio == 12)
            {

            }

            //EJERCICIO 13
            else if (ejercicio == 13)
            {

            }

            //EJERCICIO 14
            else if (ejercicio == 14)
            {

            }

            //EJERCICIO 15
            else if (ejercicio == 15)
            {

            }

            //EJERCICIO 16
            else if (ejercicio == 16)
            {

            }

            //EJERCICIO 17
            else if (ejercicio == 17)
            {

            }

            //EJERCICIO 18
            else if (ejercicio == 18)
            {

            }

            //EJERCICIO 19
            else if (ejercicio == 19)
            {

            }

            //EJERCICIO 20
            else if (ejercicio == 20)
            {

            }

            //EJERCICIO 21
            else if (ejercicio == 21)
            {

            }

            //EJERCICIO 22
            else if (ejercicio == 22)
            {

            }

            //EJERCICIO 23
            else if (ejercicio == 23)
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
