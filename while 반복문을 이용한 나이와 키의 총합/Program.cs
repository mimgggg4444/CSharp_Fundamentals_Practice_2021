using System;

namespace total_age_and_height_using_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("user count: ");
            int length = int.Parse(Console.ReadLine());
            int[] ages = new int[length];
            float[] height = new float[length];

            int totalAge = 0;
            float totalHeight = 0.0f;
            int count = 0;
            while(count < length)
            {
                Console.Write($"Enter user{count}'s age: ");
                ages[count] = int.Parse(Console.ReadLine());
                totalAge += ages[count];

                Console.Write($"Enter user{count}'s height: ");
                height[count] = float.Parse(Console.ReadLine());
                totalHeight += height[count];

                ++count;
            }

            Console.WriteLine($"Total ages: {totalAge}");
            Console.WriteLine($"Total height: {totalHeight}");
        }
    }
}
