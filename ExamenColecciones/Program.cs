using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExamenColecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            List<int> lista = new List<int>();


            // A
            lista.Capacity = 92;
            Console.WriteLine(lista.Capacity);
            Random aleatorio = new Random();
            for (int i = 0; i < 20; i++)
            {
                lista[i] = aleatorio.Next(-10, 10);
            }


            // B
            Console.WriteLine(lista.Capacity);
            int posicionesPorLlenar = lista.Capacity - lista.Count;
            Console.WriteLine("Posiciones por llenar:" + posicionesPorLlenar);
            

            // C
            int posCero = lista.IndexOf(0);
            if (posCero != -1)
            {
                Console.Write("Posición del primer 0: " + lista.IndexOf(0));
            } else
            {
                Console.Write("No hay ningún 0 en la lista.");
            }


            // D
            lista.Capacity = lista.Count;


            // E
            Random mayorDiez = new Random();
            int num = mayorDiez.Next(11, 101);
            lista.Insert(2, num);


            // F
            lista.RemoveAt(5);


            // G
            lista.Remove(3);


            // H
            List<int> lista2 = new List<int>();
            lista2.Capacity = lista.Capacity;
            for (int i = 0; i < lista.Count;i++)
            {
                lista2[i] = lista[i];
            }


            // I
            List<int> listaNegativos = new List<int>();
            for(int i = 0; i < lista.Count;i++)
            {
                if (lista[i] < 0)
                {
                    listaNegativos.Add(lista[i]);
                }
            }


            // J
            // 

            Console.ReadLine();

        }
    }
}
