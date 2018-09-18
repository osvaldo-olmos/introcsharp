using System;
using System.Collections;
using System.Collections.Generic;

namespace Genericos6
{
    public class Program
    {
        public static void Main()
        {
            //SinGenericos();
            ConGenericos();
        }
        private static void SinGenericos()
        {
            ArrayList temperatures = new ArrayList();
            // Initialize random number generator.
            Random rnd = new Random();

            // Generate 10 temperatures between 0 and 100 randomly.
            for (int ctr = 1; ctr <= 10; ctr++)
            {
                int degrees = rnd.Next(0, 100);
                Temperature temp = new Temperature();
                temp.Fahrenheit = degrees;
                temperatures.Add(temp);
            }

            // Sort ArrayList.
            temperatures.Sort();

            foreach (Temperature temp in temperatures)
                Console.WriteLine(temp.Fahrenheit);

        }

        private static void ConGenericos()
        {
            List<Temperatura> temperatures = new List<Temperatura>();
            // Initialize random number generator.
            Random rnd = new Random();

            // Generate 10 temperatures between 0 and 100 randomly.
            for (int ctr = 1; ctr <= 10; ctr++)
            {
                int degrees = rnd.Next(0, 100);
                Temperatura temp = new Temperatura(degrees);
                temperatures.Add(temp);
            }

            // Sort ArrayList.
            temperatures.Sort();

            foreach (Temperatura temp in temperatures)
                Console.WriteLine(temp.Fahrenheit);

        }

    }
}
