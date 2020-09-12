using System;

namespace Delegados3
{
    class Suscriptor {

        private string nombre;

        public Suscriptor(string nombre)
        {
            this.nombre =nombre;
        }

        public void EventHandler(string eventDetail){
            Console.WriteLine($"{this.nombre} : Noticia!: {eventDetail}");
        }
    }
}