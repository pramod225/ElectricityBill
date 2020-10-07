﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculatebill
{
   public  class ElectricityBill
    {
        int CustomerId,Unit;
        string  CustomerName;
        double Charge,Amount,SurchageAmount,NetAmount;

               
        public void GetCustomerDetails()
        {
            Console.WriteLine("Enter Customer id");
            CustomerId = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Customer's Name");
            CustomerName =Console.ReadLine();
            Console.WriteLine("Enter Unit ");
            Unit = Convert.ToInt16(Console.ReadLine());
        }
        void CalculateAmount()
        {
            if (Unit > 600)
            {
                Charge = 2.00;
               
            }
            else if (Unit > 200 && Unit < 400)
            {
                Charge = 1.50;
            }
            else if (Unit > 400 && Unit < 600)
            {
                Charge = 1.80;
            }
            else
            {
                Charge = 1.20;
            }
        }
        void CalculateBill()
        {
            Amount = (Charge * Unit);
            SurchageAmount = (Amount * 15) / 100;
            NetAmount = Amount + SurchageAmount;
        }
           public  void ShowAmountDetais()
            {
                CalculateAmount();
                CalculateBill();
                Console.WriteLine("Customer's Id:{0}",CustomerId);
                Console.WriteLine("Customer's Name:{0}", CustomerName);
                Console.WriteLine("Cusumed Unit of Electricity :{0}", Unit);
                Console.WriteLine("Amount charges @Rs.{0} per Unit{1}:",Charge,Amount );
                Console.WriteLine("Surchage Amount:{0}",SurchageAmount);
                Console.WriteLine("Net Amount Paid By the Customer:{0}", NetAmount);
            }
        
        }
           

    }
    

