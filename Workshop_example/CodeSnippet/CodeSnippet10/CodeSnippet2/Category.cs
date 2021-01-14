using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automotive
{
    public class Category
    {
        string category;
        public Category()
        {
            category = "Multi";
        }
        public void Display()
        {
            Console.WriteLine("Category " + category);
        }
    }
}