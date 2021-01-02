using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss6._15
{
    class Program
    {
        static int valueOne = 10;
        static int product;
        static Program()
        {
            Console.WriteLine("static contrctor initialized");
            product = valueOne * valueOne;
        }
        public static void Method()
        {
            Console.WriteLine("value of product = " + product);
        }
        static void Main(string[] args)
        {
            Program.Method();
        }
    }
}
