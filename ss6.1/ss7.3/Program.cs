using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss7._3
{
    class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal constructor without parameters");
        }
        public Animal(string name)
        {
            Console.WriteLine("Animal constructor with a string parameter");
        }

    }
    class Canine : Animal
    {
        public Canine() : base("Lion")
        {
            Console.WriteLine("Derived Canine");
        }

    }
    class Details
    {
        static void Main(string[] args)
        {
            Canine obj = new Canine();
        }
    }
}
