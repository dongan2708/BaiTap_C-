using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss7._1
{

    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("eat");
        }
    }

    class Mammal : Animal
    {
        public void Feature()
        {
            Console.WriteLine("Mammals give birth to young one");
        }
    }
    class Dog : Mammal
    {
        public void Noise()
        {
            Console.WriteLine("Dog Barks");
        }
        static void Main(string[] args)
        {
            Dog objDog = new Dog();
            objDog.Eat();
            objDog.Feature();
            objDog.Noise();
        }
    }
}
