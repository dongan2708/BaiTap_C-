﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss6._9
{
    class Program
    {
        static void Calculate(ref int numOne, ref int numTwo)
        {
            numOne = numOne * 2;
            numTwo = numTwo / 2;
        }
        static void Main(string[] args)
        {
            int numOne = 10;
            int numTwo = 20;
            Console.WriteLine("Value of numOne and numTwo before calling method : " + numOne + " , " + numTwo);
            Calculate(ref numOne, ref numTwo);
            Console.WriteLine("Aftef calling method : " + numOne + ", " + numTwo);
        }
    }
}
