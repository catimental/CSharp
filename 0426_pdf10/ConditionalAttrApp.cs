#define CSHARP
using System;
using System.Diagnostics;

namespace GenericMethodApp
{
    class ConditionalAttr
    {
        [Conditional("CSHARP")]
        public static void CsharpMethod()
        {
            Console.WriteLine("In the CSharp Method ...");
        }

        [Conditional("JAVA")]
        public static void JavaMethod()
        {
            Console.WriteLine("In the Java Method ...");
        }
        
        
    }
    

    public class Program
    {
        static void Main(string[] args)
        {
            ConditionalAttr.CsharpMethod();
            ConditionalAttr.JavaMethod();
        }
    }
}
