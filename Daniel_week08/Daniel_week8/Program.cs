using System;

namespace Daniel_week8
{
    class Program
    {
        static void Main(string[] args)
        {
            //int count = 5;
            //int ans = 0;
            //int correct = 0;

            //Random rand = new Random();
            //correct = rand.Next(1, 101);

            //while (true)
            //{
            //    while (count > 0)
            //    {
            //        ans = int.Parse(Console.ReadLine());
            //        if (ans < correct)
            //        {
            //            Console.WriteLine("정답보다 작습니다");
            //        }
            //        else if (ans > correct)
            //        {
            //            Console.WriteLine("정답보다 큽니다");
            //        }
            //        else
            //        {
            //            Console.WriteLine("정답입니다");
            //            break;
            //        }
            //        count--;
            //        if (count == 0)
            //        {
            //            Console.WriteLine("정답을 맞추지 못햇습니다");
            //            Console.WriteLine("정답은 : " + correct + "입니다");
            //            break;
            //        }
            //    }

            //    Console.WriteLine("다시 하시겠습니까? : Y/n");
            //    string re = Console.ReadLine();
            //    bool end = false;
            //    switch (re)
            //    {
            //        case "Y":
            //            count = 5;
            //            break;
            //        case "n":
            //            end = true;
            //            break;
            //        default:
            //            Console.WriteLine("다시 입력해주세요.");
            //            break;
            //    }
            //    Console.Clear();
            //    if (end == true)
            //        break;
            //}
            //주어진 카운트안에 1~100사이의 값을 맞추는 게임
            int cnt = 0;
            int min = 0;
            int max = 100;
            bool correct = false;
            int ans = 0;
            Random rand = new Random();
            while (cnt < 5)
            {
                if (max - min <= 5)
                {
                    ans = rand.Next(min, max + 1);
                }
                else
                {
                    ans = (min + max) / 2;
                }
                Console.WriteLine(ans + "인가요?");
                string res = Console.ReadLine();
                switch (res)
                {
                    case "u":
                        min = ans + 1;
                        break;
                    case "d":
                        max = ans - 1;
                        break;
                    case "y":
                        correct = true;
                        break;
                    default:
                        break;
                }
                if (correct == true)
                    break;
                cnt++;
            }
            if (correct == true)
            {
                Console.WriteLine("정답은 " + ans + "입니다!");
            }
            else
            {
                Console.WriteLine("정답을 맞추지 못했습니다..");
            }
        }
    }
}
