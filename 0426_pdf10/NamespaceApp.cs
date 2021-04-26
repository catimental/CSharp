﻿using System;
using System.Runtime.InteropServices;
using Shape;

namespace Shape
{
    public class Rectangle
    {
        public int height;
        public int width;

        public override string ToString()
        {
            return string.Format("Width: {0}, Height: {1}", width, height);
        }
    }
}

namespace NamespaceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.width = 10;
            rect.height = 20;
            Console.WriteLine("rect: "+rect); //ToString override
        }
    }
}
