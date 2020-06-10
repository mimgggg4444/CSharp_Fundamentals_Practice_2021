using System;

public class Program
{


    static double Square(double number)
    {
        return number * number;
    }

    static void Main(string[] args)
    {
        double input = 3.14;
        double input1 = Square(input);
        Console.WriteLine(input1);
        Console.WriteLine(input);

    }
}