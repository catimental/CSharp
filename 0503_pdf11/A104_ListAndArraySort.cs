using System;
using System.Collections;
using System.Collections.Generic;

namespace A104_ListAndArraySort
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> lstNames = new List<string>();
            lstNames.Add("dog");
            lstNames.Add("cow");
            lstNames.Add("rabbit");
            lstNames.Add("goat");
            lstNames.Add("sheep");
            lstNames.Sort();
            foreach (string s in lstNames)
                Console.Write(s + " ");
            Console.WriteLine();
            string[] arrNames = new string[100];
            arrNames[0] = "dog";
            arrNames[1] = "cow";
            arrNames[2] = "rabbit";
            arrNames[3] = "goat";
            arrNames[4] = "sheep";
            Array.Sort(arrNames);
            foreach (string s in lstNames)
                Console.Write(s + " ");
            Console.WriteLine();
        }

        private static void PrintValues(ArrayList a)
        {
            Console.WriteLine("Print Values in ArrayList");
            Console.WriteLine(" Count = {0}", a.Count);
            Console.WriteLine(" Capacity = {0}", a.Capacity);
            foreach (var i in a)
                Console.Write(" {0}", i);
            Console.WriteLine();
        }

    }
}
