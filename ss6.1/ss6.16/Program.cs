using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss6._16
{
    class Employee
    {
        private int empId;
        private int age;
        private string empName;
        private double salary;
        Employee(int id, string name, int age, double sal)
        {
            Console.WriteLine("Contructor for employee called");
            empId = id;
            empName = name;
            age = age;
            salary = sal;
        }
        ~Employee()
        {
            Console.WriteLine("Destructor for Employee called");
        }
        static void Main(string[] args)
        {
            Employee objEmp = new Employee(1, "John", 45, 35000);

        }
    }
}
