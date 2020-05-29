using System;

namespace startThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int int1 = 2;   //2와 10을 각각 int1과 int2에 저장
            int int2 = 10;

            float float1 = 10.23f;  //각 수를 float1,float2에 저장
            float float2 = 3.4f;

            double double1 = 11.0;  //각 수를 double1,2 에 저장
            double double2 = 5.234;

            char char1 = 'x';   //각 수를 char1, 2에 저장
            char char2 = '$';

            Console.WriteLine(int1 + " + " + int2 + " = " + (int1 + int2)); //연산
            Console.WriteLine(int1 + " - " + int2 + " = " + (int1 - int2));
            Console.WriteLine(float1 + " + " + float2 + " = " + (float1 + float2));
            Console.WriteLine(double1 + " + " + double2 + " = " + (double1 + double2));
            Console.WriteLine(char1 + " + " + char2 + " = " + (char2 + char2));
        }
    }
}
