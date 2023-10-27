using System;
using System.Threading;         //Thread.Sleep(1000);

namespace B4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int ejercicio;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Elige un ejercicio (4-101): ");
            Console.ForegroundColor = ConsoleColor.White;
            ejercicio = int.Parse(Console.ReadLine());


            //EJERCICIO 4
            if (ejercicio == 4)
            {
                // Variables
                double num1, num2, num3;
                // Texto verde del ejercicio 4
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("EJERCICIO 4");
                Console.ForegroundColor = ConsoleColor.White;
                // SOlicitar los números al usuario
                Console.Write("Introduce el primer numero: ");
                num1 = double.Parse(Console.ReadLine());
                Console.Write("Introduce el segundo numero: ");
                num2 = double.Parse(Console.ReadLine());
                Console.Write("Introduce el tercer numero: ");
                num3 = double.Parse(Console.ReadLine());
                // Cálculo de la media
                double media = (num1 + num2 + num3) / 3;
                // Comprobar si es aprobado o suspenso
                if (media >= 5)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("Alumno aprobado");
                }
                // En cualquier otro caso es suspenso
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Alumno suspenso");
                }
                Console.ReadLine();
            }

            //EJERCICIO 5
            else if (ejercicio == 5)
            {
                // Variables
                double numero1, numero2, suma;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("EJERCICIO 5");
                Console.ForegroundColor = ConsoleColor.White;
                // Solicitar al usuario los números
                Console.Write("Introduce el primer número: ");
                numero1 = double.Parse(Console.ReadLine());
                Console.Write("Introduce el segundo número: ");
                numero2 = double.Parse(Console.ReadLine());
                // Calcular suma
                suma = numero1 + numero2;
                Console.ForegroundColor = ConsoleColor.Blue;
                // Comprobar la condición
                if (suma > 0)
                {
                    // Si es mayor que 0 entonces calcula la raíz. Se podría poner mayor o igual que 0 pero no tendría mucho sentido
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
                // Variables
                string password, defaultPassword;
                defaultPassword = "1234";

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("EJERCICIO 6");
                Console.ForegroundColor = ConsoleColor.White;
                // Solicitar al usuario la contraseña
                Console.Write("Introduce la contraseña: ");
                password = Console.ReadLine();
                // COmprobar si la coontraseña es correcta
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
                // Variable
                double numero1, numero2;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("EJERCICIO 7");
                Console.ForegroundColor = ConsoleColor.White;
                // Entrada de los 2 números
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
                presion = double.Parse(Console.ReadLine());
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("EJERCICIO 8");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Presión: " + presion + "atm");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Introduce la temperatura en Kelvin: ");
                temperatura = double.Parse(Console.ReadLine());
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
                // Declarar variables
                double numero;
                bool noMultiplo2 = false;
                bool noMultiplo3 = false;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("EJERCICIO 9");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;

                // Entrada de número
                Console.Write("Introduce un número: ");
                numero = double.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Blue;
                // Comprobamos si el número es múltiplo de 2
                if (numero % 2 == 0)
                {
                    Console.WriteLine("El número " + numero + " es múltiplo de 2");
                }
                else
                {
                    noMultiplo2 = true;
                }

                // Comprobamos si el número es múltiplo de 3
                if (numero % 3 == 0)
                {
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
                // Declarar variables
                double precio;
                double descuento;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("EJERCICIO 10");
                Console.ForegroundColor = ConsoleColor.White;
                // Entrada de datos
                Console.Write("Introduce el precio: ");
                precio = double.Parse(Console.ReadLine());
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("EJERCICIO 10");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Precio introducido: " + precio);
                // Condiciones
                if (precio < 100)
                {
                    descuento = 0.1;
                }
                else
                {
                    descuento = 0.15;
                }
                // Cálculos
                double precioFinal = precio - (descuento * precio);
                // Mostrar resultados en consola
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Descuento aplicado: " + descuento * 100 + "%");
                Console.WriteLine("Precio final: " + precioFinal);
                Console.ReadLine();
            }

            //EJERCICIO 11
            else if (ejercicio == 11)
            {
                // Variable
                double calificacion;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("EJERCICIO 11");
                Console.ForegroundColor = ConsoleColor.White;
                // Entrada de datos
                Console.Write("Introduce la calificación: ");
                calificacion = double.Parse(Console.ReadLine());
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("EJERCICIO 11");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Calificación introducida: " + calificacion);
                // Condiciones
                if (calificacion < 0 || calificacion > 10)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: Nota no válida");
                    Thread.Sleep(1000);
                }
                else if (calificacion < 5)
                {
                    Console.Write("Nota: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Suspenso");
                    Console.ReadLine();
                }
                else if (calificacion < 6.5)
                {
                    Console.Write("Nota: ");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("Aprobado");
                    Console.ReadLine();
                }
                else if (calificacion < 8.5)
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
                // Entrada de datos
                Console.Write("Introduce un número: ");
                double numero = double.Parse(Console.ReadLine());
                double numeroInicial = numero;
                // Condiciones
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
                // Mostrar resultados en consola
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
                // Variable
                double temp;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("EJERCICIO 13");
                Console.ForegroundColor = ConsoleColor.White;
                // Entrada de datos
                Console.Write("Introduce la temperatura: ");
                temp = double.Parse(Console.ReadLine());
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("EJERCICIO 13");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Temperatura introducida: " + temp);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Estado: ");
                // Condiciones
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
                // Menú
                Console.WriteLine("Elige una opción:");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Raíz de la suma");
                // Esperar a que el usuario elija opción
                double opcion = double.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        // Sumar los números
                        Console.Write("Introduce el primer número: ");
                        double num1 = double.Parse(Console.ReadLine());
                        Console.Write("Introduce el segundo número: ");
                        double num2 = double.Parse(Console.ReadLine());
                        double suma = num1 + num2;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("La suma es: " + suma);
                        Console.ReadLine();
                        break;
                    case 2:
                        // Restar los números
                        Console.Write("Introduce el primer número: ");
                        double num12 = double.Parse(Console.ReadLine());
                        Console.Write("Introduce el segundo número: ");
                        double num22 = double.Parse(Console.ReadLine());
                        double resta = num12 - num22;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("La resta es: " + resta);
                        Console.ReadLine();
                        break;
                    case 3:
                        // Multiplicar los números
                        Console.Write("Introduce el primer número: ");
                        double num13 = double.Parse(Console.ReadLine());
                        Console.Write("Introduce el segundo número: ");
                        double num23 = double.Parse(Console.ReadLine());
                        double multiplicacion = num13 * num23;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("La multiplicación es: " + multiplicacion);
                        Console.ReadLine();
                        break;
                    case 4:
                        // Dividir los números
                        Console.Write("Introduce el primer número: ");
                        double num14 = double.Parse(Console.ReadLine());
                        Console.Write("Introduce el segundo número: ");
                        double num24 = double.Parse(Console.ReadLine());
                        double division = num14 / num24;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("La división es: " + division);
                        Console.ReadLine();
                        break;
                    case 5:
                        // Calcular la raíz cuadrada de la suma de los números
                        Console.Write("Introduce el primer número: ");
                        double num15 = double.Parse(Console.ReadLine());
                        Console.Write("Introduce el segundo número: ");
                        double num25 = double.Parse(Console.ReadLine());
                        double raiz = Math.Sqrt(num15 + num25);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("La raíz cuadrada de la suma es: " + raiz);
                        Console.ReadLine();
                        break;
                    default:
                        // Opción no válida
                        Console.ForegroundColor = ConsoleColor.Red;
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
                bool cuotaMinima = false;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("EJERCICIO 15");
                Console.ForegroundColor = ConsoleColor.White;

                // Pedimos al usuario la cantidad de litros consumidos
                Console.Write("Introduce la cantidad de litros consumidos: ");
                double litros = double.Parse(Console.ReadLine());

                // Calculamos el gasto
                double gasto = 0;
                if (litros <= 50)
                {
                    // Primeros 50l gratis
                    gasto = 0;
                }
                else if (litros <= 200)
                {
                    // De 50l a 200l, precio de 4,75 euros el litro
                    gasto = (litros - 50) * 4.75;
                }
                else
                {
                    // Desde 200l, precio de 20 euros el litro
                    gasto = (litros - 200) * 20 + 150 * 4.75;
                }

                // Cuota mínima
                if (gasto < 45)
                {
                    gasto = 45;
                    cuotaMinima = true;
                }

                // Mostrar en consola el resultado
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("El gasto de agua es de " + gasto + " euros");
                Console.ForegroundColor = ConsoleColor.Cyan;
                if (cuotaMinima)
                {
                    Console.WriteLine("Cuota mínima aplicada");
                }
                else
                {
                    Console.WriteLine("Cuota mínima NO aplicada");
                }
                Console.ReadLine();
            }

            //EJERCICIO 16
            else if (ejercicio == 16)
            {
                // Variables
                double precio1, precio2, precio3;
                double descuento = 0;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("EJERCICIO 16");
                Console.ForegroundColor = ConsoleColor.White;
                // Leer los precios
                Console.Write("Introduzca el precio del primer artículo: ");
                precio1 = double.Parse(Console.ReadLine());
                Console.Write("Introduzca el precio del segundo artículo: ");
                precio2 = double.Parse(Console.ReadLine());
                Console.Write("Introduzca el precio del tercer artículo: ");
                precio3 = double.Parse(Console.ReadLine());

                // Calcular suma de los números
                double sumaTotal = precio1 + precio2 + precio3;

                // Calcular el descuento
                if (sumaTotal < 500)
                {
                    // No hay descuento
                }
                else if (sumaTotal < 1000)
                {
                    descuento = sumaTotal * 0.03;
                }
                else if (sumaTotal < 2000)
                {
                    descuento = sumaTotal * 0.05;
                }
                else if (sumaTotal <= 3000)
                {
                    descuento = sumaTotal * 0.07;
                }
                else
                {
                    descuento = sumaTotal * 0.10;
                }

                // Calcular el total a pagar
                double importeTotal = sumaTotal - descuento;

                // Enseñar los resultados por pantalla
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("La suma total de los precios es: " + sumaTotal + " euros");
                Console.WriteLine("El importe total a pagar es: " + importeTotal + " euros");
                Console.ReadLine();
            }

            //EJERCICIO 17
            else if (ejercicio == 17)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("EJERCICIO 17");
                Console.ForegroundColor = ConsoleColor.White;

                // Entrada de datos
                Console.Write("Introduce la tasa por hora: ");
                double tasaPorHora = double.Parse(Console.ReadLine());
                Console.Write("Introduce las horas trabajadas: ");
                double horasTrabajadas = double.Parse(Console.ReadLine());

                // Cálculos
                double salarioBruto = 0;
                if (horasTrabajadas <= 38)
                {
                    salarioBruto = tasaPorHora * horasTrabajadas;
                }
                else
                {
                    salarioBruto = tasaPorHora * 38 + (horasTrabajadas - 38) * (tasaPorHora * 1.5);
                }

                double salarioNeto = salarioBruto;
                if (salarioBruto > 300)
                {
                    salarioNeto = salarioBruto - salarioBruto * 0.1;
                }

                // Imprimir los resultados
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Salario bruto: " + salarioBruto + " euros");
                Console.Write("Salario neto: " + salarioNeto + " euros");
                Console.ReadLine();
            }

            //EJERCICIO 18
            else if (ejercicio == 18)
            {
                // Variable
                int indicador;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("EJERCICIO 18");
                Console.ForegroundColor = ConsoleColor.White;
                //Entrada del valor
                Console.Write("Introduce un valor: ");
                indicador = int.Parse(Console.ReadLine());
                // Switch
                switch (indicador)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("CALOR");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.ForegroundColor= ConsoleColor.DarkYellow;
                        Console.Write("TEMPLADO");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("FRIO");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("FUERA DE RANGO");
                        Console.ReadLine();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("ERROR");
                        Thread.Sleep(200);
                        Console.Write("!");
                        Thread.Sleep(200);
                        Console.Write("!");
                        Thread.Sleep(200);
                        Console.Write("!");
                        Thread.Sleep(750);
                        break;
                }
            }
            
            //EJERCICIO 19
            else if (ejercicio == 19)
            {
                // Variable 
                char color;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("EJERCICIO 19");
                Console.ForegroundColor = ConsoleColor.White;
                //Entrada de valor de color
                Console.Write("Introduce un valor: ");
                color = char.Parse(Console.ReadLine());

                // Switch
                switch (color)
                {
                    case 'r':
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ROJO");
                        break;
                    case 'R':
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ROJO");
                        break;
                    case 'v':
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("VERDE");
                        break;
                    case 'V':
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("VERDE");
                        break;
                    case 'a':
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("AZUL");
                        break;
                    case 'A':
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("AZUL");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor= ConsoleColor.Black;
                        Console.WriteLine("NEGRO");
                        break;
                }    
                Console.ReadLine();
            }

            //EJERCICIO 20
            else if (ejercicio == 20)
            {
                //Declaración de variables
                double numero;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("EJERCICIO 20");
                Console.ForegroundColor = ConsoleColor.White;
                // Pedimos al usuario que introduzca un número
                Console.Write("Introduce un número: ");
                numero = double.Parse(Console.ReadLine());
                
                // Comprobar cuantas cifras tiene el número
                if (numero <0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("El número es negativo");
                }
                else if (numero <10)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("El número tiene 1 cifra");
                }
                else if (numero <100)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("El número tiene 2 cifras");
                }
                else if (numero < 1000)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("El número tiene 3 cifras");
                }
                else if (numero < 10000)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("El número tiene 4 cifras");
                }
                else if (numero < 100000)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("El número tiene 5 cifras");
                }
                else if (numero < 1000000)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("El número tiene 6 cifras");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("El número tiene más de 6 cifras");
                }
            Console.ReadLine();
            }

            //EJERCICIO 21
            else if (ejercicio == 21)
            {
                // Variables
                double a, b, c, x1, x2;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("EJERCICIO 21");
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("Introduce el coeficiente \"a\" ");
                a = double.Parse(Console.ReadLine());
                Console.Write("Introduce el coeficiente \"b\" ");
                b = double.Parse(Console.ReadLine());
                Console.Write("Introduce el coeficiente \"c\" ");
                c = double.Parse(Console.ReadLine());

                if (a == 0)
                {
                    x1 = -c / -b;
                    x2 = x1;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("x1= " + x1);
                    Console.WriteLine("x2= " + x2);
                }
                else if (b == 0)
                {
                    if (-c / a >= 0)
                    {
                        x1 = Math.Sqrt((-c) / (a));
                        x2 = Math.Sqrt(-((-c) / (a)));
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("x1= " + x1);
                        Console.WriteLine("x2= " + x2);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Raíz negativa, no hay solución");
                    }
                }
                else if (c == 0)
                {
                    x1 = 0;
                    x2 = (-a) / (-b);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("x1= " + x1);
                    Console.WriteLine("x2= " + x2);
                }
                ////////////////
                

                Console.ReadLine();
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
