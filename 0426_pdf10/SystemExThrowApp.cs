using System;
using System.Diagnostics;

namespace SystemExThrowApp
{
    class SystemExThrow
    {
        public static void Exp(int ptr)
        {
            if (ptr == 0)
                throw new NullReferenceException();
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            SystemExThrow.Exp(i);
        }
        
    }
}
