using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class PurchaseOrderTest
    {
        static void Main(string[] args)
        {
            PurchaseOrder objPurchaseOrder;
        AccpetOrder:
            char choice = 'N';
            try
            {
                objPurchaseOrder = new PurchaseOrder();
                if (objPurchaseOrder.AcceptOrderDetails())
                {
                    if (objPurchaseOrder.AcceptOrderDetails())
                    {
                        objPurchaseOrder.CalculateAmount();
                        objPurchaseOrder.DisplayOrderDetails();
                        objPurchaseOrder.DisplayProductDetails();
                    }
                }
            }
            catch(Exception objEx)
            {
                Console.WriteLine("Error : {0}", objEx.Message);
            }
            finally
            {
                try
                {
                    objPurchaseOrder = null;
                    Console.WriteLine("\nDo you want to add details for another purchase order [Y/N]?");
                    choice = Convert.ToChar(Console.ReadLine());
                }
                catch(Exception objEx)
                {
                    Console.WriteLine("Error : {0}", objEx.Message);
                }
            }
            if (choice == 'Y' || choice == 'Y')
                goto AccpetOrder;
        }
    }
}
 