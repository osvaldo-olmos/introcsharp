using System;

namespace VariablesPorValorYPorRef
{    class Program
    {
        static void Main(string[] args)
        {
            //EjemploPorValor();
            EjemploPorReferencia();

        }

        private static void EjemploPorValor()
        {
            int i = 5;
            Console.WriteLine(Duplica(i));
            Console.WriteLine(i);
            Console.ReadLine();
        }

        static public int Duplica(int n)
        {
            n = n * 2;
            return n;
        }

        public static void Rejuvence(Persona per)
        {
            per.Edad = per.Edad - 10;
        }

        public static void EjemploPorReferencia()
        {
            Persona p = new Persona();
            p.Nombre = "Pedro";
            p.Apellido = "Almodovar";
            p.Edad = 65;

            Rejuvence(p);
            Console.WriteLine(p.Edad);
            Console.ReadLine();
        }

    }

}
