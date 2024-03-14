using System;

namespace CsharpGame
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] map = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Random rand = new Random();
            bool isMyTurn = true;
            int my = -1;
            int com = -1;

            while(my < map.Length && com < map.Length)
            {

                for (int i = 0; i < map.Length; i++)
                {
                    switch (map[i])
                    {
                        case 0:
                            Console.Write("□");
                            break;
                        case 1:
                            Console.Write("♥");
                            break;
                        default:
                            break;
                    }
                }
                if (isMyTurn)
                {
                    Console.WriteLine("엔터를 눌러 윷을 던져주세요!");
                    Console.ReadLine();
                    int value = rand.Next(1, 6);
                    string yut = "도";
                    switch (value)
                    {
                        case 1:
                            yut = "도";
                            break;
                        case 2:
                            yut = "개";
                            break;
                        case 3:
                            yut = "걸";
                            break;
                        case 4:
                            yut = "윷";
                            break;
                        case 5:
                            yut = "모";
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine(yut + "이 나왔습니다!");
                    my += value;
                    map[my] = 1;
                    isMyTurn = !isMyTurn;
                }
                else
                {
                    Console.ReadLine();
                }

            }

        }
    }
}
