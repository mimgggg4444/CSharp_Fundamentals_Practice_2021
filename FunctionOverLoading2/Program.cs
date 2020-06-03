using System;

namespace FunctionOverLoading2
{
    class Program
    {
        static void Main(string[] args)
        {
            Foo();
            Foo(100);
        }

        static void Foo()
        {
            Console.WriteLine("Foo with no arguments.");
        }

        static void Foo(int x)
        {
            Console.WriteLine($"Foo with {typeof(int).Name}: {x} as an argument."); //위와 비교해서 같은 이름의 함수이나 type가 다르기 때문에 int x 를 출력 할 수 있는 것을 알 수 있다. (type int의 이름을 알 수 있다.)
        }
    }
}
