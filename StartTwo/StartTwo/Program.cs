using System;

namespace PrimitiveTypesToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            byte byte1 = byte.MaxValue;
            byte byte2 = byte.MinValue;

            int int1 = int.MaxValue;
            int int2 = int.MinValue;

            long long1 = long.MaxValue;
            long long2 = long.MinValue;

            char char1 = 'x';
            char char2 = '$';

            Console.WriteLine(byte1 + " - > " + Convert.ToString(byte1, 2));
            Console.WriteLine(byte1 + " - > " + Convert.ToString(byte2, 2));

            Console.WriteLine(byte1 + " - > " + Convert.ToString(int1, 2));
            Console.WriteLine(byte1 + " - > " + Convert.ToString(int2, 2));

            Console.WriteLine(byte1 + " - > " + Convert.ToString(long1, 2));
            Console.WriteLine(byte1 + " - > " + Convert.ToString(long2, 2));

            Console.WriteLine(byte1 + " - > " + Convert.ToString(char1, 2));
            Console.WriteLine(byte1 + " - > " + Convert.ToString(char2, 2));
        }
    }
}