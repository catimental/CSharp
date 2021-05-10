﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace A118_Predicate
{

    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isEvan = n => n % 2 == 0;
            Console.WriteLine(isEvan(6));

            Predicate<string> isLowerCase = s => s.Equals(s.ToLower());
            Console.WriteLine(isLowerCase("This is a lowercase string"));
            
        }
        static bool IsEven(int n) => n % 2 == 0;
        static bool IsLowerCase(string s) => s.Equals(s.ToLower());
    }
}