using System;

namespace 나이와_키_입출력
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ages = new int[3];
            float[] heights = new float[3];

            Console.Write("Enter the first user's age: ");
            ages [0] = int.Parse(Console.ReadLine());
            Console.Write("Enter the first user's height(cm): ");
            heights [0] = float.Parse(Console.ReadLine()); 

            Console.Write("Enter the second user's age: ");
            ages [1] = int.Parse(Console.ReadLine());
            Console.Write("Enter the second user's height(cm): ");
            heights [1] = float.Parse(Console.ReadLine());

            Console.Write("Enter the third user's age: ");
            ages [2] = int.Parse(Console.ReadLine());
            Console.Write("Enter the third user's height(cm): ");
            heights [2] = float.Parse(Console.ReadLine());

            Console.WriteLine("Print result ----------------- ");
            Console.WriteLine($"The first User: Age({ages[0]}), height({heights[0]}cm)");
            Console.WriteLine($"The second User: Age({ages[1]}), height({heights[1]}cm)");
            Console.WriteLine($"The third User: Age({ages[2]}), height({heights[2]}cm)");

            int totalAges = ages[0] + ages[1] + ages[2];
            Console.WriteLine($"Total ages: {totalAges}");
            float totalHeights = heights[0] + heights[0] + heights[1] + heights[2];
            Console.WriteLine($"Total heihgts: {totalHeights}");
        }
    }
}
