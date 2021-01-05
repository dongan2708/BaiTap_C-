using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Sales
    {
        int medicineCode;
        int sold;
        float planned;
        float actual;
        string region;

        public Sales()
        {
        }
        public Sales(int code, int sold, float planned, float actual, string region)
        {
            code = medicineCode;
            this.sold = sold;
            this.planned = planned;
            this.actual = actual;
            this.region = region;
        }
        public Sales Accept()
        {
            Console.WriteLine("Enter the medicine code:");
            int code = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the sold quantity:");
            int sold = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the planned sales:");
            float planned = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the actual sales:");
            float actual = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the region: ");
            string region = Console.ReadLine();
            Sales obj = new Sales(code, sold, planned, actual, region);
            return obj;
        }
        public void Display()
        {
            Console.WriteLine("Sale details:");
            Console.WriteLine("Medicine code:" + medicineCode);
            Console.WriteLine("Sold quantity: " + sold);
            Console.WriteLine("Planned sales: " + planned);
            Console.WriteLine("Actual sales: " + actual);
            Console.WriteLine("Region: " + region);
        }

        public void Display(int code)
        {
            if (this.medicineCode == code)
            {
                Console.WriteLine("Differ between actual sales and planned sales:{0}", this.actual - this.planned);
            }
            else
            {
                Console.WriteLine("Medicine code {0} - no found", code);
            }

        }
    }
}
