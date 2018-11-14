using System;
using System.Threading.Tasks;

namespace events
{
    public class Suscriber
    {
        public string Name { get; }

        public Suscriber(string name)
        {
            Name = name;
        }

        /*Este es el manejador de eventos asincrono.
         */
        public async void MyEventHandlerAsync(object sender, int number)
        {         
            var publisher =sender as Publisher;
            if(publisher ==null){
                Console.WriteLine("Todo maaaal");
                return;
            }
            Console.WriteLine($"Soy {this.Name} Y  {publisher.Name} informa el numero {number}");
            // ------- Asincronic Stuff here ------
            await Task.Delay(1000);
            // ------------------------------------
            Console.WriteLine($"Soy {this.Name} y si no me esperan, esto no se imprime nunca a consola");
        }

    }
}