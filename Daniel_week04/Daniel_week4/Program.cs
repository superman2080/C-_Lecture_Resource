using System;

namespace Daniel_week4
{
    class Program
    {
        static void Main(string[] args)
        {
            //int score = int.Parse(Console.ReadLine());
            //score /= 10;

            //switch (score)
            //{
            //    case 10:
            //    case 9:
            //        Console.WriteLine("A");
            //        break;
            //    case 8:
            //        Console.WriteLine("B");
            //        break;
            //    case 7:
            //        Console.WriteLine("C");
            //        break;
            //    case 6:
            //        Console.WriteLine("D");
            //        break;
            //    default:
            //        Console.WriteLine("F");
            //        break;
            //}

            //C# 제어문
            //조건문, 반복문
            //for       선언, 증감, 범위
            //while     조건
            //int result = 0;
            //for (int i = 1; i < 101; i++)
            //{
            //    if (i % 2 == 0)                  //짝수
            //        result -= i;
            //    else
            //        result += i;
            //}
            //Console.WriteLine(result);

            //자연수 하나를 입력받아 그 수 이하의 3의 배수를 모두 출력하세요.
            //
            //int result = 0;
            //int n = int.Parse(Console.ReadLine());
            //int m = int.Parse(Console.ReadLine());
            //for (int i = n; i <= m; i++)
            //{
            //    result += i;
            //}
            //Console.WriteLine(result);

            //자연수 두 개를 입력받아서 두 값 사이 까지의 총합

            //5, 10
            //5+6+7+8+9+10

            //while         조건만

            //int i = 0;
            //int j = 0;
            //while (true)
            //{
            //    i = int.Parse(Console.ReadLine());
            //    j = int.Parse(Console.ReadLine());
            //    Console.WriteLine(i * j);
            //}

            //int[] arr = { 10, 50, 90, 30, };

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            int i = 5;

            do
            {
                Console.WriteLine(i);
            } while (i < 5);
        }
    }
}
