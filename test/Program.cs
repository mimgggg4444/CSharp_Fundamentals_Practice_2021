using System;

public class Program
{
    public static void Main()
    {
        uint sum = 0;

        while (true)
        {
            if (sum >= 10)
            {
                break;
            }

            sum += uint.Parse(Console.ReadLine());
        }

        Console.WriteLine(sum);
    }
}