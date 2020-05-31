using System;

namespace 나이와_키_입출력
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first user's age: ");
            int age1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the first user's height(cm): ");
            float height1 = float.Parse(Console.ReadLine());

            Console.Write("Enter the second user's age: ");
            int age2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second user's height(cm): ");
            float height2 = float.Parse(Console.ReadLine());

            Console.Write("Enter the third user's age: ");
            int age3 = int.Parse(Console.ReadLine());
            Console.Write("Enter the third user's height(cm): ");
            float height3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Print result ----------------- ");
            Console.WriteLine($"The first User: Age({age1}), height({height1}cm)");
            Console.WriteLine($"The second User: Age({age2}), height({height2}cm)");
            Console.WriteLine($"The third User: Age({age3}), height({height3}cm)");
        }
    }
}
