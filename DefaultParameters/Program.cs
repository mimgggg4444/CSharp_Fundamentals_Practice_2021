using System;
using System.Threading;

namespace DefaultParameters
{
    class Program
    {
        static void Main(string[]agrs)
        {
            Bar("POCU");
            Bar("POCU", "COMP1500");
            Bar("POCU", "COMP1500", "Intero to Programming!");
        }

        static void Bar(string s, string s2 = "", string s3 = "")
        {
            Console.WriteLine($"{s}, {s2}, {s3}");
        }
    }
}