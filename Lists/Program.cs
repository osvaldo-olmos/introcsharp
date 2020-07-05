using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main()
        {
            // Collection initializer.
            List<string> list1 = new List<string>()
            {
                "Jupiter",
                "Neptuno",
                "Tierra"
            };

            var list2 = new List<string>()
            {
                "Jupiter",
                "Neptuno",
                "Tierra"
            };

            // Pasando un array al costructor.
            string[] array = { "Jupiter", "Neptuno", "Tierra" };
            List<string> list3 = new List<string>(array);

            // Usando Add()
            List<string> list4 = new List<string>();
            list4.Add("Jupiter");
            list4.Add("Neptuno");
            list4.Add("Tierra");

            // Cuantos elementos tiene cada lista ?
            Console.WriteLine(list1.Count);
            Console.WriteLine(list2.Count);
            Console.WriteLine(list3.Count);
            Console.WriteLine(list4.Count);
        }
    }
}
