using System;

namespace BitFlag
{
    class Program
    {
        static void Main(string[] args)
        {
            const int BIT_FLAG_SIZE = 8;

            byte bitFlags = 0;
            byte mask1 = 1 << 2;
            bitFlags |= mask1;
            Console.WriteLine($"bitFlags: {Convert.ToString(bitFlags,2).PadLeft(BIT_FLAG_SIZE,'0')}");

            byte mask3 = (1 << 3) | (1 << 5);
            bitFlags |= mask3;
            Console.WriteLine($"bitFlags: {Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0')}");

            /*
            string str = "forty-two";
            char pad = '.';

            Console.WriteLine(str.PadLeft(15, pad));
            Console.WriteLine(str.PadLeft(2, pad));
            */

            bitFlags &= (byte)~mask1;               //mask1이랑 비교해서 and 연산
            Console.WriteLine($"bitFlags3: {Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0')}");

            bitFlags &= 0;
            Console.WriteLine($"bitFlags: {Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0')}");

            char char1 = 'A';
            int result1 = char1 | ' ';
            Console.WriteLine($"result1: {(char)result1}");
        
        }
    }
}
