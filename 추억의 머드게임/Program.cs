using System;

namespace 추억의_머드게임
{
    class Program
    {
        static void Main(string[] args)
        {

            const int NORTH = 1;
            const int SOUTH = 2;
            const int EAST = 3;
            const int WEST = 4;

            int direction;
            int x = 0;
            int y = 0;

            while(true)
            {
                Console.WriteLine($"Your Location: ({x}, {y})");
                Console.WriteLine("Where do you want go? (N:1 ,S:2, E:3, W:4)");
                direction = int.Parse(Console.ReadLine());
                switch(direction)
                {
                    case NORTH:
                        y += 1;
                        break;
                    case SOUTH:
                        y -= 1;
                        break;
                    case EAST:
                        x += 1;
                        break;
                    case WEST:
                        x -= 1;
                        break;
                    default:
                        Console.WriteLine($"You enter wrong direction!: {direction}");
                        break;
                }
            }
        }
    }
}
