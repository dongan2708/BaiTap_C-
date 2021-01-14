using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnippet7
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numOne = 200;
            byte numTwo = 5;

            byte result = 0;
            try
            {
                result = checked((byte)(numOne * numTwo));
                Console.WriteLine("Result = {0}", result);
            }

            catch (Exception objEx)
            {
                Console.WriteLine("Error : {0}", objEx.ToString());
                Console.WriteLine("Exception : {0}", objEx.GetType());

            }
        }
    }
}
