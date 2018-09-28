using System;

namespace events
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escenario1();
            //Escenario2();
            Escenario3();
        }

        private static void Escenario1()
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

        private static void Escenario2()
        {
            OtherPublisher g = new OtherPublisher("Big Generator");
            OtherSuscriber s1 = new OtherSuscriber("Suscriber1");
            g.GeneratingNumberEvent += s1.MyEventHandler;
            
            OtherSuscriber s2 = new OtherSuscriber("Suscriber2");
            g.GeneratingNumberEvent += s2.MyEventHandler;

            g.Run();
        }

        private static void Escenario3()
        {
            OtherPublisher g = new OtherPublisher("Big Generator");
            OtherSuscriber s1 = new OtherSuscriber("Suscriber1");
            g.NewNumberEvent += s1.MyEventHandler1;
            
            OtherSuscriber s2 = new OtherSuscriber("Suscriber2");
            g.NewNumberEvent += s2.MyEventHandler1;

            g.Run();
        }
    }
}
