using System;

namespace InsertLolInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's fill out lol information");

            Console.Write("Please write your nickName: ");
            string nickName = Console.ReadLine();

            Console.Write("Please write your tier: ");
            string tier = Console.ReadLine();

            Console.Write("Please write your rate: ");
            string rate = Console.ReadLine();

            Console.WriteLine("-------------------------");
            Console.WriteLine($"Name: {nickName}, tier: {tier}, rate: {rate}");
        }
    }
}
