using System;

namespace Daniel_Week20
{
    class Program
    {

        //값을 하나 받아와서(매개변수) 이 값이 짝수인지 홀수인지 판별
        //짝수라면 true, 홀수라면 false
        //IsEven << 함수

        static bool IsEven(int a)
        {
            return a % 2 == 0;
        }

        static void Main(string[] args)
        {
            for (int i = 2; i < 10; i++)
            {
                for (int j = 2; j < 10; j++)
                {
                    Console.Write($"{j} * {i} = {j * i}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
