using System;
using System.Diagnostics;

namespace UserExThrowApp
{
    class UserException : ApplicationException
    {
    }

    class Program
    {
        static void Method()
        {
            throw new UserException();
        }
        
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Here: 1");
                Method();
                Console.WriteLine("Here: 2");
            }
            catch (UserException)
            {
                Console.WriteLine("User-difined Exception");
            }
        }
    }
}
