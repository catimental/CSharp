using System;
using System.Diagnostics;

namespace ObsoleteAttrApp
{
    class ObsoleteAttr
    {
        [Obsolete("경고, Obsolete Method입니다")]
        public static void OldMethod()
        {
            Console.WriteLine("In the Old Method...");
        }

        public static void NormalMethod()
        {
            Console.WriteLine("In the Normal Method ...");
        }
        
    }
    
    public class Program
    {
        static void Main(string[] args)
        {
            ObsoleteAttr.OldMethod();
            ObsoleteAttr.NormalMethod();
        }
    }
}
