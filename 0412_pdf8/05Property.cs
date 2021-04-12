﻿using System;

namespace A069_Property
{
    class Rectangle
    {
        private double width;
        private double height;

        public double Area()
        {
            return width * height;
        }

        public double GetWidth()
        {
            return width;
        }

        public double GetHeight()
        {
            return height;
        }
        
        public void SetWidth(double width)
        {
            this.width = width;
        }
        public void SetHeight(double height)
        {
            this.height = height;
        }

    }

    class RectWithProp
    {
        public double Width { get; set; } // Width 속성
        public double Height { get; set; } // Height 속성
        public double Area()
        {
            return Width * Height;
        }

    }
    class RectWithPropFull
    {
        private double width;
        public double Width
        {
            get { return width; }
            set { if(value > 0 ) width = value; }
        }
        private double height;
        public double Height
        {
            get { return height; }
            set { if (value >= 0) height = value; }
        }
    }
}