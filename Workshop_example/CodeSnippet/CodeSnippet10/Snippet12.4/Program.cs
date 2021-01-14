using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet12._4
{
    public delegate void PrintDetails();
    class TestEvent
    {
        event PrintDetails Print;
        void Show()
        {
            Console.WriteLine("This program illustrate how to sub...");
        }
        static void Main(string[] args)
        {
            TestEvent objTestEven = new TestEvent();
            objTestEven.Print += new PrintDetails(objTestEven.Show);
            Console.WriteLine(objTestEven.Print.Method);
            objTestEven.Print();
        }
    }
}
