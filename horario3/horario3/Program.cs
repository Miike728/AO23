using System;
using System.Collections.Generic;
using System.Threading;

namespace horario3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definir el horario
            List<Clase> horario = new List<Clase>()
            {
                new Clase("REDES", "8:30-9:20", "lun"),
                new Clase("REDES", "9:20-10:10", "lun"),
                new Clase("REDES", "10:10-11:00", "lun"),
                new Clase("Descanso1", "11:00-11:20", "lun"),
                new Clase("OFI", "11:20-12:10", "lun"),
                new Clase("OFI", "12:10-13:00", "lun"),
                new Clase("Descanso2", "13:00-13:05", "lun"),
                new Clase("SOM", "13:05-13:55", "lun"),
                new Clase("SOM", "13:55-14:45", "lun"),
                // Resto del horario...
            };

            // Obtener la hora actual
            DateTime horaActual = DateTime.Now;

            // Actualizar la pantalla cada segundo
            while (true)
            {
                // Limpiar la pantalla
                Console.Clear();

                // Buscar la clase actual
                Clase claseActual = null;
                foreach (var clase in horario)
                {
                    if (clase.Dia == horaActual.ToString("ddd") && clase.HoraInicio <= horaActual.TimeOfDay && clase.HoraFin > horaActual.TimeOfDay)
                    {
                        claseActual = clase;
                        break;
                    }
                }

                // Mostrar el horario en forma de tabla
                Console.WriteLine("Horario:");
                Console.WriteLine("Hora\t\tLun\tMar\tMie\tJue\tVie");
                foreach (var clase in horario)
                {
                    Console.Write($"{clase.HoraInicio}-{clase.HoraFin}\t");
                    Console.Write(clase.Dia == "lun" ? clase.Materia : "\t");
                    Console.Write(clase.Dia == "mar" ? clase.Materia : "\t");
                    Console.Write(clase.Dia == "mie" ? clase.Materia : "\t");
                    Console.Write(clase.Dia == "jue" ? clase.Materia : "\t");
                    Console.Write(clase.Dia == "vie" ? clase.Materia : "\t");
                    Console.WriteLine();
                }

                // Mostrar la clase actual y el tiempo restante
                if (claseActual != null)
                {
                    TimeSpan tiempoRestante = claseActual.HoraFin - horaActual.TimeOfDay;
                    Console.WriteLine();
                    Console.WriteLine($"Clase actual: {claseActual.Materia}");
                    Console.WriteLine($"Hora actual: {horaActual.ToString("HH:mm")}");
                    Console.WriteLine($"Tiempo restante: {tiempoRestante.ToString(@"hh\:mm")}");
                }

                // Esperar un segundo
                Thread.Sleep(1000);

                // Actualizar la hora actual
                horaActual = DateTime.Now;
            }
        }
    }

    internal class Clase
    {
        public string Materia { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
        public string Dia { get; set; }

        public Clase(string materia, string horario, string dia)
        {
            Materia = materia;
            HoraInicio = TimeSpan.Parse(horario.Split('-')[0]);
            HoraFin = TimeSpan.Parse(horario.Split('-')[1]);
            Dia = dia;
        }
    }
}
