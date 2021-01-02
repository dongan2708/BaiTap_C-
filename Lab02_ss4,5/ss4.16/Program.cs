using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss4._16
{
    class Program
    {
        static void Main(string[] args)
        {
            int fact = 1;
            int num = 1;
            Console.WriteLine("Enter the number whose factorial you wish to calcu;ate :");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; fact *= i++) ;
            Console.WriteLine(fact);
        }
    }
}
