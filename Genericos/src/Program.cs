using System;

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

    public class CajaCompleja<T, Content1, Content2>
    {
        public Content1 C1 { get; set; }
        public Content2 C2 { get; set; }
        public T Item { get; set; }

        public CajaCompleja(Content1 c1, Content2 c2)
        {
            C1 = c1;
            C2 = c2;
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
            var cajaCompleja = new CajaCompleja<double, decimal, float>(1, 2);
            cajaCompleja.Item = 3;
        }
    }
}
