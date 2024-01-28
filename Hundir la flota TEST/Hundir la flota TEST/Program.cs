using System;
using System.Collections.Generic;

class HundirLaFlota
{
    static char[,] tableroJugador, tableroIA;
    static int tamañoTablero = 10;
    static char agua = '~', barco = 'B', fallo = 'X', acierto = '!';
    static List<int> tamañosBarcos = new List<int>() { 5, 4, 3, 3, 2 }; // Tamaños de los barcos
    static Random rnd = new Random();

    static void Main()
    {
        // Inicializar tableros
        tableroJugador = new char[tamañoTablero, tamañoTablero];
        tableroIA = new char[tamañoTablero, tamañoTablero];
        InicializarTablero(tableroJugador);
        InicializarTablero(tableroIA);

        // Colocar barcos
        ColocarBarcos(tableroJugador);
        ColocarBarcos(tableroIA);

        // Juego
        Jugar();
    }

    static void InicializarTablero(char[,] tablero)
    {
        for (int i = 0; i < tamañoTablero; i++)
            for (int j = 0; j < tamañoTablero; j++)
                tablero[i, j] = agua;
    }

    static void ColocarBarcos(char[,] tablero)
    {
        foreach (int tamaño in tamañosBarcos)
        {
            bool colocado = false;
            while (!colocado)
            {
                int fila = rnd.Next(tamañoTablero);
                int columna = rnd.Next(tamañoTablero);
                bool horizontal = rnd.Next(2) == 0;
                colocado = IntentarColocarBarco(tablero, fila, columna, tamaño, horizontal);
            }
        }
    }

    static bool IntentarColocarBarco(char[,] tablero, int fila, int columna, int tamaño, bool horizontal)
    {
        // Verificar si el barco cabe en el tablero
        if (horizontal)
        {
            if (columna + tamaño > tamañoTablero) return false;
            for (int i = 0; i < tamaño; i++)
                if (tablero[fila, columna + i] == barco) return false;
        }
        else
        {
            if (fila + tamaño > tamañoTablero) return false;
            for (int i = 0; i < tamaño; i++)
                if (tablero[fila + i, columna] == barco) return false;
        }

        // Colocar el barco
        for (int i = 0; i < tamaño; i++)
        {
            if (horizontal)
                tablero[fila, columna + i] = barco;
            else
                tablero[fila + i, columna] = barco;
        }

        return true;
    }

    static void Jugar()
    {
        while (true)
        {
            // Turno del jugador
            Console.Clear();
            MostrarTablero(tableroIA);
            Console.WriteLine("Tu turno. Ingresa fila y columna para atacar (ejemplo: 3 5): ");
            string[] input = Console.ReadLine().Split(' ');
            int filaJugador = int.Parse(input[0]);
            int columnaJugador = int.Parse(input[1]);

            // Procesar ataque del jugador
            ProcesarAtaque(tableroIA, filaJugador, columnaJugador);

            // Turno de la IA
            int filaIA = rnd.Next(tamañoTablero);
            int columnaIA = rnd.Next(tamañoTablero);

            // Procesar ataque de la IA
            ProcesarAtaque(tableroJugador, filaIA, columnaIA);

            // Mostrar resultado del turno
            Console.WriteLine($"La IA atacó: {filaIA} {columnaIA}");
        }
    }

    static void ProcesarAtaque(char[,] tablero, int fila, int columna)
    {
        if (tablero[fila, columna] == barco)
        {
            Console.WriteLine("¡Acierto!");
            tablero[fila, columna] = acierto;
        }
        else
        {
            Console.WriteLine("Fallaste.");
            tablero[fila, columna] = fallo;
        }
    }

    static void MostrarTablero(char[,] tablero)
    {
        for (int i = 0; i < tamañoTablero; i++)
        {
            for (int j = 0; j < tamañoTablero; j++)
            {
                Console.Write(tablero[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
