using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_10_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool examenesAprobados, tareasAprobadas, comportamiento;
            examenesAprobados = false;
            tareasAprobadas = true;
            comportamiento = false;

            if (examenesAprobados && tareasAprobadas && comportamiento)
            {
                Console.WriteLine("Todo aprobado");
            }
            else
            {
                Console.WriteLine("Suspenso");
            };

            Console.ReadLine();
        }
    }
}
