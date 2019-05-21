using System;
using System.Text;

namespace Cadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena1 = "John Wayne";
            string cadena2 = String.Copy(cadena1);

            // == Compara por valor
            Console.WriteLine(cadena1 == cadena2);

            //Comparacion por referencia
            Console.WriteLine(Object.ReferenceEquals(cadena1, cadena2));

            //Casteo
            Console.WriteLine((object)cadena1 == (object)cadena2);

            //Dos cadenas iguales se almacenan en el mismo espacio de memoria
            string cadena3 = "Matt Dammon";
            string cadena4 = "Matt Dammon";

            Console.WriteLine((object)cadena3 == (object)cadena4);

            // Esto no se puede hacer ya que las cadenas son inmutables
            //cadena1[0] = "U";

            // Append to StringBuilder.
            StringBuilder strBuilder = new StringBuilder(cadena1);
            strBuilder.Remove(0,1).Insert(0, "U");
            Console.WriteLine(strBuilder);
        }
    }
}
