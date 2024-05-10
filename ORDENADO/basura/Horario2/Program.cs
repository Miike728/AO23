using System;
using System.Collections.Generic;
using System.Threading;

namespace HorarioTabla
{
    class Program
    {
        static void Main(string[] args)
        {
            string asignaturaActual = "";
            string asignaturaProxima = "";
            string asignaturaAnterior = "";
            while (true)
            {

                Console.SetCursorPosition(0, 0);
                //Console.Clear();

                // Cabecera
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("   Hora        | Lun  | Mar  |  Mie  | Jue  |  Vie  |");
                Console.ForegroundColor = ConsoleColor.White;

                // Define las horas y las asignaturas para cada día
                string[] horas = { "08:30-09:20", "09:20-10:10", "10:10-11:00", "11:00-11:20", "11:20-12:10", "12:10-13:00", "13:00-13:05", "13:05-13:55", "13:55-14:45" };
                string[,] asignaturas = new string[9, 5]
                {
                {"RL", "SO", "MM ", "MM", "RL "},
                {"RL", "SO", "MM ", "MM", "RL "},
                {"RL", "AO", "MM ", "MM", "RL "},
                {"--", "--", "-- ", "--", "-- "},
                {"AO", "AO", "AO ", "SO", "AO "},
                {"AO", "AO", "AO ", "SO", "AO "},
                {"--", "--", "-- ", "--", "-- "},
                {"SO", "MM", "FOL", "RL", "MM "},
                {"SO", "MM", "FOL", "RL", "FOL"}
                };


                // Obtén el día y la hora actuales
                int diaActual = (int)DateTime.Now.DayOfWeek;
                string horaActual = DateTime.Now.ToString("HH:mm");

                // Imprime la tabla
                for (int i = 0; i < 9; i++)
                {
                    Console.Write($"{horas[i]}    |");
                    for (int j = 0; j < 5; j++)
                    {
                        // Resalta la asignatura si es la hora y día actuales
                        if (EsHoraActual(horas[i], horaActual) && diaActual == j + 1)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }

                        Console.Write($"  {asignaturas[i, j]}  ");

                        // Restablece el color
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("|");


                    }
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                }



                // Diccionario para mapear códigos de asignaturas a nombres completos
                Dictionary<string, string> dicAsignaturas = new Dictionary<string, string>
            {
                {"RL", "Redes Locales"},
                {"SO", "Sistemas Operativos"},
                {"MM", "Montaje y Mantenimiento"},
                {"AO", "Aplicaciones Ofimáticas"},
                {"FOL", "Formación y Orientación Laboral"},
                {"--", "Descanso" }
            };


                // Encuentra asignatura actual y próxima

                TimeSpan tiempoRestante = TimeSpan.Zero;
                TimeSpan tiempoTranscurrido = TimeSpan.Zero;

                TimeSpan tiempoInicioDia = TimeSpan.Parse("8:30");
                TimeSpan tiempoFinDia = TimeSpan.Parse("14:45");
                TimeSpan tiempoActual = DateTime.Now.TimeOfDay;


                for (int i = 0; i < horas.Length; i++)
                {
                    if (EsHoraActual(horas[i], horaActual) && diaActual > 0 && diaActual < 6)
                    {
                        asignaturaAnterior = asignaturaActual; // Guarda la asignatura anterior
                        asignaturaActual = asignaturas[i, diaActual - 1];
                        if (i < horas.Length - 1) asignaturaProxima = asignaturas[i + 1, diaActual - 1];


                        // Si la asignatura cambia, reinicia el tiempo transcurrido
                        if (asignaturaAnterior != asignaturaActual)
                        {
                            tiempoTranscurrido = TimeSpan.Zero;
                        }


                        string[] rango = horas[i].Split('-');
                        tiempoTranscurrido = tiempoActual - TimeSpan.Parse(rango[0]);
                        tiempoRestante = TimeSpan.Parse(rango[1]) - tiempoActual;

                        break;
                    }
                }
                Console.WriteLine("ABC: " + asignaturaAnterior);
                Console.Write("XYZ: " + asignaturaActual);


                // Calcula el tiempo y porcentaje del día
                TimeSpan tiempoDiaTranscurrido = tiempoActual - tiempoInicioDia;
                TimeSpan tiempoDiaRestante = tiempoFinDia - tiempoActual;
                double porcentajeDia = (double)tiempoDiaTranscurrido.Ticks / (double)(tiempoFinDia - tiempoInicioDia).Ticks * 100;

                // Calcula el porcentaje de la asignatura actual
                double porcentajeAsignatura = (double)tiempoTranscurrido.Ticks / (double)(tiempoRestante + tiempoTranscurrido).Ticks * 100;


                // Imprime los resultados
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();


                Console.WriteLine($"Asignatura actual: {(dicAsignaturas.ContainsKey(asignaturaActual) ? dicAsignaturas[asignaturaActual] : "Ninguna")}");
                Console.WriteLine();
                Console.WriteLine($"Próxima asignatura: {(dicAsignaturas.ContainsKey(asignaturaProxima) ? dicAsignaturas[asignaturaProxima] : "Ninguna")}");
                Console.WriteLine();

                Console.WriteLine($"Tiempo transcurrido de asignatura: {tiempoTranscurrido.ToString(@"hh\:mm\:ss")} - {(porcentajeAsignatura):0.00}%");
                Console.WriteLine($"Tiempo restante de asignatura: {tiempoRestante.ToString(@"hh\:mm\:ss")} - {(100 - porcentajeAsignatura):0.00}%");
                Console.WriteLine();
                Console.WriteLine($"Tiempo transcurrido del día: {tiempoDiaTranscurrido.ToString(@"hh\:mm\:ss")} - {porcentajeDia:0.00}%");
                Console.WriteLine($"Tiempo restante del día: {tiempoDiaRestante.ToString(@"hh\:mm\:ss")} - {(100 - porcentajeDia):0.00}%");

                Thread.Sleep(2000);

            }
        }



        static bool EsHoraActual(string rangoHora, string horaActual)
        {
            string[] rango = rangoHora.Split('-');
            TimeSpan inicio = TimeSpan.Parse(rango[0]);
            TimeSpan fin = TimeSpan.Parse(rango[1]);
            TimeSpan ahora = TimeSpan.Parse(horaActual);

            return ahora >= inicio && ahora <= fin;
        }
    }
}
