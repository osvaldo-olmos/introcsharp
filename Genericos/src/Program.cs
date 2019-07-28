using System;

/**
 * Primeros conceptos sobre genericos
 */
namespace Genericos
{
    public class Caja<T>
    {
        public T Contenido { get; private set; }

        public Caja(T contenido)
        {
            Contenido = contenido;
        }
    }

    public class CajaCompleja<X, Y, Z>
    {
        public Y Content2 { get; set; }
        public Z Content3 { get; set; }
        public X Content1 { get; set; }

        public CajaCompleja(Y c2, Z c3)
        {
            Content2 = c2;
            Content3 = c3;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Caja<int> cajaDeEntero = new Caja<int>(50);
            Caja<string> cajaDeString = new Caja<string>("contenido");

            Console.WriteLine(cajaDeEntero.Contenido);
            Console.WriteLine(cajaDeString.Contenido);

            //Anidamiento
            var cajaDeCajas = new Caja<Caja<string>>(cajaDeString);
            Console.WriteLine(cajaDeCajas.Contenido.Contenido);

            //Mas de un tipo generico
            var cajaCompleja = new CajaCompleja<double, decimal, float>(12, 2.003F);
            cajaCompleja.Content1 = 3.34;
        }
    }
}
