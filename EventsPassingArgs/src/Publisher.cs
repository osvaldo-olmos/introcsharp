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
        public event GeneratingNumberEventHandler GeneratingNumber;

        public string Name { get; }

        public Publisher(string name)
        {
            Name =name;
        }

        public void GenerateNumbers()
        {
            Random rnd = new Random();

            // Generate 10 numbers randomly.
            for (int ctr = 1; ctr <= 10; ctr++)
            {
                if (GeneratingNumber!= null)
                {
                    GeneratingNumber(this);
                }
                int generated = rnd.Next();
                Console.WriteLine($"Soy {this.Name} y genere el numero: {generated}");
                Thread.Sleep(2000);
            }
        }
    }
}