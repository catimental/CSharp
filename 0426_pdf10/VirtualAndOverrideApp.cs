using System;
namespace VirtualAndOverrideApp
{
    class CLanguage
    {
        virtual public void Print()
        {
            Console.WriteLine("In The Clanguage class ...");
        }
    }

    class Java : CLanguage
    {
        public override void Print()
        {
            Console.WriteLine("In the Java class ...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CLanguage c = new Java();
            c.Print();
        }
    }
    
    
    
}
