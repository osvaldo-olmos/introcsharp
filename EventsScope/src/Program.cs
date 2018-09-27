using System;

namespace events
{
    class Program
    {
        static void Main(string[] args)
        {

            OtherPublisher g = new OtherPublisher("Big Generator");
            OtherSuscriber s1 = new OtherSuscriber("Suscriber1");
            g.NewNumber += s1.MyEventHandler1;
            
            g.NewNumberAction += s1.MyEventHandler2;
            //Puedo generar un evento desde fuera del objeto
            g.NewNumberAction(45);
            //Puedo eliminar las suscripciones desde cualquier lado
            g.NewNumberAction =null;

            //g.NewNumber(34); Error, no puedo manipularlo desde afuera del objeto
            //g.NewNumber =null; Idem

            //g.Run();
        }
    }
}
