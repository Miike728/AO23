using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_09_10_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //******EJERCICIO 2******
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Ejercicio 2:");

            Console.ForegroundColor= ConsoleColor.White;
            //Declaracion variables
            double precioHora, irpf, horasSemanales, horasMes, salarioBruto, salarioNeto;

            //Entrada de datos
            Console.Write("Introduce el precio que se paga por hora: ");
            precioHora = double.Parse(Console.ReadLine());
            Console.Write("Introduce las horas trabajadas semanales: ");
            horasSemanales = double.Parse(Console.ReadLine());
            Console.Write("Introduce el porcentaje de IRPF: ");
            irpf = double.Parse(Console.ReadLine());
            Console.WriteLine();

            //Miike
            //Cálculos
            horasMes = horasSemanales * 4;
            salarioBruto = precioHora * horasMes;
            salarioNeto = salarioBruto - (salarioBruto * irpf /100);

            //Escribir en consola los datos calculados
            Console.Write("Las horas totales trabajadas en el mes son: " + horasMes + "\n");
            Console.Write("El salario bruto es: " + salarioBruto + "\n");
            Console.Write("El salario neto es: " + salarioNeto + "\n");

            //Esperar enter para cerrar
            Console.ReadLine();
            //Miike



            //******EJERCICIO 3******
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Ejercicio 3:");

            Console.ForegroundColor = ConsoleColor.White;
            //Declaracion variables
            int valor;
            double raiz, elevadoSexta;
            short valorShort;
            double porcentaje;
            float porcentajeFloat;

            //Entrada del valor
            Console.Write("Introduce un valor: ");
            valor = int.Parse(Console.ReadLine());
            Console.WriteLine();
            //Miike

            //Calculos
            raiz = Math.Sqrt(valor);
            elevadoSexta = Math.Pow(valor, 6);
            //Escribir resultado en consola
            Console.Write("La raíz del valor es: " + raiz + "\n");

            //Almacenar en short el valor
            valorShort = (short)valor;
            //Escribir resultado en consola
            Console.Write("El valor almacenado en una variable short es: " +  valorShort + "\n");

            //Calcular 20% del valor y guardar en float
            porcentaje = valor * 20 / 100;
            //Convertir a float
            porcentajeFloat = (float)porcentaje;
            //Escribir resultados en consola
            Console.Write("El 20% del valor es: " + porcentaje + "\n");
            Console.Write("El 20% del valor almacenado en float es: " + porcentajeFloat + "\n");

            //Miike
            //Modificar valor +35%
            valor = valor + (valor * 35) / 100;
            Console.Write("Valor después de aumentar un 35%: " + valor + "\n");

            //Esperar a enter para cerrar
            Console.ReadLine();
        }
    }
}
