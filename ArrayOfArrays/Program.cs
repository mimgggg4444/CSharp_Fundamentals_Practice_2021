using System;

namespace ArrayOfArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MONTHS_IN_A_YEAR = 12;
            int[] daysInEachMonth = new int[MONTHS_IN_A_YEAR] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            string[][] calender = new string[MONTHS_IN_A_YEAR][];

            for(int i =0; i < MONTHS_IN_A_YEAR; i++)
            {
                calender[i] = new string[daysInEachMonth[i]];
            }

            while(true)
            {
                Console.Write("Enter the Month(1 - 12): ");
                string monthString = Console.ReadLine();
                int month = int.Parse(monthString);

                if(0 >= month || month > 12)
                {
                    Console.WriteLine("Invalid range of month. Terminating program");
                    break;
                }

                Console.Write($"Enter the Day (1 - {calender[month - 1].Length}): ");
                string dayString = Console.ReadLine();
                int day = int.Parse(dayString);

                if(0 >= day || day > calender[month - 1].Length)
                {
                    Console.WriteLine("Invalid range of day. Terminating program");
                    break;
                }

                Console.WriteLine("Enter your schedule: ");
                string schedule = Console.ReadLine();
                calender[month - 1][day - 1] = schedule;

                Console.WriteLine("---------------------------");
                for(int i = 0; i < MONTHS_IN_A_YEAR; i++)
                {
                    for(int j = 0; j < calender[i].Length; j++)
                    {
                        if(!string.IsNullOrEmpty(calender[i][j]))
                        {
                            Console.WriteLine($"{i + 1} / {j + 1}: {calender[i][j]}");
                        }
                    }
                }

                Console.WriteLine("---------------------------");
            }
        }
    }
}
