using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss4._17
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] employeeNames = { "Maria", "Wilson", "Elton", "Garry" };
            Console.WriteLine("EmployeeNames");
            foreach (string names in employeeNames)
            {
                Console.WriteLine("{0}", names);
            }
        }
    }
}
