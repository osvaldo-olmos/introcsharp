using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 21, 73, 14, 24, 20, 3, 1 };
            int[] temp = new int[list.Length];
 
            Array.Copy(list, temp, list.Length);
 
            Console.WriteLine("Array Original: ");
            Show(list);
 
            Array.Reverse(temp);
            Console.WriteLine("Array Invertido: ");
            Show(temp);
 
            Array.Sort(list);
            Console.WriteLine("Arreglo Ordenado: ");
            Show(list);

        }

        static void Show(int[] myArray)
        {
            Console.Write("[ ");
            for(int i=0; i < myArray.Length; i++)
            {
                if(i > 0)
                {
                    Console.Write(",");
                }
                Console.Write(myArray[i]);
            }
            Console.WriteLine("]");
        }

    }
}
