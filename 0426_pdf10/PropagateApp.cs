using System;
using System.Diagnostics;

namespace PropagateApp
{
    class Propagate
    {
        public void Orange()
        {
            int i = 25, j = 0;
            i = i / j;
            Console.WriteLine("End of Orange method");
        }

        public void Apple()
        {
            Orange();
            Console.WriteLine("End of Apple method");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Propagate p = new Propagate();
            try
            {
                p.Apple();
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("ArithmeticException is processed");
            }

            Console.WriteLine("End of Main");
            
        }
    }
}
