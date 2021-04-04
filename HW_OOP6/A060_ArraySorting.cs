using System;

namespace A060_ArraySorting
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "Mouse", "Cow", "Tiger", "Rabiit", "Dragon", "Snake", "Horse" };
            PrintArray("BeforeSort: ", name);
            Array.Reverse(name);
            PrintArray("AfterReverse: ", name);
            Array.Sort(name);
            PrintArray("AfterSort: ", name);
            Array.Reverse(name);
            PrintArray("AfterReverse: ", name);
        }
        private static void PrintArray(string s, string[] name)
        {
            Console.WriteLine(s);
            foreach (var n in name) 
                Console.Write("{0} ", n);
            Console.WriteLine();
    }
}
}