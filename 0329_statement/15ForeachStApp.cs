using System;
namespace ForeachStApp
{
    class Program
    { // h(n) = 1 + 1/2 + 1/3 + ... + 1/n
        static void Main(string[] args)
        {
            string[] color = { "red", "green", "blue" };
            foreach(string s in color)
                Console.WriteLine(s);
        }
    }
}
