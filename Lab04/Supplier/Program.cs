using System; 
using System.Collections.Generic;
using System.Text;

namespace Inventory
{
    class Supplier
    {
        ///Integer field to store the ID of the supplier.
        private int _supplierID;
        ///String field yo store the name of the supplier.
        private string _supplierName;
        ///String field to store the city of the supplier.
        private string _city;
        ///String field to store the phone number of the supplier.
        private string _phoneNo;
        ///String field to store the email address of the supplier.
        private string _email;
        ///Method to accept the details of the supplier.
       public void AcceptDetails()
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
        ///Method to display the details of the supplier.
        public void DisplayDetail()
        {
            Console.WriteLine("\nSupplier Details :");
            Console.WriteLine("Supplier Id : " + _supplierID);
            Console.WriteLine("Supplier Name : " + _supplierName);
            Console.WriteLine("City : " + _city);
            Console.WriteLine("Phone No. : " + _phoneNo);
            Console.WriteLine("Email : " + _email);

        }
    }
}
