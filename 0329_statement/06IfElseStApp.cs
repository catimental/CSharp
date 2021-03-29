using System;
namespace IfElseStApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a number = ");
            n = Console.Read() - '0';
            if (n%2 == 0)
                Console.WriteLine(n + " is an even numer");
            else
                Console.WriteLine(n + " is an odd numer");
        }
    }
}
