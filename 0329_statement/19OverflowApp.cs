using System;
namespace OverflowApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, max = int.MaxValue;
            try
            {
                Console.WriteLine("Start of try statement");
                i = max +  1;
                Console.WriteLine("After default overflow");
                unchecked
                {
                    i = max + 1;
                }

                Console.WriteLine("After unchecked Statement");
                checked
                {
                    i = max + 1; //overflow
                }
                Console.WriteLine("after checked Statement");

            }
            catch (OverflowException e)
            {
                Console.WriteLine("caught an OverflowException");
            }

        }
    }
}
