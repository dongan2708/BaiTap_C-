﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Service = 3;
            double salary = 1500;
            int bonus = 0;
            if (Service < 5)
            {
                if (salary < 5000)
                {
                    bonus = 100;
                }
                else
                {
                    bonus = 200;
                }
            }
            else
            {
                bonus = 700;
            }
            Console.WriteLine("Bonus :" + bonus);
        }
    }
    }

