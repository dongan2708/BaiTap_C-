﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] classOne = { "allan", "chris", "monica" };
            string[] classTwo = { "katie", "niel", "mark" };
            Console.WriteLine("Student of class I : \t\t Students of class II :");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(classOne[i] + "\t\t\t" + classTwo[i]);

            }
            classTwo = classOne;
            Console.WriteLine("\nStudents of class II after refernecing class I :");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(classTwo[i]);

            }
            Console.WriteLine();
        }
    }
}
