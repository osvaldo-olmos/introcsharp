using System;
using System.Threading;
using ConstructoresYDestructores.src;

namespace ConstructoresYDestructores
{
    class Program
    {
        static void Main(string[] args)
        {
            TestViajes();
        }

        private static void TestPersona()
        {
            Persona person = new Persona();

            Console.WriteLine("Nombre: {0}, Edad: {1}", person.Nombre, person.Edad);
            Console.WriteLine("Presionar una tecla para finalizar.");
            Console.ReadKey();
        }

        static void TestFormas()
        {
            double radio = 2.5;
            double altura = 3.0;

            Circulo circulo = new Circulo(radio);
            Cilindro tubo = new Cilindro(radio, altura);

            Console.WriteLine("Area del circulo = {0:F2}", circulo.Area());
            Console.WriteLine("Area del cilindro = {0:F2}", tubo.Area());

            Console.WriteLine("Presione una tecla para terminar.");
            Console.ReadKey();
        }

        static void TestContador()
        {
            //Contador aCounter = new Contador();   // Error

            Contador.ValorActual = 100;
            Contador.Incrementar();
            Console.WriteLine("Nuevo valor actual: {0}", Contador.ValorActual);

            Console.WriteLine("Presione una tecla para terminar.");
            Console.ReadKey();

        }

        static void TestViajes()
        {
            Viaje viaje1 =new Viaje();
            Thread.Sleep(5000);
            Viaje viaje2 =new Viaje();
            Thread.Sleep(50000);
            Viaje.Resumen();
        }
    }
}
