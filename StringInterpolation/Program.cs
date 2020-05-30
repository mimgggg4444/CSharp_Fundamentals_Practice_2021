using System;

namespace PartialClass
{
    class program
    {
        static void Main(string[] args)
        {
            string name = "Lulu";
            int id = 202036306;

            string message1 = string.Format("Student Name: {0} / Student ID: {1}", name, id);
            Console.WriteLine(message1);

            Console.WriteLine("Student Name: {0} / Student ID: {1}", name, id);

        }
    }
}
