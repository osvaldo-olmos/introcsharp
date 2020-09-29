using System;

namespace TiposAnonimos
{

    class Persona
    {
        public string Nombre {get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona(){ Nombre ="Hector"};

            //Objetos de tipos anonimos
            var persona1 = new { Name = "Roberto" };
            var persona2 = new { Nombre = "Pedrito", Edad = "15" };
            var persona3 = new { Edad = "15", Nombre = "Pedrito" };
            var persona4 = new { Nombre = "Pedrito", Edad = "15" };

            // No es tipado dinamico
            //persona1.Edad = "12";

            Console.WriteLine(persona2.ToString());
            Console.WriteLine(persona2.Equals(persona3));
            Console.WriteLine(persona3.Equals(persona4));
            Console.WriteLine(persona2.Equals(persona4));
        }
    }
}
