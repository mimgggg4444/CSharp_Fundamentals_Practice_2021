using System;

namespace 동서남북_이동_프로그램
{
    class Program
    {
        enum EMenu
        { menu1 = 1,
            menu2,
            menu3,
            menu4,
            menu5,
        }

        static double GetPrice(EMenu menu)
        {
            switch(menu)
            {
                case EMenu.menu1:
                    return 10000;
                case EMenu.menu2:
                    return 7500;
                case EMenu.menu3:
                    return 13500;
                case EMenu.menu4:
                    return 25000;
                case EMenu.menu5:
                    return 55000;
                default:
                    Console.WriteLine($"wrong menu: {menu}");
                    return -1;                                  //없는 값이 나올경우 -1 을 반환한다
            }
        }

        static void Main(string[]args)
        {
            while(true)
            {
                Console.Write($"select the menu(1-5): ");
                EMenu menu = (EMenu)int.Parse(Console.ReadLine());

                double price = GetPrice(menu);
                Console.WriteLine($"You will pay {price}won");
            }
        }
    }
}
