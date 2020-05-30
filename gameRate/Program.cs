using System;

namespace gameRate
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName1 = "kim";
            float winRate1 = 30.2351f;

            string studentName2 = "oh";
            float winRate2 = 70.11f;

            Console.WriteLine("{0,10} {1,15}\n", "name", "win Rate");
            Console.WriteLine("{0,10} {1,15}", studentName1, winRate1);
            Console.WriteLine("{0,10} {1,15}", studentName2, winRate2); // 왼쪽 정렬을 하려면 음수를 사용하면 됨.

            //방법1
            string message1 = string.Format($"Student Name: {studentName2} / Student ID {winRate2}");
            Console.WriteLine(message1);
            //방법2
            Console.WriteLine($"Student Name: {studentName1} / Student ID: {winRate1}");

            Console.WriteLine("{0:f2}", 3.14159265359);             // 소수점을 사용하려는 경우{0:f2}
                                                                    // 반올림이 된다 

            Console.WriteLine("{0:x}", 10); //소문자
            Console.WriteLine("{0:X}", 10); //대문자
            Console.WriteLine("{0:X4}", 10);    //10진수를 16진수로 출력하기, 16진수는 9부터 a로 시작한다
                                                // @는 escape문 모든걸 무시

        }
    }
}