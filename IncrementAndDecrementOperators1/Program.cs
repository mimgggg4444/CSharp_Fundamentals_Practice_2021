using System;

namespace IncrementAndDecrementOperators1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 10;

            int result1 = num1++ + num2;

            Console.WriteLine($"num1: {num1}");
            Console.WriteLine($"num2: {num2}");
            Console.WriteLine($"result1: {result1}");

            int result2 = ++num1 + num2++;

            Console.WriteLine($"num1: {num1}");
            Console.WriteLine($"num2: {num2}");
            Console.WriteLine($"result2: {result2}");

            int result3 = num1-- + num1-- - --num2;


            Console.WriteLine($"num1: {num1}");
            Console.WriteLine($"num2: {num2}");
            Console.WriteLine($"result3: {result3}");

            int result4 = num2++ * num1++ - --num2 + num1;

            Console.WriteLine($"num1: {num1}");
            Console.WriteLine($"num2: {num2}");
            Console.WriteLine($"result4: {result4}");

        }
    }
}
