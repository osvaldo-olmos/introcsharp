using System;
using System.Threading;
using System.Threading.Tasks;

namespace events
{
    class Program
    {
        static void Main(string[] args)
        {
            Escenario1();
            //Escenario2();
        }

        private static void Escenario1()
        {
            Publisher g = new Publisher("Big Generator");
            Suscriber s1 = new Suscriber("Suscriber1");
            g.NewNumberEvent += s1.MyEventHandler;

            Suscriber s2 = new Suscriber("Suscriber2");
            g.NewNumberEvent += s2.MyEventHandler;
            g.Publish();
        }

        private static void Escenario2()
        {
            Publisher g = new Publisher("Big Generator");
            Suscriber s1 = new Suscriber("Suscriber1");
            g.NewNumberEvent += s1.MyEventHandlerAsync;

            Suscriber s2 = new Suscriber("Suscriber2");
            g.NewNumberEvent += s2.MyEventHandlerAsync;

            g.Publish();
            // Espero un rato para que terminen los eventHandlers asincronicos
            //Thread.Sleep(10000);
        }
    }
}
