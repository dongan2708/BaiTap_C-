using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss4._19
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i < 10; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }
                Console.WriteLine(i + "  ");
            }
        }
    }
}
