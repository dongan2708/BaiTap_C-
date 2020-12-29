using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example8
{
    class FileDemo
    {
        static void Main(string[] args)
        {
            string path = "C:\\Windows\\MyFile.txt";
            bool found = true;
            if (found)
            {
                Console.WriteLine("File path:\'" + path
                + "\'");
            }
            else
            {
                Console.WriteLine("File Not Found!\a");
            }
        }
    }
}
