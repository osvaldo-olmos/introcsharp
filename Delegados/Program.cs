using System;

namespace Delegados
{
    public delegate int Operacion(int a, int b);

    class Program
    {
        public static int Suma(int a, int b)
        {
            int suma =a+b;
            Console.WriteLine($"Suma de {a} y {b} es: {suma}");
            return suma;
        }

        public static int Resta(int r, int t)
        {
            int resta = r-t;
            Console.WriteLine($"Resta de {r} y {t} es: {resta}");
            return resta;
        }

        public static int Multiplicacion(int x, int y)
        {
            int multiplicacion =x * y;

            Console.WriteLine($"Multiplicacion de {x} por {y} es: {multiplicacion}");
            return multiplicacion;
        }
        static void Main(string[] args)
        {
            Operacion mas = new Operacion(Suma);
            Operacion menos = new Operacion(Resta);
            Operacion por = new Operacion(Multiplicacion);

            int r1 = mas(4, 5); // r1 es igual a 9
            int r2 = menos(4, 5); // r2 es igual a -1
            int r3 = por(4, 5); // r3 es igual a 20

            Operacion combinado = mas;
            combinado += por; // combinación con el operador +=

            int r4 = combinado(4, 5); // r4 es igual a 20
        }
    }
}
