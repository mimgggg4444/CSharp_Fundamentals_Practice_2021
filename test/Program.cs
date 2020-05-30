using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;

            if(num1 == 10 || ++num2 == 20)
            {
                ++num1;
            }

            Console.WriteLine($"{num1} {num2}");
        }
    }
}
