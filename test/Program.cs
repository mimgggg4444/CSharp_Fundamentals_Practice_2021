using System;

public class Program
{
	public static void Main()
	{
		int num = 10;

		if (3 * 6 != 18 || ++num == 11)
		{
			num++;
		}
		// 12
		if (12 + 2 == 14 && num++ == 11)
		{
			num++;
		}
		// 12
		if (1 * 4 == 4 || num++ > 0)
		{
			num++;
		}
		//14
		Console.WriteLine(num);
	}
}