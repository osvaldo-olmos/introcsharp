using System;

namespace ParametrosDeTipo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pair<int,string> pair = new Pair<int,string> { First = 1, Second = "two" };
            int i = pair.First;     // TFirst is int
            string s = pair.Second; // TSecond is string
            Console.WriteLine($"Hello World! Pair : {pair.First} - {pair.Second}");
        }
    }

    public class Pair<TFirst,TSecond>
    {
        public TFirst First;
        public TSecond Second;
    }
}
