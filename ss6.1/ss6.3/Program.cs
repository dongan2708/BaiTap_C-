using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss6._3
{
    class Student
    {
        void printName(String firstName, string lastName)
        {
            Console.WriteLine("First Name = {0} , Last Name = {1} ", firstName, lastName);
        }
        static void Main(string[] args)
        {
            Student objStudent = new Student();
            objStudent.printName("Henry", "Parker");

        }
    }
}
