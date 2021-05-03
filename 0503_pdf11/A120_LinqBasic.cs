using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace A119_ListAndLambda
{

    class Program
    {
        static void Main(string[] args)
        {
            //List에서 짝수 데이터를 꺼내서 정렬하여 출력한다.
            List<int> data = new List<int> {123, 45, 12, 89, 456, 1, 4, 74, 46};
            List<int> lstSortedEven = new List<int>();
            
            foreach (var item in data)
            {
                if (item % 2 == 0)
                    lstSortedEven.Add(item);
            }
            lstSortedEven.Sort();
            Console.WriteLine("Using foreach: ");
            foreach (var item in lstSortedEven)
                Console.Write(item + " ");
            Console.WriteLine();

            var sortedEvan = from item in data
                where item % 2 == 0
                orderby item
                select item;

            Console.WriteLine("\nUsing Linq");
            foreach (var item in sortedEvan)
                Console.Write(item + " ");
            Console.WriteLine();

        }
    }
}
