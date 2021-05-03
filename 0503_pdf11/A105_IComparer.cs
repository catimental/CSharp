using System;
using System.Collections;
using System.Collections.Generic;

namespace A105_IComparer
{
    public class ReverseComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            string s1 = (string)x;
            string s2 = (string)y;
            return string.Compare(s2, s1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] animalsEn = { "dog", "cow", "rabbit", "goat", "sheep", "mouse", "horse", "deer" };
            string[] animalsKo = { "개", "소", "토끼", "염소", "양", "쥐", "말", "사슴" };
            Display("초기 배열", animalsEn);
            Array.Sort(animalsEn);
            Array.Reverse(animalsEn);
            Display("Sort() 후 Reverse()", animalsEn);
            Display("초기 배열", animalsKo);
            Array.Sort(animalsKo, 2, 3);
            Display("[2]에서 3개 정렬 후", animalsKo);
            IComparer revComparer = new ReverseComparer();
            Array.Sort(animalsKo, revComparer);
            Display("내림차순 정렬", animalsKo);

        }
        private static void Display(string comment, string[] arr)
        {
            Console.WriteLine(comment);
            for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
            {
                Console.Write(" {0}", arr[i]);
            }
            Console.WriteLine();
        }


        private static void PrintValues(List<int> a)
        {
            Console.WriteLine("Print Values in List<int>");
            Console.WriteLine(" Count = {0}", a.Count);
            Console.WriteLine(" Capacity = {0}", a.Capacity);
            foreach (var i in a)
                Console.Write(" {0}", i);
            Console.WriteLine();
        }
    }
}
