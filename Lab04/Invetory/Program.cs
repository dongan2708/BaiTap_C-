using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invetory
{
    /// <summary>
    /// The program demonstrates the use of method overloading with access modifiers.
    /// Class Supplier accepts and displays the details of the supplier.
    /// </summary>
    class Supplier
    {
        ///Integer field to store the ID of the supplier
        private int _supplierID;

        /// <summary>
        ///String field to store the name of the supplier. 
        /// </summary>
        private string _supplierName;

        /// <summary>
        /// String field to store the city of the supplier
        /// </summary>
        private string _city;

        /// <summary>
        ///String field to store the phone number of the supplier 
        /// </summary>
        private string _phoneNo;

        /// <summary>
        ///String field to store the email address of the supplier
        /// </summary>
        private string _email;

        /// <summary>
        /// Method to accept the details of the supplier.
        /// </summary>
        internal void AcceptDetails()
        {
            Console.Write("Enter the ID of supplier : ");
            _supplierID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the name of supplier : ");
            _supplierName = Console.ReadLine();
            Console.Write("Enter the name of city : ");
            _city = Console.ReadLine();
            Console.Write("Enter phone No. : ");
            _phoneNo = Console.ReadLine();
            Console.Write("Enter email address : ");
            _email = Console.ReadLine();

        }
        /// <summary>
        /// Method to display the ID of the supplier.
        /// </summary>
        /// <param name="supplierID">Accepts id of the supplier</param>
        internal void DisplayDetails(int supplierID)
        {
            Console.WriteLine("Supplier ID : " + supplierID);
        }

        /// <summary>
        ///Method to display the name of the supplier.
        /// </summary>
        /// <param name="supplierName">Accept name of the supplier</param>
        internal void DisplayDetails(string supplierName)
        {
            Console.WriteLine("Supplier Name : " + supplierName);
        }

        /// <summary>
        /// Method to display the city of the supplier
        /// </summary>
        /// <param name="supplierID">Accept id of the supplier</param>
        /// <param name="supplierName">Accept name if the supplier</param>
        
        internal void DisplayDetails(int supplierID, string supplierName)
        {
            Console.WriteLine("\nSupplier {0} with ID {1} lives in city {2}", supplierName, supplierID, _city);

        }
    }
}
