using System;
namespace House
{
    public class House
    {
        public double Area { get; set; }
        public Door MyDoor {get;set;}

        public House(double area)
        {
            Area = area;
        }

        public void ShowData()
        {
            Console.WriteLine($"Soy una {GetType().Name} mi area es de {Area} m2");
        }

    }
}