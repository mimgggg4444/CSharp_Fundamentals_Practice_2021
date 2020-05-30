using System;

namespace CalculatorTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter an operator: ");
            string op = Console.ReadLine();

            if (op == "+")
            {
                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            }
            else if (op == "-")
            {
                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            }
            else if(op == "*")
            {
                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            }
            else if(op == "/")
            {
                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            }

        }
    }
}
