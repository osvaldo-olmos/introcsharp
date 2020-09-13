using System;

namespace RefAndOut.src
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 100, b = 5;
            Console.WriteLine("Valor de a:" + a + " - Valor de b:" + b);

            Parametros parametros = new Parametros();
            parametros.BuggySwap(a, b);
            
            parametros.Swap(ref a, ref b);
            Console.WriteLine("Valor de a:" + a + " - Valor de b:" + b);

            int resSuma;
            var isResultOk = parametros.SumaMaxima(a, b, 100, out resSuma);

            if (isResultOk)
                Console.WriteLine("La suma excedió el valor máximo");
            else
                Console.WriteLine("El resultado de la suma es " + resSuma);

            int suma, resta;
            string ret =parametros.OojedMethod(ref a, ref b, out suma, out resta);

            Console.WriteLine($"{a} y {b} concatenados es: {ret}");
            Console.WriteLine($"la suma de {a} + {b}  es : " + suma);
            Console.WriteLine($"la resta de {a} - {b}  es : " + resta);
        }
    }
}