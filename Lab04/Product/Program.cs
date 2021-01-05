using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{/// <summary>
/// the program demonstrates the use of the overloading a constructor.
/// 
/// Class Product creates three constructors to initialise the details of the
/// product and a method to display them.
/// </summary>
    class Product
    {///String field to store the ID f the product.
        private int _productID;
        ///String field to store the price of the product.
        private string _productName;
        ///Float field to store the price of the product.
        private float _price;
        ///Integer field to store the stock of the product.
        private int _stock;

        /// Constructor without parameters to initialise
        /// details of the product.
        public Product()
        {
            _productID = 101;
            _productName = "Refrigerstor";
            _price = 420.5F;
            _stock = 30;
}
        ///Constructor with a single  parmaeter to initialise
        ///details of the product.
        public Product(int id)
        {
            _productID = id;
            _productName = "Washing Machine";
            _price = 677.3F;
            _stock = 25;

        }
        ///<summary>
        ///Constructor with four parameters to initialise
        ///details of the product.
        /// </summary>
        /// <param name="id">Accept id of the product</param>
        /// <param name="name">Accept name of the product</param>
        /// <param name="price">Accept price of the product</param>
        /// <param name="stock">Accept stock of the product</param>
        public Product(int id, string name, float price, int stock)
        {
            _productID = id;
            _productName = name;
            _price = price;
            _stock = stock;

        }
        ///<summary>
        ///Method to display the details of the product.
        /// </summary>
        public void DisplayDetails()
        {
            Console.WriteLine("Product Details : ");
            Console.WriteLine("Product ID : " + _productID);
            Console.WriteLine("Product Name : " + _productName);
            Console.WriteLine("Price :" + _price);
            Console.WriteLine("Quantity in Stock : " + _stock);
        } 


    }
}
