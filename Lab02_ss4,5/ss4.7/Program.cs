using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "dd/MM/yyyy";
            Console.WriteLine("Enter date of birth (dd/mm/yyyy) : ");
            DateTime DoB = DateTime.ParseExact(Console.ReadLine(), pattern, null);
            int age = (DateTime.Today.Subtract(DoB).Days) / 365;
            Console.WriteLine(age);
        }
    }
}
