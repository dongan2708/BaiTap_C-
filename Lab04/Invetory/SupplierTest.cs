using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invetory
{/// <summary>
/// Class SupplierTest is used to instanyiate the Supplier class.
/// </summary>
    class SupplierTest
    {
        static void Main(string[] args)
        {
            // Creating an object of hte Supplier class.
            Supplier objSupplier = new Supplier();

            //Invoking the AcceptDetails method of the Supplier class.
            //to accept the details of the supplier
            objSupplier.AcceptDetails();

            //Integer variabke to accept the id of the supplier
            int id = 0;

            //String variable to accept the name of the supplier
            string name = "";
            //Accept the id of the supplier
            Console.Write("\nEnter the id of the supplier : ");
            id = Convert.ToInt32(Console.ReadLine());

            objSupplier.DisplayDetails(id);

            Console.Write("\nEnter the name of the supplier : ");
            name = Console.ReadLine();

            objSupplier.DisplayDetails(name);
            objSupplier.DisplayDetails(id, name);
        }
    }
}
