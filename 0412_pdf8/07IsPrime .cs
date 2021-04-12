using System;

namespace A071_IsPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            //2~100까지의 소수찾기
            int count = 0;
            for (var i = 2; i <= 100; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write("{0} ", i);
                    count++;
                }
            }

            Console.WriteLine("\n2~100까지 소수는 모두 {0}개 있습니다.", count);
        }

        private static bool IsPrime(int x)
        {
            for (var i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}