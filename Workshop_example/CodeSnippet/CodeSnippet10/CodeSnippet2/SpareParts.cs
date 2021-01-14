using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Automotive
{
    public class SpareParts
    {
        string spareName;
        public SpareParts()
        {
            spareName = "Gear Box";
        }
        public void Display()
        {
            Console.WriteLine("Eparea Part name : " + spareName);
        }

    }

}
