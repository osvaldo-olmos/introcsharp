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
        public void MyEventHandler(object sender, EventArgs e)
        {
            //Publisher publisher = (Publisher)sender; Si hago este casteo revienta por excepcion
            //var publisher =sender as Publisher; Casteo seguro; pero al tipo incorrecto
            
            var publisher =sender as OtherPublisher;
            if(publisher ==null){
                Console.WriteLine("Todo maaaal");
                return;
            }
            Console.WriteLine($"Soy {this.Name} Y  {publisher.Name} informa que generara un numero");
        }

        public void MyEventHandler1(object sender, int number)
        {
            var publisher = sender as OtherPublisher;
            Console.WriteLine($"Soy {this.Name} Y  {publisher.Name} me informa el numero {number}");
        }

    }
}