using System;

namespace events
{
public class Publisher
    {
        public event EventHandler<int> NewNumberEvent;

        public string Name { get; }

        public Publisher(string name)
        {
            Name =name;
        }

        public void Publish()
        {
            Random rnd = new Random();

            // Generate 10 numbers between 0 and 100 randomly.
            for (int ctr = 1; ctr <= 10; ctr++)
            {
                int _generated = rnd.Next(0,100);
                if (NewNumberEvent != null)
                {
                    Console.WriteLine($"{this.Name}: 1- {DateTimeOffset.Now.ToString("HH:mm:ss:ffff")}");
                    NewNumberEvent(this, _generated);
                    Console.WriteLine($"{this.Name}: 2- {DateTimeOffset.Now.ToString("HH:mm:ss:ffff")}");
                }
                

                Console.WriteLine($"Soy {this.Name} y genere el numero: {_generated}");
            }
        }
    }
}