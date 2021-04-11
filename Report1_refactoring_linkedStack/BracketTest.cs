using System;

namespace Report1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            OptExp opt = new OptExp();
            string exp = "3(3*5)-6/2)";
            Console.WriteLine(exp);

            /*
             * another Usage
             * opt.Expression = exp;
             * if (opt.TestPair())
             */
            
            if (opt.TestPair(exp))
                Console.WriteLine("괄호 맞음!!");
            else
                Console.WriteLine("괄호 틀림!!");
        }
    }
}