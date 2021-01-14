using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet12._3
{
    public delegate void MAths(int valOne, int valTwo);
    class MathsDemo
    {
        static void Additon(int valOne, int valTwo)
        {
            int result = valOne + valTwo;
            Console.WriteLine(valOne + " + " + valTwo + " = " + result);
        }
        static void Subtraction(int valOne, int valTwo)
        {
            int result = valOne - valTwo;
            Console.WriteLine(valOne + " - " + valTwo + " = " + result);

        }
        static void Multiplication(int valOne, int valTwo)
        {
            int result = valOne * valTwo;
            Console.WriteLine(valOne + " * " + valTwo + " = " + result);

        }
        static void Division(int valOne, int valTwo)
        {
            int result = valOne / valTwo;
            Console.WriteLine(valOne + " / " + valTwo + " = " + result);

        }
        static void Main(string[] args)
        {
            MAths objMath = new MAths(Additon);
            objMath += new MAths(Subtraction);
            objMath += new MAths(Multiplication);
            objMath += new MAths(Division);
            objMath?.Invoke(20, 10);
        }
    }
}
