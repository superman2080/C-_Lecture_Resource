using System;

namespace Daniel_Week17
{
    class Program
    {
        //static 반환값 함수명(매개변수)
        //{
        //    연산부;
        //    return 반환값;
        //}

        //가독성
        //코드의 재사용성

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Sum(5, 3));
            //Random rand = new Random();
            //int my = 0;
            //int cnt = 0;
            //int cor = rand.Next(1, 99);

            //while(cnt < 7)
            //{
            //    Console.Write($"숫자를 입력해주세요. (남은 횟수: {7 - cnt}): ");
            //    my = int.Parse(Console.ReadLine());
            //    if(cor < my)
            //    {
            //        Console.WriteLine("Down");
            //    }
            //    else if(cor > my)
            //    {
            //        Console.WriteLine("Up");
            //    }
            //    else
            //    {
            //        Console.WriteLine("정답입니다!");
            //        break;
            //    }
            //    cnt++;
            //}
            //if(cnt >= 7)
            //{
            //    Console.WriteLine("정답을 맞추지 못했습니다...");
            //    Console.WriteLine("정답은 " + cor.ToString());
            //}

            //int cnt = 0;
            //int min = 1;
            //int max = 99;
            //int ans = 0;
            //bool correct = false;
            //Random rand = new Random();
            //while(cnt < 7)
            //{
            //    if(max - min <= 5)
            //    {
            //        ans = rand.Next(min, max);
            //    }
            //    else
            //    {
            //        ans = (min + max) / 2;
            //    }

            //    Console.Write($"{ans}인가요?(u/d/y): ");
            //    string respond = Console.ReadLine();
            //    switch (respond)
            //    {
            //        case "u":
            //            min = ans + 1;
            //            break;
            //        case "d":
            //            max = ans - 1;
            //            break;
            //        case "y":
            //            Console.WriteLine("정답입니다!");
            //            correct = true;
            //            break;
            //        default:
            //            continue;
            //    }
            //    if(correct == true)
            //    {
            //        break;
            //    }
            //    cnt++;
            //}
            //if(correct == false)
            //{
            //    Console.WriteLine("정답을 맞추지 못했습니다..");
            //}
        }
    }
}
