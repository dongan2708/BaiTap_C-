using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet12._8
{
    class Employee : DictionaryBase
    {
        public void Add(int id, string name)
        {
            Dictionary.Add(id, name);
        }
        public void OnRemoved(int id)
        {
            Dictionary.Remove(id);
        }
        static void Main(string[] args)
        {
            Employee objEmployee = new Employee();
            objEmployee.Add(101, "a");
            objEmployee.Add(102, "b");
            objEmployee.OnRemoved(101);
        }
    }
}
