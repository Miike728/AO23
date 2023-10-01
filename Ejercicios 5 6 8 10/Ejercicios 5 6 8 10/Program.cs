using System;
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
                Console.WriteLine("Elige una opción: 5, 6, 8, 10 o 's' para salir");
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
    }
}
 
