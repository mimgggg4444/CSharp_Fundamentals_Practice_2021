using System;
using System.ComponentModel.Design;

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

            if(grade >= 90)
            {
                Console.Write("Excellent! You are an A student!");
            }
            else if(grade >=80)
            {
                Console.Write("Good! You are above average!");
            }
            else if(grade>=70)
            {
                Console.Write("Meh... You are doing alright...");
            }
            else if(grade>=50)
            {
                Console.Write("Are you even trying? You can do better than that!");
            }

            else
            {
                Console.Write("You gave no talent... Maybe you should do something else?");
            }
            //Console.WriteLine("-------------------------------");
            Console.WriteLine($"{name}\n{studentNumbeString}\n{grade}%");
        }
    }
}
