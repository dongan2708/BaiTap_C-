using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss7._2
{
    class Aninmal
    {
        protected string Food;
        protected string Activity;

    }
    class Cat : Aninmal
    {
        static void Main(string[] args)
        {
            Cat objCat = new Cat();
            objCat.Food = "Mouse";
            objCat.Activity = "laze around";

        }
    }
}
