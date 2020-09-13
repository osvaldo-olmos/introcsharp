using System;

namespace RefAndOut
{
    public class Parametros
    {


        public void BuggySwap(int a, int b)
        {
            int m = a;
            a = b;
            b = m;
            Console.WriteLine($"Inside BuggySwap --> a vale: {a} - b vale: {b}");
        }


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
    }
}
