using System;
using System.Runtime.InteropServices;

namespace GenericMethodApp
{
    class GenericType<T> where T : SystemException
    {
        private T value;

        public GenericType(T v)
        {
            value = v;
        }

        public override string ToString()
        {
            return "Type is " + value.GetType(); // 런타임에 타입알아내기
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            GenericType<NullReferenceException> gNullEx = new GenericType<NullReferenceException>(new NullReferenceException());
            GenericType<IndexOutOfRangeException> gIndexEx = new GenericType<IndexOutOfRangeException>(new IndexOutOfRangeException());
            
            // GenericType<String> gString = new GenericType<String>("Error"); //에러
            Console.WriteLine(gNullEx.ToString());
            Console.WriteLine(gIndexEx.ToString());
        }
    }
}
