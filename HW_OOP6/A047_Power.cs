using System;

namespace A047_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n! 을계산합니다.");
            Console.Write("정수 n을입력하세요: ");
            int n = int.Parse(Console.ReadLine());
            int fact = 1;
            
            for (int i = 2; i <= n; i++)
                fact *= i;

            Console.WriteLine("{0}! = {1}", n, fact);
        }
    }
}