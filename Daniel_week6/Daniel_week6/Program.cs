using System;
using System.Collections.Generic;

namespace Daniel_week6
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] arr = new int[10, 10];

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        arr[i, j] = i * j;
            //    }
            //}

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write(arr[i, j]+"\t");
            //    }
            //    Console.WriteLine();
            //}
            //List<int> list = new List<int>();
            //list.Add(0);
            //list.Add(6);
            //list.Add(9);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] arr = new int[5];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //int min = arr[0];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (min > arr[i])
            //        min = arr[i];
            //}
            //Console.WriteLine(min);

            int[,] arr = new int[3, 4];
            Random rand = new Random();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(0, 10);
                }
            }
            int total = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    total += arr[i, j];
                }
            }
            Console.WriteLine("전체 값은 : " + total);
            Console.WriteLine("평균 값은 : " + total / (arr.GetLength(0) * arr.GetLength(1)));
        }
    }
}
