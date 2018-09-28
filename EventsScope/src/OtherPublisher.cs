using System;

namespace events
{
public class OtherPublisher
    {
        /* Opcion con EventHandler
         */
        public event EventHandler GeneratingNumber;

        //Ultimo ejemplo
        public event EventHandler<int> NewNumberEvent;
         
        public Action<int> NewNumberAction;

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
                // if (GeneratingNumber != null)
                // {
                //     GeneratingNumber(this, EventArgs.Empty);
                // }
                
                //Una manera resumida de hacer lo mismo
                GeneratingNumber?.Invoke(this, EventArgs.Empty);
                
                int generated = rnd.Next();

                Console.WriteLine($"Soy {this.Name} y genere el numero: {generated}");

                /*if (NewNumber != null)
                {
                    NewNumber(this, generated);
                }*/



            }
        }
    }
}