using System;

class ConsumoRAM
{
    static void Main(string[] args)
    {
        // Inicializar variables
        int[] valoresAleatorios = new int[100000];
        int milisegundos = 10;
        int incremento = 1000000; // 10MB

        // Bucle infinito
        while (true)
        {
            // Generar valores aleatorios
            for (int i = 0; i < valoresAleatorios.Length; i++)
            {
                valoresAleatorios[i] = new Random().Next();
            }

            // Mostrar el consumo de RAM
            Console.WriteLine("Consumo de RAM: {0:F2} MB", valoresAleatorios.Length / 1048576);

            // Aumentar el consumo de RAM
            int[] nuevosValoresAleatorios = new int[valoresAleatorios.Length + incremento];
            for (int i = 0; i < valoresAleatorios.Length; i++)
            {
                nuevosValoresAleatorios[i] = valoresAleatorios[i];
            }
            valoresAleatorios = nuevosValoresAleatorios;

            // Esperar un milisegundo
            System.Threading.Thread.Sleep(milisegundos);
        }
    }
}
