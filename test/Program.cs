using System;

public class Program
{
	static void Main(string[]args)
	{
		char[] myName = new char[4];

		myName[0] = 'L';
		myName[1] = 'u';
		myName[2] = 'n';
		myName[3] = 'a';

		Console.WriteLine($"My name is {myName[0]}{myName[1]}{myName[2]}{myName[3]}");
	}
}