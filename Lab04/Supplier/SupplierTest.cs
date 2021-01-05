using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    /// <summary>
    /// Class SupplierTest is used to instantiate the Supplier class.
    /// </summary>
    class SupplierTest
    {
        /// The entry point for the application.
        static void Main(string[] args)
        {
            //Creating an object of the supplier class
            Supplier objSupplier = new Supplier();
            //Invoking the AcceptDetails method of the Supplier class
            //to accept the details of the supplier
            objSupplier.AcceptDetails();
            //Invoking the DisplayDetails method of the Supplier  class
            //to display the details of the supplier
            objSupplier.DisplayDetail();
        }
    }
}
