using System;

namespace test
{
    class Program
    {
        static void Main(string[]args)
        {
            long byte1 = long.MaxValue;

            Console.WriteLine(Convert.ToString(byte1, 2));
        }
    }
}