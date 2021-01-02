using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss7._8
{
    class Area
    {
        static int CalculateArea(int len, int wide)
        {
            return len * wide;
        }
        static double CalculateArea(double valOne, double valTwo)
        {
            return 0.5 * valOne * valTwo;
        }
        static void Main(string[] args)
        {
            int length = 10;
            int breadth = 22;
            double tbase = 2.5;
            double height = 1.5;
            Console.WriteLine(CalculateArea(length, breadth) + " , " + CalculateArea(tbase, height));
        }
    }
}
