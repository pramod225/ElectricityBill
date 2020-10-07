using System;

namespace Calculatebill
{
    class Program
    {
        static void Main(string[] args)
        {
            ElectricityBill bill = new ElectricityBill();
            bill.GetCustomerDetails();
            bill.ShowAmountDetais();
            Console.Read();
        }
    }
}
