using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSippet3
{
    class AliasExample
    {
        static void Main(string[] args)
        {
            Emp.Employees obj = new Emp.Employees();
            obj.Name = "Peter";
            IO.WriteLine("Employee Name : " + obj.Name);
        }
    }