using System;

public class Program
{
	static void Main(string[]args)
	{
		Console.WriteLine("Please select a menu");
		Console.WriteLine("1. Cheese burger");
		Console.WriteLine("2. Double cheese burger");
		Console.WriteLine("3. Veggie burger");
		Console.WriteLine("4. Cheese & mushromm burger");

		int menu = int.Parse(Console.ReadLine());

		switch(menu)
        {
			case 1:
				Console.WriteLine("Price:3$");
				break;
        }
	}
}