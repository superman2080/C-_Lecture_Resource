using System;

namespace Daniel_week5
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool isMyTurn = true;
            //int total = 0;
            //int beskin = 0;

            //while (true)
            //{
            //    Console.WriteLine("현재 : " + total);
            //    if (isMyTurn)
            //    {
            //        Console.Write("숫자를 1부터 3까지 입력해주세요. : ");
            //        beskin = int.Parse(Console.ReadLine());
            //        total += beskin;
            //        Console.Clear();
            //    }
            //    else
            //    {
            //        Random rand = new Random();
            //        beskin = rand.Next(1, 4);
            //        Console.WriteLine(beskin + "만큼 말했습니다!");
            //        total += beskin;
            //    }
            //    if (total >= 31)
            //    {
            //        if (isMyTurn)
            //        {
            //            Console.WriteLine("당신은 패배하였습니다. ㅠㅠ");
            //        }
            //        else
            //        {
            //            Console.WriteLine("당신은 승리하였습니다!!!");
            //        }
            //        break;
            //    }
            //    isMyTurn = !isMyTurn;
            //}

            //int myHand = 0;
            //Console.Write("가위: 1\n바위: 2\n보: 3\n입력해주세요: ");
            //myHand = int.Parse(Console.ReadLine());
            //Random rand = new Random();
            //int otherHand = rand.Next(1, 4);
            //if( (myHand == 1 && otherHand == 3) ||
            //    (myHand == 2 && otherHand == 1) ||
            //    (myHand == 3 && otherHand == 2))
            //{
            //    Console.WriteLine("이겼습니다!!");
            //}
            //else if(    (myHand == 1 && otherHand == 2)||
            //            (myHand == 2 && otherHand == 3)||
            //            (myHand == 3 && otherHand == 1))
            //{
            //    Console.WriteLine("졌습니다.");
            //}
            //else
            //{
            //    Console.WriteLine("비겼습니다.");
            //}

            //Console.Write("상대는 ");
            //switch (otherHand)
            //{
            //    case 1:
            //        Console.Write("가위");
            //        break;
            //    case 2:
            //        Console.Write("바위");
            //        break;
            //    case 3:
            //        Console.Write("보");
            //        break;
            //    default:
            //        break;
            //}
            //Console.WriteLine("를 냈습니다.");

            ////랜덤값 1~100까지의 수를 내가 맞추는 게임
            //int count = 5;
            //int ans = 0;
            //int correct = 0;

            //Random rand = new Random();
            ////1~100
            //correct = rand.Next(1, 101);

            //while(count > 0)
            //{
            //    ans = int.Parse(Console.ReadLine());
            //    if(ans > correct)
            //    {
            //        Console.WriteLine("정답보다 큽니다");
            //    }
            //    else if(ans < correct)
            //    {
            //        Console.WriteLine("정답보다 작습니다");
            //    }
            //    else
            //    {
            //        Console.WriteLine("정답입니다!!");
            //        break;
            //    }
            //    count--;
            //}
            //if(count == 0)
            //{
            //    Console.WriteLine("정답을 맞추지 못했습니다..");
            //}
            //Console.WriteLine("정답은 : " + correct + "입니다.");

        }
    }
}
