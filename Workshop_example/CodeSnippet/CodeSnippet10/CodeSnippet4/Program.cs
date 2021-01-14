using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility_Vehicle
{   namespace Car
   {
       class Category  
        {        string category;
            public Category()    
            {
                category = "Luxury Vehicle";
           }
           public void Display()
            {
                Console.WriteLine("car category : " + category);
            }
        }
    }

}
