using System;

/*
 * Metodos genericos
 */
namespace Genericos7
{
    class Program
    {
        static void Main(string[] args)
        {

            InformarTipo<Program>();

            var dflt = GetDefault<int>(10);
            var dflt2 = GetDefault("hola"); // Se infiere que es double a partir del argumento pasado
                                            // int dflt3 = GetDefault(DateTime.Now); Error, DateTime no se puede convertir a int implícitamente 
            Console.WriteLine($"dflt vale [{dflt}] - dflt2 vale [{dflt2}]");
        }

        static void InformarTipo<T>()
        {
            var a = typeof(T);
            Console.WriteLine(a.Name);
        }

        static T GetDefault<T>(T sinSentido)
        {
            return default(T);
        }
    }
}
