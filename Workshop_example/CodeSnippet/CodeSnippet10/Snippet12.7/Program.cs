using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet12._7
{
    class ArrayCollection
    {
        static void Main(string[] args)
        {
            ArrayList objArray = new ArrayList();
            objArray.Add("John");
            objArray.Add("James");
            objArray.Add("peter");
            objArray.RemoveAt(2);
            objArray.Insert(2, "William");
            Console.WriteLine("Capacity : " + objArray.Capacity);
            Console.WriteLine("Count : " + objArray.Count);
            Console.WriteLine("Element of ArrayList");
            foreach (string str in objArray)
            {
                Console.WriteLine(str);
            }
        }
    }
}