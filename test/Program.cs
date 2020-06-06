using System;

namespace test
{
    class Program
    {
        static void Main(string[]args)
        {

            int num1 = 0;
            int num2 = 10;

            int result = num1-- + num1-- - --num2;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(result);
        }
    }
}