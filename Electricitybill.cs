using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatebill
{
    class Electricitybill
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
