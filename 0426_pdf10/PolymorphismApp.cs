using System;
using System.Runtime.InteropServices;

namespace PolymorphismApp
{
    class BaseClass
    {
        public virtual void Output()
        {
            Console.WriteLine("In the Base class ...");
        }
    }
    class DerivedClass : BaseClass
    {
        public override void Output() // new로하면 Base클래스를 참조함
        {
            Console.WriteLine("In the Derived class ...");
        }
    }
    class Program
    {
        static void Print(BaseClass obj)
        {
            obj.Output();
        }
        static void Main(string[] args)
        {
            BaseClass obj1 = new BaseClass();
            DerivedClass obj2 = new DerivedClass();
            Print(obj1);
            Print(obj2);
        }
    }
    
    
    
}
