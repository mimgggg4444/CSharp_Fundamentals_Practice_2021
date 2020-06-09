using System;

namespace simpleLoginProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string passcode = "3941a";
            string userInput = "";
        
            while(true)
            {
                Console.Write("Please enter the password: ");
                userInput = Console.ReadLine();

                if(passcode == userInput)
                {
                    Console.WriteLine("correct! welcome!");
                    break;
                }

                Console.WriteLine("wrong password");
            }
        }
    }
}
