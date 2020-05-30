using System;

namespace Insert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's fill out student information: ");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Student Number: ");
            int studentNumbeString = int.Parse(Console.ReadLine());

            Console.Write("Grade: ");
            int grade = int.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------------");
            Console.WriteLine($"{name}\n{studentNumbeString}\n{grade}");
        }
    }
}
