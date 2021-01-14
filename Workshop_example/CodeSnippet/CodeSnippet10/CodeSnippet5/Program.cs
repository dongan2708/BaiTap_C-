using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnippet5
{
    class DivisionERRor
    {
        static void Main(string[] args)
        {
            int num = 122;
            int numTwo = 0;
            int result;
            try
            {
                result = num / numTwo;
            }
            catch (DivideByZeroException obj)
            {
                Console.WriteLine("Exception Caught : " + obj);
            }
        }
    }
}

