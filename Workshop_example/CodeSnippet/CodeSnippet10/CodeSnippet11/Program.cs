using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnippet11
{
    class Program
    {
        static void Evaluate(string arg)
        {
            var val = arg ?? throw new ArgumentException("Invalid argument");
            Console.WriteLine("Reached this point");
        }
        static void Main()
        {
            Evaluate("number");
            Evaluate(null);
        }
    }
}
