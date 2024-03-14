using System;

namespace Daniel_Week13
{
    class Program
    {
        static void Main(string[] args)
        {
            //파싱: 어떤 데이터를 쓰기 쉽도록 변환하는 과정
            //int a = int.Parse(Console.ReadLine());
            ////int b = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //산술연산자
            // +, -, *, /, %

            //할당 연산
            // =, +=, -=, *=, /=, %=
            // a = a + b
            // a += b

            // 증감 연산
            // 전위연산 
            // a++
            // a += 1
            // 후위연산
            // ++a

            // a--
            // a -= 1

            //논리연산
            // && (and) == 두 값이 모두 참일때
            // || (or) == 두 값 중 하나만 참이어도 참
            // ! (not) == true = false, false = true

            // 관계연산
            // >, <, ==, !=, >=, <=


            //Console.WriteLine(!b2);
            int a = int.Parse(Console.ReadLine());

            if (a >= 10 && a <= 20)
            {
                //실행되는 코드...
                Console.WriteLine("!");
            }
            else if (a == 15)
            {
                Console.WriteLine("!!");
            }
            else
            {
                Console.WriteLine("?");
            }
        }
    }
}
