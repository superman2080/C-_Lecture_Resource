using System;


namespace Daniel_Week21
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeNum = int.Parse(Console.ReadLine());
            int primeCnt = 0;

            for (int i = 0; i < primeNum; i++)
            {
                int comp = int.Parse(Console.ReadLine());
                bool isPrime = true;
                if (comp <= 1)
                    continue;
                for (int j = 2; j < comp / 2; j++)
                {
                    if (comp % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime == true)
                    primeCnt++;
            }
            Console.WriteLine(primeCnt);
        }
    }
}
