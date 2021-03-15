using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemProgramming._0315
{
    class PropertyClass
    {
        private int privateValue;
        public int PrivateValue
        {
            get { return privateValue; }
            set { privateValue = value; }
        }

        public void PrintValue()
        {
            Console.WriteLine("Hidden Value = " + privateValue);
        }
    }
    class PropertyApp
    {
        public static void Main()
        {
            int n;
            PropertyClass obj = new PropertyClass();
            obj.PrivateValue = 100; // invoke set-accessor
            obj.PrintValue();
            n = obj.PrivateValue; // invoke get-accessor
            Console.WriteLine(" Value = " + n);
        }
    }
}
