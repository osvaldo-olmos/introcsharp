using System;

namespace Structs2
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new SoccerPlayer("Zaracho", 4, -10);
            Console.WriteLine(player.Location);
        }
    }
}
