using System;
using System.Diagnostics;

namespace MyAttributeApp
{
    public class MyAttrAttribute : Attribute
    {//속성 클래스

        public MyAttrAttribute(string message)
        {
            this.message = message;
        }

        private string message;

        public string Message
        {
            get => message;
        }
    }
    
    [MyAttr("This is Attribute test.")]
    public class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Program);
            object[] arr = type.GetCustomAttributes(typeof(MyAttrAttribute), true);
            if(arr.Length == 0)
                Console.WriteLine("This class has no custom attrs.");
            else
            {
                MyAttrAttribute ma = (MyAttrAttribute) arr[0];
                Console.WriteLine(ma.Message);
            }
        }
    }
}
