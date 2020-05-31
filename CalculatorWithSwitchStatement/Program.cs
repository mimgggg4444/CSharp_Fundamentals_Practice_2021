using System;

namespace CalculatorWithSwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("num1: ");
            long num1 = long.Parse(Console.ReadLine());

            Console.Write("num2: ");
            long num2 = long.Parse(Console.ReadLine());

            Console.Write("operation(+,-,*,/): ");
            string operation = Console.ReadLine();

            switch(operation)
            {
                case "+":
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;
                case "*":
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;
                case "/":
                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                    break;
            }
            
        }
    }
}
