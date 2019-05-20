using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            ImprimeArrayInvertido();
            CreaArray();

        }
        private static void ImprimeArrayInvertido()
        {
            int[] list = { 21, 73, 14, 24, 20, 3, 1 };
            int[] temp = new int[list.Length];

            Array.Copy(list, temp, list.Length);

            Console.WriteLine("Array Original: ");
            Utilidades.Show(list);

            Array.Reverse(temp);
            Console.WriteLine("Array Invertido: ");
            Utilidades.Show(temp);

            Array.Sort(list);
            Console.WriteLine("Arreglo Ordenado: ");
            Utilidades.Show(list);
        }

        static void CreaArray()
        {

            Console.WriteLine("Ingrese cant. de elementos");
            int cantidad = int.Parse(Console.ReadLine());

            int[] vector = new int[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vector.Length; i++)
            {
                for (int j = i + 1; j < vector.Length; j++)
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
            Utilidades.Show(vector);
            Console.ReadKey();

        }

    }
}
