using System;

namespace tpeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            char char1 = 'a';

            int int1 = char1;

            Console.WriteLine($"int: {int1}");

            long long1 = char1;
            Console.WriteLine($"long: {long1}");

            ulong ulong1 = char1;
            Console.WriteLine($"ulong: {ulong1}");

            float float1 = char1;
            Console.WriteLine($"float: {float1}");


            double double1 = char1;
            Console.WriteLine($"double: {double1}");

            long long2 = long.MaxValue;
            int long2ToInt = (int)long2;

            Console.WriteLine($"long2: {long2}");
            Console.WriteLine($"long2Toint: {long2ToInt}");

            float float2 = 3.14159f;
            int float2Toint = (int)float2;

            Console.WriteLine($"float2: {float2}");
            Console.WriteLine($"float2ToInt: {float2Toint}");

            int int2 = -1;
            uint int2ToUint = (uint)int2;

            Console.WriteLine($"int2Toint: {int2ToUint}");

        }
    }
}
