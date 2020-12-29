using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example6
{
    class Program
    {
        private static float _pi;

        static void Main(string[] args) { 
            const float_pi=3.14F;
            float radius = 5;
            float area =_pi * radius * radius;
            Console.WriteLine("Area of the circle is" + area);
        }
    }
}
