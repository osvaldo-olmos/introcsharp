using System;
using System.Threading;

namespace events
{
public class Publisher
    {
        /* Declaro un delegado como template para mis manejadores de eventos
         */
        public delegate void GeneratingNumberEventHandler(Publisher sender);
        
        /* Para declara el evento, debo hacerlo indicado lo sig:
        El modificador de acceso (public, internal, …).
        La palabra reservada event.
        El tipo del delegado asociado con ese evento.
        El nombre del evento
         */
        public event GeneratingNumberEventHandler GeneratingNumberEvent;

        public string Name { get; }
        public int LastNumber { get; private set;}

        public Publisher(string name)
        {
            Name =name;
        }

        public void Run()
        {
            Random rnd = new Random();

            // Generate 10 numbers randomly.
            for (int ctr = 1; ctr <= 10; ctr++)
            {
                LastNumber = rnd.Next();
                Console.WriteLine($"Soy {this.Name} y genere el numero: {LastNumber}");
                if (GeneratingNumberEvent!= null)
                {
                    GeneratingNumberEvent(this);
                }
                
                Thread.Sleep(2000);
            }
        }
    }
}