using System;
using System.Collections.Generic;

namespace Daniel_week5
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //int a = int.Parse(Console.ReadLine());
            //int i = 2;
            //while (i < 10)
            //{
            //    Console.WriteLine(a + " x " + i + " = " + a * i);
            //    i++;
            //}

            //for (int i = 2; i < 10; i++)
            //{
            //    for (int j = 2; j < 10; j++)
            //    {
            //        Console.WriteLine(i + " x " + j + " = " + j * i);
            //    }
            //    Console.WriteLine();
            //}
            //int cnt = 0;
            //list.Add(10);
            //list.Add(650);
            //list.Remove(650);

            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            List<int> lotto = new List<int>();
            Random rand = new Random();

            int cnt = 0;
            int temp = 0;
            while (cnt < 6)
            {
                if (cnt == 0)                //비교할 값이 없을 때(로또 리스트가 비어있을 때)
                {
                    temp = rand.Next(1, 51);
                    lotto.Add(temp);
                    cnt++;
                }
                else                        //비교할 값이 존재할 때
                {
                    while (true)
                    {
                        temp = rand.Next(1, 51);
                        bool notEqual = true;
                        for (int i = 0; i < lotto.Count; i++)
                        {
                            if (lotto[i] == temp)           //중복값이 나왔을 때
                            {
                                notEqual = false;
                                break;
                            }
                        }

                        if (notEqual == true)
                            break;
                    }
                    lotto.Add(temp);
                    cnt++;
                }

            }

            lotto.Sort();

            int num1 = 1;
            int num2 = 1;
            int fibo = 0;
            for (int i = 2; i < 8; i++)
            {
                fibo = num1 + num2;
                num1 = num2;
                num2 = fibo;
                Console.WriteLine(fibo);
            }
        }
    }
}
