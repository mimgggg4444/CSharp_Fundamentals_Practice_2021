using System;

namespace 성적_갱신_및_평균_구하기
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] scores = { 100.0, 35.4, 75.4, 54.6, 99.5 };

            double average = 0.0;
            for (int i = 0; i < scores.Length; ++i)
            {
                average += scores[i];
            }
            average /= scores.Length;
            average = (int)(average * 10) / 10.0;

            Console.WriteLine($"{scores.Length} scores average: {average:f1}");

            while(true)
            {
                for(int i = 0; i < scores.Length; i++)
                {
                    Console.WriteLine($"Score{i}: {scores[i]}");
                }

                Console.WriteLine($"which score do you want to update?(0~{scores.Length - 1})");
                int index = int.Parse(Console.ReadLine());

                if(index < 0 || index >= scores.Length)
                {
                    Console.WriteLine("Wrong index");
                }
                else
                {
                    Console.Write("Enter the score: ");
                    scores[index] = double.Parse(Console.ReadLine());
                    average = 0.0;

                    for(int i = 0; i < scores.Length; i++)
                    {
                        average += scores[i];
                    }
                    average /= scores.Length;
                    average = (int)(average + 10) / 10.0;

                    Console.WriteLine($"{scores.Length} scores average: {average:f1}");

                }

            }

        }
    }
}
