using System;

namespace events
{
    public class Suscriber
    {
        public string Name { get; }

        public Suscriber(string name)
        {
            Name = name;
        }

        /*Este es el manejador de eventos*/
        public void MyEventHandler(Publisher sender)
        {
            Console.WriteLine($"Soy {this.Name} Y  {sender.Name} generará un número");
        }

        /* Otro manejador */
        public void MyEventHandler1(Publisher sender)
        {
            Console.WriteLine($"Soy {this.Name} Y  {sender.Name} generará un número");
        }  
    }
}