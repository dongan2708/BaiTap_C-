﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss6._5
{
    class Program
    {
        void printMess(string message = "Hello user")
        {
            Console.WriteLine("{0}", message);
        }
        static void Main(string args)
        {
            Program obj = new Program();
            obj.printMess("Welcome USer");
            obj.printMess();
        }
    }
}
