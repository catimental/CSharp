using System;

namespace A064_BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = { 3, 5, 2, 7, 1 };
            PrintArray(v);

            for(int i = 4; i>0; i--)
            {
                for(int j = 0; j<i; j++)
                    if(v[j] > v[j+1]) //n의 원소가 n+1보다 크다면 오름차순정렬
                    {
                        //스왑
                        int t = v[j]; 
                        v[j] = v[j + 1];
                        v[j + 1] = t;
                    }
                PrintArray(v);
            }
        }
        private static void PrintArray(int[] v)
        {
            foreach (var i in v)
                Console.Write("{0, 5}", i);
            Console.WriteLine();
        }
    }
}
