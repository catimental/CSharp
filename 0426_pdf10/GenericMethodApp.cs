using System;
using System.Runtime.InteropServices;

namespace GenericMethodApp
{
    class Program
    {
        static void Swap<DataType>(ref DataType x, ref DataType y) //일반 함수에서 제네릭사용법
        {
            DataType temp;
            temp = x;
            x = y;
            y = temp;
        }
        
        static void Main(string[] args)
        {
            int a = 1, b = 2; double c = 1.5, d = 2.5;
            Console.WriteLine("Before: a = {0}, b = {1}", a, b);
            Swap<int>(ref a, ref b);
            Console.WriteLine("After: a = {0}, b = {1}", a, b);
            Console.WriteLine("Before: c = {0}, d = {1}", c, d);
            Swap<double>(ref c, ref d);
            Console.WriteLine("After: c = {0}, d = {1}", c, d);
        }
    }
}
