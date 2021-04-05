using System;

namespace OverloadedConstructorApp
{
    class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction()
        {
            numerator = 0;
            denominator = 1;
        }
        public Fraction(int n)
        {
            numerator = n;
            denominator = 1;
        }
        public Fraction(int n, int d)
        {
            numerator = n;
            denominator = d;
        }

        public override string ToString()
        {
            return (numerator + "/" + denominator);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(), f2 = new Fraction(2),
                f3 = new Fraction(1, 2);
            Console.WriteLine("f1 = {0}, f2 = {1}, f3 = {2}", f1, f2, f3);
        }
    }
}