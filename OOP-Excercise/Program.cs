using System;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person =new Person("Pepe");
            SmallApartment depto = new SmallApartment();
            Door door =new Door("cafe");
            depto.MyDoor =door;
            person.MyHouse =depto;

            person.ShowData();
        }
    }
}
