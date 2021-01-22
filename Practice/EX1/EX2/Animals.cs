using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{
    class Animals
    {
        int weight;
        string name;

        public void Show()
        {
            Console.WriteLine("Name: {0}, Weight: {1}\n", name, weight);
        }
        public void SetMe(int weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }
    }
}
