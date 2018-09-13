using System;

namespace Delegados3
{
    public delegate void Del(string message);

    class Publisher {

        Del handler;
        public void Subscribe(Del eventHandler){
            this.handler += eventHandler;
        }

        public void UnSubscribe(Del eventHandler){
            this.handler -= eventHandler;
        }

        public void Run(){

            for(int i=0; i < 10; i++){
                handler($"event {i} !!!");
                System.Threading.Thread.Sleep(2000);
            }
            
        }
    }

    class SubscriberOne {

        public void EventHandler(string eventDetail){
            Console.WriteLine($"{this} : Event handled - Event Detail: {eventDetail}");
        }
    }

    class SubscriberTwo {
        public void EventHandler(string eventDetail){
            Console.WriteLine($"{this} : Epa! Recibi este evento: {eventDetail}");
        }
    }

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
