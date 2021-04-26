using System;
using System.Diagnostics;

namespace UserExceptionApp
{
    class UserErrException : ApplicationException
    {
        public UserErrException(string s) : base(s){}
    }
    
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new UserErrException("throw a exception with a message");
            }
            catch (UserErrException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
