namespace House
{
    public class Door
    {
        string Color { get; set; }

        public Door(string color)
        {
            Color = color;
        }

        public void ShowData()
        {
            System.Console.WriteLine($"Soy una Puerta mi color es de {Color}");
        }
    }
}