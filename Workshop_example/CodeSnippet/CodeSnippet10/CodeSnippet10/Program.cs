using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnippet10
{
    class Employee
    {
        static void ThrowException(string name)
        {
            if (name == null)
            {
                throw new ArgumentException();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Throw Example");
            try
            {
                string name = null;
                ThrowException(name);
            }
            catch (ArgumentException objNull)
            {
                Console.WriteLine("Exception : " + objNull);
            }
        }
    }
}