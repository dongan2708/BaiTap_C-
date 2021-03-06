﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments

{
    class Medicine
    {
        int MedicneCode;
        string MedicineName;
        string Menufacturer;
        double unitPrice;
        int Qty;
        DateTime ManufacDate;
        DateTime exp;
        int BatchNumber;
        public Medicine(int code, string name, string MenuName, double price, int quantity, DateTime manufacturedDate, DateTime expiryDate, int batch)
        {
            this.MedicneCode = code;
            this.MedicineName = name;
            this.Menufacturer = MenuName;
            this.unitPrice = price;
            this.Qty = quantity;
            this.ManufacDate = manufacturedDate;
            this.exp = expiryDate;
            this.BatchNumber = batch;
        }
        public Medicine()
        {

        }


        public Medicine Accept()
        {
            Console.Write("Medicine code: ");
            MedicneCode = Convert.ToInt32(Console.ReadLine());
            Console.Write("Medicine Name: ");
            MedicineName = Console.ReadLine();
            Console.Write("Manufacturer: ");
            Menufacturer = Console.ReadLine();
            Console.Write("Unit price:");
            unitPrice = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter quantity: ");
            Qty = Convert.ToInt32(Console.ReadLine());
            Console.Write("Manufactured date: ");
            ManufacDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Expiry date: ");
            exp = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Batch Number: ");
            BatchNumber = Convert.ToInt32(Console.ReadLine());
            Medicine objMedicine = new Medicine(MedicneCode, MedicineName, Menufacturer, unitPrice, Qty, ManufacDate, exp, BatchNumber);
            return objMedicine;
        }
        public void Print()
        {
            Console.WriteLine("====Medicine Details====");
            Console.WriteLine("Medicine Name: " + MedicineName);
            Console.WriteLine("Medicine Code: " + MedicneCode);
            Console.Write("Price: " + unitPrice);
            Console.WriteLine("Manufacturer: " + Menufacturer);
            Console.WriteLine("Price: " + unitPrice);
            Console.WriteLine("Manufactured date: " + ManufacDate);
            Console.WriteLine("Expiry date: " + exp);
            Console.WriteLine("Batch number: " + BatchNumber);

        }
        public void Print(int code)
        {
            if (MedicneCode == code)
            {
                Console.WriteLine("Medicine in stock: " + Qty);
            }
            else
            {
                Console.WriteLine("Can not find Medicine code {0}", code);
            }
        }
        public void Print(int code, string MedName)
        {
            if (MedicneCode == code && MedicineName == MedName)
            {
                Console.WriteLine("Manufactured date: " + ManufacDate);
                Console.WriteLine("Expiry date: " + exp);
            }
            else
            {
                Console.WriteLine("Can not find Medicine code {0}", code);
            }

        }
        public void Increase()
        {
            if (Qty == 0)
            {
                Qty = 50;
            }
            else
            {
                Console.WriteLine("Quantity greater than 0");
            }
        }
    }


}