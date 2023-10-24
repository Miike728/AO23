using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;         //Thread.Sleep(1000);
using System.Diagnostics.Eventing.Reader;

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
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("EJERCICIO 4");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Introduce el primer numero: ");
                num1 = double.Parse(Console.ReadLine());
                Console.Write("Introduce el segundo numero: ");
                num2 = double.Parse(Console.ReadLine());
                Console.Write("Introduce el tercer numero: ");
                num3 = double.Parse(Console.ReadLine());
                double media = (num1 + num2 + num3) / 3;
                if (media >= 5)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
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
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("EJERCICIO 5");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Introduce el primer número: ");
                numero1 = double.Parse(Console.ReadLine());
                Console.Write("Introduce el segundo número: ");
                numero2 = double.Parse(Console.ReadLine());
                suma = numero1 + numero2;
                Console.ForegroundColor = ConsoleColor.Blue;
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

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("EJERCICIO 6");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Introduce la contraseña: ");
                password = Console.ReadLine();
                if (password == defaultPassword)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
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
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("EJERCICIO 7");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Introduce el primer número: ");
                numero1 = double.Parse(Console.ReadLine());
                Console.Write("Introduce el segundo número: ");
                numero2 = double.Parse(Console.ReadLine());
                double mayor = numero1;
                if (numero1 >= numero2)
                {
                    // El mayor es el primero
                    double resultado = Math.Pow(numero1, numero2);

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("El resultado es: " + resultado);
                    Console.ReadLine();
                }
                else
                {
                    // El mayor es el segundo
                    double resultado = Math.Pow(numero2, numero1);

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("El resultado es: " + resultado);
                    Console.ReadLine();
                }
            }

            //EJERCICIO 8
            else if (ejercicio == 8)
            {
                // Variables
                double presion, temperatura;

                // Leer presión y temperatura
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("EJERCICIO 8");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Introduce la presión en atm: ");
                presion = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("EJERCICIO 8");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Presión: " + presion + "atm");

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Introduce la temperatura en Kelvin: ");
                temperatura = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("EJERCICIO 8");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Presión: " + presion + "atm");
                Console.WriteLine("Temperatura: " + temperatura + "K");

                //Condiciones
                if (presion > 2 && temperatura > 500)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Abrir válvula de seguridad");
                    Console.WriteLine("Reducir la temperatura");
                }
                else if (presion > 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Abrir válvula de seguridad");
                }
                else if (temperatura > 500)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Reducir la temperatura");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Todo en orden");
                }
                Console.ReadLine();
            }

            //EJERCICIO 9
            else if (ejercicio == 9)
            {
                int numero;
                bool noMultiplo2 = false;
                bool noMultiplo3 = false;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("EJERCICIO 9");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;

                // Pedimos al usuario que introduzca un número
                Console.Write("Introduce un número: ");
                numero = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Blue;
                // Comprobamos si el número es múltiplo de 2
                if (numero % 2 == 0)
                {
                    // Si lo es, imprimimos un mensaje de confirmación
                    Console.WriteLine("El número " + numero + " es múltiplo de 2");
                }
                else
                {
                    noMultiplo2 = true;
                }

                // Comprobamos si el número es múltiplo de 3
                if (numero % 3 == 0)
                {
                    // Si lo es, imprimimos un mensaje de confirmación
                    Console.WriteLine("El número " + numero + " es múltiplo de 3");
                }
                else
                {
                    noMultiplo3 = true;
                }

                //Comprobar si NO es múltiplo de ninguno de los 2 números
                if (noMultiplo2 == true && noMultiplo3 == true)
                {
                    Console.WriteLine("El número " + numero + " NO es múltiplo de 2 ni de 3");
                }

                Console.ReadLine();
            }

            //EJERCICIO 10
            else if (ejercicio == 10)
            {
                double precio;
                double descuento;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("EJERCICIO 10");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Introduce el precio: ");
                precio = double.Parse(Console.ReadLine());
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("EJERCICIO 10");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Precio introducido: " + precio);

                if (precio < 100)
                {
                    descuento = 0.1;
                }
                else
                {
                    descuento = 0.15;
                }
                double precioFinal = precio - (descuento * precio);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Descuento aplicado: " + descuento * 100 + "%");
                Console.WriteLine("Precio final: " + precioFinal);
                Console.ReadLine();
            }

            //EJERCICIO 11
            else if (ejercicio == 11)
            {
                double calificacion;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("EJERCICIO 11");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Introduce la calificación: ");
                calificacion = double.Parse(Console.ReadLine());
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("EJERCICIO 11");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Calificación introducida: " + calificacion);

                if (calificacion < 0 || calificacion > 10)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: Nota no válida");
                    Thread.Sleep(1000);
                }
                else if (calificacion >= 0 && calificacion < 5)
                {
                    Console.Write("Nota: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Suspenso");
                    Console.ReadLine();
                }
                else if (calificacion >= 5 && calificacion < 6.5)
                {
                    Console.Write("Nota: ");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("Aprobado");
                    Console.ReadLine();
                }
                else if (calificacion >= 6.5 && calificacion < 8.5)
                {
                    Console.Write("Nota: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Notable");
                    Console.ReadLine();
                }
                else
                {
                    Console.Write("Nota: ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("Sobresaliente");
                    Console.ReadLine();
                }
            }

            //EJERCICIO 12
            else if (ejercicio == 12)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("EJERCICIO 12");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Introduce un número: ");
                int numero = int.Parse(Console.ReadLine());
                int numeroInicial = numero;

                if (numero % 4 == 0)
                {
                    numero += 25; // Es lo mismo que poner "numero = numero + 25"
                }
                else if (numero % 5 == 0)
                {
                    numero += 50;
                }
                else
                {
                    numero += 100;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("EJERCICIO 12");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Número inicial: " + numeroInicial);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Número final: " + numero);
                Console.ReadLine();
            }

            //EJERCICIO 13
            else if (ejercicio == 13)
            {
                decimal temp;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("EJERCICIO 13");
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("Introduce la temperatura: ");
                temp = decimal.Parse(Console.ReadLine());
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("EJERCICIO 13");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Temperatura introducida: " + temp);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Estado: ");

                if (temp < 0)
                {
                    Console.WriteLine("SÓLIDO");
                }
                else if (temp >= 0 && temp <= 100)
                {
                    Console.WriteLine("LÍQUIDO");
                }
                else if (temp > 100 && temp <= 1000000)
                {
                    Console.WriteLine("VAPOR");
                }
                else
                {
                    Console.WriteLine("PLASMA");
                }
                Console.ReadLine();
            }

            //EJERCICIO 14
            else if (ejercicio == 14)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("EJERCICIO 14");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Elige una opción:");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Raíz de la suma");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        // Sumar los números
                        Console.Write("Introduce el primer número: ");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.Write("Introduce el segundo número: ");
                        int num2 = int.Parse(Console.ReadLine());
                        double suma = num1 + num2;
                        Console.ForegroundColor= ConsoleColor.Blue;
                        Console.WriteLine("La suma es: " + suma);
                        Console.ReadLine();
                        break;
                    case 2:
                        // Restar los números
                        Console.Write("Introduce el primer número: ");
                        int num12 = int.Parse(Console.ReadLine());
                        Console.Write("Introduce el segundo número: ");
                        int num22 = int.Parse(Console.ReadLine());
                        double resta = num12 - num22;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("La resta es: " + resta);
                        Console.ReadLine();
                        break;
                    case 3:
                        // Multiplicar los números
                        Console.Write("Introduce el primer número: ");
                        int num13 = int.Parse(Console.ReadLine());
                        Console.Write("Introduce el segundo número: ");
                        int num23 = int.Parse(Console.ReadLine());
                        double multiplicacion = num13 * num23;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("La multiplicación es: " + multiplicacion);
                        Console.ReadLine();
                        break;
                    case 4:
                        // Dividir los números
                        Console.Write("Introduce el primer número: ");
                        int num14 = int.Parse(Console.ReadLine());
                        Console.Write("Introduce el segundo número: ");
                        int num24 = int.Parse(Console.ReadLine());
                        double division = num14 / num24;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("La división es: " + division);
                        Console.ReadLine();
                        break;
                    case 5:
                        // Calcular la raíz cuadrada de la suma de los números
                        Console.Write("Introduce el primer número: ");
                        int num15 = int.Parse(Console.ReadLine());
                        Console.Write("Introduce el segundo número: ");
                        int num25 = int.Parse(Console.ReadLine());
                        double raiz = Math.Sqrt(num15 + num25);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("La raíz cuadrada de la suma es: " + raiz);
                        Console.ReadLine();
                        break;
                    default:
                        // Opción no válida
                        Console.ForegroundColor= ConsoleColor.Red;
                        Console.Write("Opción no válida");
                        Thread.Sleep(500);
                        Console.Write("!");
                        Thread.Sleep(250);
                        Console.Write("!");
                        Thread.Sleep(250);
                        Console.Write("!");
                        Thread.Sleep(500);
                        break;
                }
            }

            //EJERCICIO 15
            else if (ejercicio == 15)
            {


                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("EJERCICIO 15");
                Console.ForegroundColor = ConsoleColor.White;


            }

            //EJERCICIO 16
            else if (ejercicio == 16)
            {


                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("EJERCICIO 16");
                Console.ForegroundColor = ConsoleColor.White;

            }

            //EJERCICIO 17
            else if (ejercicio == 17)
            {


                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("EJERCICIO 17");
                Console.ForegroundColor = ConsoleColor.White;

            }

            //EJERCICIO 18
            else if (ejercicio == 18)
            {


                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("EJERCICIO 18");
                Console.ForegroundColor = ConsoleColor.White;
            }

            //EJERCICIO 19
            else if (ejercicio == 19)
            {


                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("EJERCICIO 19");
                Console.ForegroundColor = ConsoleColor.White;

            }

            //EJERCICIO 20
            else if (ejercicio == 20)
            {


                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("EJERCICIO 20");
                Console.ForegroundColor = ConsoleColor.White;

            }

            //EJERCICIO 21
            else if (ejercicio == 21)
            {


                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("EJERCICIO 21");
                Console.ForegroundColor = ConsoleColor.White;

            }

            //EJERCICIO 22
            else if (ejercicio == 22)
            {


                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("EJERCICIO 22");
                Console.ForegroundColor = ConsoleColor.White;

            }

            //EJERCICIO 23
            else if (ejercicio == 23)
            {


                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("EJERCICIO 23");
                Console.ForegroundColor = ConsoleColor.White;

            }

            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("El ejercicio \"" + ejercicio + "\" no es válido.");
                //////////////Thread.Sleep(1000);
                Console.ReadLine();
            }

        }
    }
}
