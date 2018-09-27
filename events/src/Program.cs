using System;

namespace events
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher g = new Publisher("Big Generator");
            Suscriber s1 = new Suscriber("Suscriber1");
            g.GeneratingNumber += s1.MyEventHandler;
            Suscriber s2 = new Suscriber("Suscriber2");
            g.GeneratingNumber += s2.MyEventHandler;

            g.GenerateNumbers();
            g.GeneratingNumber -= s2.MyEventHandler;
            g.GenerateNumbers();
        }
    }
}
