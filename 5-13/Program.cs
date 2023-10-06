using System;
using System.Diagnostics;
using System.Xml.Schema;

namespace MiniProgramas
{
    class Program
    {
        static void Main(string[] args)
        {
            bool seguir = true;

            while (seguir)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Elige una opción: 5, 6, 8, 10, 11, 12, 13, 14, 15 o 's' para salir");
                Console.ForegroundColor = ConsoleColor.Red;
                string opcion = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

                switch (opcion)
                {
                    case "5":
                        Opcion5();
                        break;
                    case "6":
                        Opcion6();
                        break;
                    case "8":
                        Opcion8();
                        break;
                    case "10":
                        Opcion10();
                        break;
                    case "11":
                        Opcion11();
                        break;
                    case "12":
                        Opcion12();
                        break;
                    case "13":
                        Opcion13();
                        break;
                    case "14":
                        Opcion14();
                        break;
                    case "15":
                        Opcion15();
                        break;
                    case "s":
                        seguir = false;
                        break;
                }
            }
        }

        static void Opcion5()
        {
            Console.Write("Introduce el precio del producto: ");
            double precio = double.Parse(Console.ReadLine());

            Console.Write("Introduce la cantidad: ");
            short cantidad = short.Parse(Console.ReadLine());
            Console.WriteLine();

            double total = precio * cantidad;
            Console.Write("El precio del producto es " + precio);
            Console.Write(" y la cantidad que compra es " + cantidad);
            Console.Write(" por lo tanto debe pagar " + total);
            Console.WriteLine(" euros. Vuelva pronto.");

            Console.ReadLine();
        }

        static void Opcion6()
        {
            Console.Write("Introduce el primer número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Introduce el segundo número: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double suma = num1 + num2;
            double resta = num1 - num2;
            double multiplicacion = num1 * num2;

            Console.WriteLine("Suma:" + suma);
            Console.WriteLine("Resta:" + resta);
            Console.WriteLine("Multiplicación:" + multiplicacion);

            Console.ReadLine();
        }

        static void Opcion8()
        {
            const double R = 0.082;

            Console.Write("Introduce el volumen en litros: ");
            double V = double.Parse(Console.ReadLine());

            Console.Write("Introduce el número de moles: ");
            double n = double.Parse(Console.ReadLine());

            Console.Write("Introduce la temperatura en Kelvin: ");
            double T = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double P = (n * R * T) / V;

            Console.Write("Con un volumen de " + V);
            Console.Write(" litros, y una temperatura de " + T);
            Console.Write(" kelvin, " + n);
            Console.Write(" moles de un gas ideal tienen una presión de " + P);
            Console.WriteLine(" atmósferas.");

            Console.ReadLine();
        }

        static void Opcion10()
        {
            Console.Write("Introduce las horas trabajadas en el mes: ");
            double horasTrabajadas = double.Parse(Console.ReadLine());

            Console.Write("Introduce la tasa por hora: ");
            double tasaHora = double.Parse(Console.ReadLine());

            Console.Write("Introduce el IRPF en porcentaje: ");
            double irpf = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double salarioBruto = horasTrabajadas * tasaHora;
            double impuesto = (salarioBruto * irpf) / 100;
            double salarioNeto = salarioBruto - impuesto;

            Console.Write("Salario bruto: " + salarioBruto);
            Console.WriteLine(" euros");
            Console.Write("Salario neto: " + salarioNeto);
            Console.WriteLine(" euros");

            Console.ReadLine();
        }

        static void Opcion11()
        {
            double espacio, tiempo;
            Console.Write("Introduce el espacio en metros: ");
            espacio = double.Parse(Console.ReadLine());
            Console.Write("Introduce el tiempo en segundos: ");
            tiempo = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double velocidad;
            velocidad = espacio / tiempo;
            Console.Write("Velocidad: " + velocidad + "metros/segundo");

            Console.ReadLine();
        }

        static void Opcion12()
        {
            double lado, area, perimetro, diagonal;
            Console.Write("Introduce el lado del cuadrado: ");
            lado = double.Parse(Console.ReadLine());

            perimetro = 4 * lado;
            diagonal = lado * Math.Sqrt(2);
            area = Math.Sqrt(lado);

            Console.WriteLine();

            Console.WriteLine("Perimetro: " + perimetro);
            Console.WriteLine("Diagonal: " + diagonal);
            Console.WriteLine("Area: " + area);

            Console.ReadLine();
        }

        static void Opcion13()
        {
            double catetoA, catetoB, hipotenusa;

            Console.Write("Introduce el valor del cateto A: ");
            catetoA = double.Parse(Console.ReadLine());
            Console.Write("Introduce el valor del cateto B: ");
            catetoB = double.Parse(Console.ReadLine());
            Console.WriteLine();

            hipotenusa = Math.Sqrt(catetoA * catetoA + catetoB * catetoB);

            hipotenusa = Math.Round(hipotenusa, 2);

            Console.WriteLine("La hipotenusa es: " + hipotenusa);

            Console.ReadLine();
        }
        static void Opcion14()
        {
            double precioInicial;
            double porcentajeDescuento;
            double precioFinal = 0;
            double ahorro;

            Console.Write("Introduce el precio del producto:");
            precioInicial = double.Parse(Console.ReadLine());
            Console.Write("Introduce el porcentaje de descuento:");
            porcentajeDescuento = double.Parse(Console.ReadLine());
            Console.WriteLine();

            precioFinal = precioInicial * (porcentajeDescuento / 100);
            ahorro = precioInicial - precioFinal;

            Console.WriteLine("Al aplicar un " + porcentajeDescuento + " por ciento de descuento el precio final del producto es de " + precioFinal + " y por lo tanto se ahorra " + ahorro + " euros.");

            Console.ReadLine();
        }
        static void Opcion15()
        {
            double d, a, v, raiz, AL;

            Console.Write("Introduce 'a': ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine();

            raiz = Math.Sqrt(3);
            d = (raiz * a);
            AL = 4 * (a * a);

            v = a * a * a;

            Console.WriteLine("D= " + d);
            Console.WriteLine("AL= " + AL);
            Console.WriteLine("V= " + v);

            Console.ReadLine();
        }

    }
}

