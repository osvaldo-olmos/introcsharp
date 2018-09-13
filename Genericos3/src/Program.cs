using System;

/**
 * Metodos genericos. Ejemplos
 *
 */
namespace Genericos3
{
    class Program
    {
        static void Swap(ref decimal a, ref decimal b)
        {
            decimal t = a;
            a = b;
            b = t;
        }

        static void Swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }

        static void Swap<T>(ref T a, ref T b)
        {
            T t = a;
            a = b;
            b = t;
        }

        public class Helper<T>
        {
            T Content;
            public Helper(T content){
                Content =content;
            }
            public void Method<T>(T input)
            {
                Console.WriteLine(input);
            }
        }

        static void Main(string[] args)
        {
            int uno = 1, dos = 2;
            Console.WriteLine(uno + " " + dos);

            Swap<int>(ref uno, ref dos);
            Console.WriteLine(uno + " " + dos);

            Swap(ref uno, ref dos); // Se infiere int
            Console.WriteLine(uno + " " + dos);        

            float d1 = 10, d2 = 20;
            Console.WriteLine(d1 + " " + d2);

            Swap(ref d1, ref d2); // Se infiere float
            Console.WriteLine(d1 + " " + d2);

            //Errores
            //Swap(ref uno, ref d2); // Error, los tipos no pueden ser inferidos
            //Swap<int>(ref uno, ref d2); // Error, d2 no es entero

            //Clases genericas y metodos genericos     
            Helper<int> helper = new Helper<int>(28);
            helper.Method<string>("Hello");

        }
    }
}
