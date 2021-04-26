using System;
namespace AbstractClassApp
{
    abstract class AbstractClass
    {
        public abstract void MethodA();

        public void MethodB()
        {
            Console.WriteLine("Implementation of MethodB()");
        }
    }

    class ImpClass : AbstractClass
    {
        public override void MethodA()
        {
            Console.WriteLine("Implementationm of MethodA()");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ImpClass obj = new ImpClass();
            obj.MethodA();
            obj.MethodB();
        }
        
    }
    
}
