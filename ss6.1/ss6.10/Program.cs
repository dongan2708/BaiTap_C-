using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss6._10
{
    class Program
    {
        static void Depreciation(out int val)
        {
            val = 2000;
            int dep = val * 5 / 100;
            int amt = val - dep;

        }
        static void Main(string[] args)
        {
            int value;
            Depreciation(out value);
            Console.WriteLine(value);
        }
    }
}
