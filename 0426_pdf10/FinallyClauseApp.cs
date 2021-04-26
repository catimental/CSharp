using System;
using System.Diagnostics;

namespace FinallyClauseApp
{

    class Program
    {
        private static int count = 0;
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    if (++count == 1) throw new Exception();
                    if (count == 3) break;
                    Console.WriteLine(count + ") No Exception");
                }
                catch (Exception)
                {
                    Console.WriteLine(count + ") Exception thrown");
                }
                finally
                {
                    Console.WriteLine(count +") in finally clause");
                }
            } // end while

            Console.WriteLine("Main Program ends");
        }
    }
}
