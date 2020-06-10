using System;

public class Program
{

    static double Square(double number)
    {
        number *= number;
        return number;
    }
    #region Hi!
    static void Main(string[]args)
    {
        double number = 5;
        //double result = Square(number);
        Console.WriteLine(number);
        Console.WriteLine(Square(number));
    }
    #endregion



}