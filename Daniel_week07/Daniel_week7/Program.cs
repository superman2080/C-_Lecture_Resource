using System;
using System.Collections.Generic;
namespace Daniel_week7
{
    class Program
    {
        static void Main(string[] args)
        {
            //변수, 입출력, 조건문(if, switch), 반복문(for, while), 배열(1차원, 2차원), 리스트

            //for(선언, 범위, 증감)
            //while(조건이 맞을때 반복)

            //for (int i = 0; i < length; i++)
            //{

            //}

            //while ()
            //{

            //}

            ////입력
            //int cnt = int.Parse(Console.ReadLine());
            //int result = 0;
            //List<int> primes = new List<int>();
            //for (int i = 0; i < cnt; i++)
            //{
            //    int temp = int.Parse(Console.ReadLine());
            //    primes.Add(temp);
            //}
            ////

            ////1보다는 크며
            ////1과 본인의 수로만 나눌 수 있는 수
            ////소수

            ////판별
            //foreach (var num in primes)
            //{
            //    bool isPrime = true;
            //    if (num <= 1)
            //        isPrime = false;

            //    for (int i = 2; i < num; i++)
            //    {
            //        if (num % i == 0)        //나눠진다
            //            isPrime = false;
            //    }
            //    if (isPrime == true)
            //        result += 1;
            //}
            ////
            //Console.WriteLine(result);

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int result = 0;

            List<int> nums = new List<int>();
            for (int i = 0; i < b + 1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    nums.Add(i);
                }
            }

            //foreach (var num in nums)
            //{
            //    Console.Write(num);
            //}

            for (int i = 0; i < b + 1; i++)
            {
                if (i >= a - 1 && i < b)
                    result += nums[i];
            }
            Console.WriteLine(result);
        }
    }
}
