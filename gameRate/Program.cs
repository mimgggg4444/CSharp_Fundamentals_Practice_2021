using System;

namespace gameRate
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName1 = "kim";
            float winRate1 = 30.2351f;

            string studentName2 = "oh";
            float winRate2 = 70.11f;

            Console.WriteLine("{0,10} {1,15}\n", "name", "win Rate");
            Console.WriteLine("{0,10} {1,15}", studentName1, winRate1);
            Console.WriteLine("{0,10} {1,15}", studentName2, winRate2);
        }
    }
}
