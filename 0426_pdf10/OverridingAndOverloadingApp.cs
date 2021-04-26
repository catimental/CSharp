using System;
namespace OverridingAndOverloadingApp
{
    class BaseClass
    {
        public void MethodA()
        {
            Console.WriteLine("In the BaseClass..");
        }
    }

    class DerviedClass : BaseClass
    {
        new public void MethodA()
        {//overriding
            Console.WriteLine("IN DerivedClass ... Overriding !!!");
        }

        public void MethodA(int i)
        { //overloading
            Console.WriteLine("In DerivedClass ... Overloading!!!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BaseClass obj1 = new BaseClass();
            DerviedClass obj2 = new DerviedClass();
            obj1.MethodA();
            obj2.MethodA();
            obj2.MethodA(1);
        }
    }
}
