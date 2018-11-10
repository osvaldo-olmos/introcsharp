using System;

namespace ConstructoresYDestructores.src
{
    public class Viaje
    {
        protected static readonly DateTime globalStartTime;
        protected static int viajes;


        static Viaje()
        {
            globalStartTime = DateTime.Now;
            Console.WriteLine($"Comienzo a trabajar a las {globalStartTime.ToString("MMMM, MM dd, yyyy hh:mm:ss")}");
        }

        public Viaje()
        {
            ++viajes;
        }

        public static void Resumen(){
            Console.WriteLine($"Hora actual {DateTime.Now.ToString("MMMM, MM dd, yyyy hh:mm:ss")}\n" +
                                $"Comenzo la jornada a las {globalStartTime.ToString("MMMM, MM dd, yyyy hh:mm:ss")}\n" +
                                $"Tiempo de trabajo: {(DateTime.Now - globalStartTime).Seconds} segundos\n" +
                                $"{viajes} realizados");
        }



    }
}