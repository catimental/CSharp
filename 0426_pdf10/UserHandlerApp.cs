using System;
using System.Diagnostics;

namespace UserHandlerApp
{
    class UserExceptionOne : ApplicationException { }
    class UserExceptionTwo : ApplicationException { }
    class Program
    {
        static void Method(int i)
        {
            if (i == 1) throw new UserExceptionOne();
            else throw new UserExceptionTwo();
        }
        
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Here: 1");
                Method(2);
                Console.WriteLine("Here: 2");
            }
            catch (UserExceptionOne)
            {
                Console.WriteLine("UserExceptionOne is occurred!!!");
            }
            catch (UserExceptionTwo)
            {
                Console.WriteLine("UserExceptionTwo is occurred!!!");
            }
            Console.WriteLine("Here: 3");
        }
        
    }
}
