using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss6._11
{
    class Program
    {
        static int Quare(int num)
        {
            return num * num;
        }
        static float Quare(float num)
        {
            return num * num;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Quare(5) + " ," + Quare(2.5F));
        }
    }
}
