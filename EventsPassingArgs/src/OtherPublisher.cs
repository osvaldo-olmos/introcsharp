using System;

namespace events
{
public class OtherPublisher
    {
        /* Opcion con EventHandler
         */
        public event EventHandler GeneratingNumberEvent;

        ///Opcion con pasaje de argumentos
         public event EventHandler<int> NewNumberEvent;
         
        public string Name { get; }

        public OtherPublisher(string name)
        {
            Name =name;
        }

        public void Run()
        {
            Random rnd = new Random();

            // Generate 10 temperatures between 0 and 100 randomly.
            for (int ctr = 1; ctr <= 10; ctr++)
            {
                if (GeneratingNumberEvent != null)
                {
                    GeneratingNumberEvent(this, EventArgs.Empty);
                }
                int _generated = rnd.Next();

                Console.WriteLine($"Soy {this.Name} y genere el numero: {_generated}");

                if (NewNumberEvent != null)
                {
                    NewNumberEvent(this, _generated);
                }



            }
        }
    }
}