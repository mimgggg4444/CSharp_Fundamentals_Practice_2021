using System;

public class Program
{
	static void Main(string[]args)
	{
		Console.Write("Enter the first number: ");
		int num1 = int.Parse(Console.ReadLine());
		Console.Write("Enter the second number: ");
		int num2 = int.Parse(Console.ReadLine());

		int max;
		if(num1 > num2)
        {
			max = num1;
        }
		else
        {
			max = num2;
        }

		Console.WriteLine(max);
	}
}