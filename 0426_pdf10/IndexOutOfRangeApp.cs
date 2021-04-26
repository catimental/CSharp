using System;
using System.Diagnostics;

namespace IndexOutOfRangeApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] vector = {1, 2, 3};
            vector[4] = 4;
        }
    }
}
