using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory

{
    class ProductTest
    {
        static void Main(string[] args)
        {
            Product objProduct = new Product();
            objProduct.DisplayDetails();
            Console.WriteLine();

            Product objProduct1 = new Product(102);
            objProduct.DisplayDetails();
            Console.WriteLine();

            Product objProduct2 = new Product(103, "Television", 5660.45F, 68);
            objProduct2.DisplayDetails();


        }
    }
}
