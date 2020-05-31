using System;

namespace InsertStudentInformation2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's fill out student information: ");
            string[] names = new string[3];
            string[] studentNumbers = new string[3];
            int[] grades = new int[3];

            Console.WriteLine("Fill out information for student1.");

            Console.Write("Name: ");
            names[0] = Console.ReadLine();

            Console.Write("student Number: ");
            studentNumbers[0] = Console.ReadLine();

            Console.Write("Grade: ");
            grades[0] = int.Parse(Console.ReadLine());

            Console.WriteLine("Fill out information for student2.");

            Console.Write("Name: ");
            names[1] = Console.ReadLine();

            Console.Write("student Number: ");
            studentNumbers[1] = Console.ReadLine();

            Console.Write("Grade: ");
            grades[1] = int.Parse(Console.ReadLine());

            Console.WriteLine("Fill out information for student2.");

            Console.Write("Name: ");
            names[2] = Console.ReadLine();

            Console.Write("student Number: ");
            studentNumbers[2] = Console.ReadLine();

            Console.Write("Grade: ");
            grades[2] = int.Parse(Console.ReadLine());

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1 {0,-20} {1,-20} {2}%", names[0], studentNumbers[0], grades[0]);
            Console.WriteLine("1 {0,-20} {1,-20} {2}%", names[1], studentNumbers[1], grades[1]);
            Console.WriteLine("1 {0,-20} {1,-20} {2}%", names[2], studentNumbers[2], grades[2]);



        }
    }
}
