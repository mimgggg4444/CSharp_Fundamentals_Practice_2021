using System;

namespace 반복문을_이용한_나이와_키_입출력
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("User count: ");
            int length = int.Parse(Console.ReadLine());
            int[] ages = new int[length];
            float[] heights = new float[length];

            int totalAges = 0;
            float totalHeights = 0.0f;
            for(int i = 0; i < length; i++)
            {
                Console.Write($"Enter user {i}'s age:");
                ages[i] = int.Parse(Console.ReadLine());
                totalAges += ages[i];

                Console.Write($"Enter user {i}'s height(cm):");
                heights[i] = float.Parse(Console.ReadLine());
                totalHeights += heights[i];

            }

            Console.WriteLine("Print result---------");
            for(int i = 0; i < length; i++)
            {
                Console.WriteLine($"User {i}: Age( {ages[i]}), Height( {heights[i]}cm)");
            }

            Console.WriteLine($"Total ages: {totalAges}");
            Console.WriteLine($"Total height: {totalHeights}");
        }
    }
}
