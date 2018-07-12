using System;

namespace RefAndOut
{
    public class Parametros
    {

        public void Swap(ref int a, ref int b)
        {
            int m = a;
            a = b;
            b = m;
        }

        public bool SumaMaxima(int a, int b, int max, out int resultado)
        {
            resultado = a + b;
            if (resultado >= max)
            {
                resultado = max;
                return true;
            }
            return false;
        }

        public string OojedMethod(ref int a, ref int b, out int s, out int r)
        {
            s = a + b;
            r = a - b;
            return a.ToString() + b.ToString();
        }

        static void Main(string[] args)
        {
            int a = 100, b = 5;
            Console.WriteLine("Valor de a:" + a + " - Valor de b:" + b);

            Parametros parametros = new Parametros();
            parametros.Swap(ref a, ref b);

            Console.WriteLine("Valor de a:" + a + " - Valor de b:" + b);

            int resSuma;
            var isResultOk = parametros.SumaMaxima(a, b, 100, out resSuma);

            if (isResultOk)
                Console.WriteLine("La suma excedió el valor máximo");
            else
                Console.WriteLine("El resultado de la suma es " + resSuma);
            
            int s, r;
            parametros.OojedMethod(ref a, ref b, out s, out r);

            Console.WriteLine("s es : " + s + " - r es : " + r);
        }
    }
}
