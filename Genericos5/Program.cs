

using System;

namespace MetodosGenericos
{
    /* Metodos Genericos - Ejercicio:
     *
     * Crear un arreglo de enteros, uno de doubles y otro de strings.
     * Crear un método genérico que reciba un arreglo y una posicion
     * y retorne un string indicando el valor del elemento y el 
     * tipo del mismo.
     */
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
            string[] stringArray = { "pepe", "sigma", "jones", "ultra", "pelota" };

            Console.WriteLine(InspeccionaElemento(intArray, 0));
            Console.WriteLine(InspeccionaElemento(doubleArray, 3));
            Console.WriteLine(InspeccionaElemento(stringArray, 4));

        }

        private static string InspeccionaElemento<T>(T[] inputArray, int posicion)
        {
            var elemento = inputArray[posicion];
            return $"{elemento} es de tipo {elemento.GetType()}";
        }
    }
}