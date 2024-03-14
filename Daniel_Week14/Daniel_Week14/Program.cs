using System;

namespace Daniel_Week14
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());

            //if(a + b < c || b + c < a || c + a < b)
            //{
            //    Console.WriteLine("Error");
            //}
            //else
            //{
            //    Console.WriteLine(a + b + c);
            //}

            //int year = int.Parse(Console.ReadLine());
            //4로 나누어 떨어지면서, 100으로는 나누어떨어지면 안됨
            //400으로는 나누어 떨어지는 연도
            //if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            //{
            //    Console.WriteLine(year.ToString() + "은 윤년입니다.");
            //}
            //else
            //{
            //    Console.WriteLine(year.ToString() + "은 평년입니다.");
            //}

            for (int i = 2; i < 10; i++)
            {
                for (int j = 2; j < 10; j++)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
