using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss6._14
{
    class Employee
    {
        string empName;
        int empAge;
        string deptName;
        Employee(string name, int num)
        {
            empName = name;
            empAge = num;
            deptName = "Research & Development";
        }
        static void Main(string[] args)
        {
            Employee obj = new Employee("John", 10);
            Console.WriteLine(obj.deptName);
        }
    }
}
