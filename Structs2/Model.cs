namespace Structs2
{
    public class SoccerPlayer
    {
        public string Name { get; set; }
        public Coords Location {get;}
        public SoccerPlayer(string name, double x, double y)
        {
            Name = name;
            Location = new Coords(x, y);
        }
    }
    public readonly struct Coords
    {
        public Coords(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; }
        public double Y { get; }
        public override string ToString() => $"({X}, {Y})";
    }

}