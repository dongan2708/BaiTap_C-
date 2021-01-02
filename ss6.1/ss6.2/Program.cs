using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss6._2
{
    class Book
    {
        string bookName;
        public string Print()
        {
            return bookName;
        }
        public void input(string bkName)
        {
            bookName = bkName;
        }
        static void Main(string[] args)
        {
            Book objBook = new Book();
            objBook.input("C# - The complete reference");
            Console.WriteLine(objBook.Print());
        }

    }
}
