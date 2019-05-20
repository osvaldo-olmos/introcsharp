using System;

namespace Arrays
{
    public class Utilidades
    {
        public static void Show(int[] myArray)
        {
            Console.Write("[ ");
            for (int i = 0; i < myArray.Length; i++)
            {
                if (i > 0)
                {
                    Console.Write(",");
                }
                Console.Write(myArray[i]);
            }
            Console.WriteLine("]");
        }
    }
}