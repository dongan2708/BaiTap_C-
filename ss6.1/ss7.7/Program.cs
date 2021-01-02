using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss7._7
{

    class ITSystem
    {
        public virtual void Print()
        {
            Console.WriteLine("The sustem should be handled carefully");
        }
    }
    class Company : ITSystem
    {
        public sealed override void Print()
        {
            Console.WriteLine("The system information is confidential");
        }
    }
    
}
