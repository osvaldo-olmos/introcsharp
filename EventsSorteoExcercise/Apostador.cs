using System;

namespace EventsSorteoExcercise
{
    public class Apostador
    {
        public void RecibirResultado(object sender, string message)
        {
            Console.WriteLine(message);
        }
    }
}