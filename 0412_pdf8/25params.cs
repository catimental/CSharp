using System;

namespace A090_params
{
    class Program
    {

        public static void PrintIntParams(params int[] arr)
        {
            foreach (var i in arr)
                Console.Write(i+" ");
            Console.WriteLine();
        }

        public static void PrintObjectParams(params object[] arr)
        {
            foreach (var i in arr)
                Console.Write(i+" ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            PrintIntParams(1,2,3,4);
            PrintObjectParams(1, 1.234, 'a', "test");
            PrintObjectParams();
            
            int[] myIntArray = { 5, 6, 7, 8, 9 };
            PrintIntParams(myIntArray);
            object[] myObjArray = { 2, 2.345, 'b', "test", "again" };
            PrintObjectParams(myObjArray);
            PrintObjectParams(myIntArray);
        }
        

    }
        
}