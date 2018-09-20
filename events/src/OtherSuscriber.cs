using System;

namespace events
{
    public class OtherSuscriber
    {
        public string Name { get; }

        public OtherSuscriber(string name)
        {
            Name = name;
        }

        /*Este es el manejador de eventos*/
        public void MyEventHandler(OtherPublisher sender, EventArgs e)
        {
            Console.WriteLine($"Soy {this.Name} Y  {sender.Name} generará un número");
        }
    }
}