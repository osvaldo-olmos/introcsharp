using System;

namespace Delegados3
{
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
}