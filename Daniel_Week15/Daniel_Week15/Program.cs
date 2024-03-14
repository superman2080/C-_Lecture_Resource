using System;

namespace Daniel_Week15
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 2; i < 10; i++)
            //{
            //    for (int j = 2; j < 10; j++)
            //    {
            //        Console.Write($"{i} * {j} = {i * j}\t");
            //        //Console.WriteLine(i + " * " + j + " = " + i * j);
            //        //Console.WriteLine(string.Format("{0} * {1} * {2}", i, j, i * j));
            //    }
            //    Console.WriteLine();
            //}

            //for (int y = 1; y <= 7; y++)
            //{
            //    for (int x = 0; x < 7 - y; x++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int x = 1; x <= y * 2 - 1; x++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            int n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 0:
                    Console.WriteLine("0!!");
                    break;
                case 7:
                    Console.WriteLine("!?");
                    break;
                default:
                    Console.WriteLine("?");
                    break;
            }

            //if(n == 0)
            //{
            //    Console.WriteLine("0!!");
            //    //
            //}
            //else if(n == 7)
            //{
            //    Console.WriteLine("!?");
            //}
            //else
            //{
            //    Console.WriteLine("?");
            //}
        }
    }
}
