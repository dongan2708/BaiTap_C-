using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class Cuctomer
    {
        private short _customerID;
        private string _customerName;
        private byte _age;
        private char _gender;
        private string _city;

        public bool AcceptDetails()
        {
            string input;
            Console.WriteLine("Enter Customer Details:");
        CustomerID:
            try
            {
                try
                {
                    Console.Write("Customer ID : ");
                    _customerID = Convert.ToInt16(Console.ReadLine());
                    if (_customerID <= 0)
                    {
                        Console.WriteLine("Customer ID must be greater than zero.\n");
                        goto CustomerID;
                    }
                }
                catch (OverflowException objEx)
                {
                    Console.WriteLine("OverflowException : Customer ID is too large!");
                    Console.WriteLine("Error : {0}\n", objEx.Message);
                    goto CustomerID;

                }
            CustomerName:
                Console.Write("Customer Name : ");
                _customerName = Console.ReadLine();
                if (_customerName == "")
                {
                    Console.WriteLine("Invalid customer name!\n");
                    goto CustomerName;
                }
            Age:
                try
                {
                    Console.Write("Age : ");
                    _age = Convert.ToByte(Console.ReadLine());
                    if (_age <= 0)
                    {
                        Console.WriteLine("Age cannot be negative or zero.\n");
                        goto Age;
                    }
                }
                catch (OverflowException objEx)
                {
                    Console.WriteLine("Error : {0}\n", objEx.Message);
                    goto Age;
                }
            Gender:
                Console.Write("Enter the gender [M/F] : ");
                input = Console.ReadLine();
                if (input == "Male" || input == "male" || input == "M" || input == "m")
                {
                    _gender = 'M';
                }
                else if (input == "Female" || input == "female" || input == "F" || input == "f")
                {
                    _gender = 'F';
                }
                else
                {
                    Console.WriteLine("Invalid input!\n");
                    goto Gender;
                }
            City:
                Console.Write("City : ");
                _city = Console.ReadLine();
                if (_city == "")
                {
                    Console.WriteLine("Invalis city name!\n");
                    goto City;
                }
            }
            catch (FormatException objEx)
            {
                Console.WriteLine("Error : {0}\n", objEx.Message);
                goto CustomerID;
            }
            catch (Exception objEx)
            {
                Console.WriteLine("Error : {0}\n", objEx.Message);
                return false;
            }
            return true;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("\nCustomer Details : ");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Customer ID : {0} ", _customerID);
            Console.WriteLine("Customer Name :{0} ", _customerName);
            Console.WriteLine("Age : {0} ", _age);
            if (_gender == 'M' || _gender == 'm')
                Console.WriteLine("Gender : Male");
            else
                Console.WriteLine("Gender : Female");
            Console.WriteLine("City :{0}", _city);

        }
    }
}
