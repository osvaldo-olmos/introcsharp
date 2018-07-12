using System;

namespace Arreglos_Ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese cant. de elementos");
            int cantidad =int.Parse(Console.ReadLine());

            int[] vector = new int[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vector.Length; i++)
            {
                for (int j = i+1; j < vector.Length; j++)
                {
                    if (vector[i] > vector[j])
                    {
                        int aux = vector[i];
                        vector[i] = vector[j];
                        vector[j] = aux;
                    }
                }
            }

            Console.WriteLine("Vector Ordenado: ");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write($"{vector[i]} ");
            }
            Console.ReadKey();
        }
    }
}
