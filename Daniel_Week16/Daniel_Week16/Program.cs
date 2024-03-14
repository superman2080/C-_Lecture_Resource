using System;
using System.Threading;

namespace Daniel_Week16
{
    public enum PocketMon
    {
        GRASS,
        FIRE,
        FLYING,
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("성적을 입력해주세요. : ");
            //int score = int.Parse(Console.ReadLine());

            //score /= 10;
            //switch (score)
            //{
            //    case 10:
            //        Console.WriteLine("A");
            //        break;

            //    case 9:
            //        Console.WriteLine("A");
            //        break;

            //    default:
            //        break;
            //}

            int beskin = 0;     //총합 31
            int my = 0;         //내가 낼 숫자 (1 ~ 3)
            int com = 0;        //컴퓨터가 낼 숫자(랜덤)
            bool isMyTurn = true;   //내 턴인가
            Random rand = new Random();

            while (true)
            {
                if (isMyTurn)
                {
                    Console.Write($"값을 입력해주세요. : (현재 {beskin}): ");
                    my = int.Parse(Console.ReadLine());
                    if (my < 1 || my > 3)
                    {
                        Console.WriteLine("다시 입력해주세요.");
                        continue;
                    }
                    beskin += my;
                }
                else
                {
                    com = rand.Next(1, 4);
                    Thread.Sleep(500);
                    Console.WriteLine($"컴퓨터가 {com}만큼 썼습니다.");
                    beskin += com;
                }

                if(beskin >= 31)
                {
                    if (isMyTurn == true)
                        Console.WriteLine("내가 졌습니다 ㅠㅠ");
                    else
                        Console.WriteLine("내가 이겼습니다!");
                    break;
                }

                isMyTurn = !isMyTurn;
            }
        }
    }
}
