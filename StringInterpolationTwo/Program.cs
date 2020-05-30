using System;

namespace StringInterpolationTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 48;
            int num2 = 65;

            Console.WriteLine($"Tje sum of {num1} and {num2} is {num1 + num2}");

            Console.WriteLine(@"\x48\x65\x6C\x6C\x6F\x20\x57\x6F\x72\x6C\x64\x21");
            Console.WriteLine($"\x48\x65\x6C\x6C\x6F\x20\x57\x6F\x72\x6C\x64\x21");

            Console.WriteLine("{0,-11} / {1,11} = {2:f4}", num1, num2, num1 / (float)num2); //int는 -1을 포함한 11개의 비트를 갖고있기 때문에 11로 설정되었다

            Console.WriteLine(string.Format("{0,-11} % {1,11} = {2}", num2, num1, num2 % num1));
        }
    }
}
