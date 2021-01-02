using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            while (i <= 5)
            {
                j = 0;
                while (j <= 1)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
        }
    }
}
