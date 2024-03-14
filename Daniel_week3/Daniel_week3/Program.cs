using System;

namespace Daniel_week3
{
    class Program
    {
        static void Main(string[] args)
        {
            //대입, 증감, 논리, 할당, 비트, 시프트, 삼항

            //

            //int a = 0;
            //int b = 0;
            //Console.WriteLine(a > b ? "A는 B보다 큽니다" : "A는 B보다 작거나 같습니다");

            //제어문
            //조건문, 반복문
            //if
            //if, else if, else

            //switch-case
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());

            //삼각형의 둘레
            // a변이 b+c보다 크다면?
            //if (a + b > c && b + c > a && c + a > b)
            //{
            //    Console.WriteLine("삼각형입니다");
            //}
            //else
            //{
            //    Console.WriteLine("삼각형이 아닙니다");
            //}

            //int a = 11;

            //switch (a)
            //{
            //    case 10:
            //        Console.WriteLine("10");
            //        break;
            //    case 9:
            //        Console.WriteLine("9");
            //        break;
            //    case 8:
            //        Console.WriteLine("8");
            //        break;
            //    case 7:
            //        Console.WriteLine("7");
            //        break;
            //    default:
            //        Console.WriteLine("해당 조건이 없습니다.");
            //        break;
            //}

            int score = int.Parse(Console.ReadLine());

            float grade = score / 10f;

            switch (grade)
            {
                case 10:
                    Console.WriteLine("당신의 성적은 A입니다");
                    break;
                case 9:
                    Console.WriteLine("당신의 성적은 A입니다");
                    break;
                case 8:
                    Console.WriteLine("당신의 성적은 B입니다");
                    break;
                case 7:
                    Console.WriteLine("당신의 성적은 C입니다");
                    break;
                case 6:
                    Console.WriteLine("당신의 성적은 D입니다");
                    break;
                default:
                    Console.WriteLine("당신의 성적은 F입니다");
                    break;
            }
        }
    }
}
