using System;

namespace Daniel_Week18
{
    class Program
    {

        //반환형 함수이름(매개변수..)
        //{
        //    함수 본문...
        //    return 반환값
        //}

        static int Pow(int a, int n)
        {
            int result = 1;

            for (int i = 0; i < n; i++)
            {
                result *= a;
            }

            return result;
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Pow3(int a)
        {
            return a * a * a;
        }

        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(Pow3(a));
            //Console.WriteLine(Add(3, 3));
            //Console.WriteLine(Pow(2, 3));
            //Console.WriteLine(Pow(3, 3));
        }
        //값을 하나 받아(매개변수) 그 값을 세제곱 값을 반환하는 함수
    }
}
