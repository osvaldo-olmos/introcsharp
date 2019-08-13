using System;

namespace Delegados3
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher =new Publisher();
            SubscriberOne subscriber1 =new SubscriberOne();
            publisher.Subscribe(subscriber1.EventHandler);
            SubscriberTwo subscriber2 =new SubscriberTwo();
            publisher.Subscribe(subscriber2.EventHandler);

            publisher.Run();

            publisher.UnSubscribe(subscriber2.EventHandler);

            publisher.Run();
        }
    }
}
