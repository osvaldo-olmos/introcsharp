using System;

namespace Clase2_ArgumentosMain
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"args[{i}] vale {args[i]}");
            }

        }
    }
}
