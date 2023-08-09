using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingApplication
{
    internal class PaySlip
    {
        static void Main3(string[] args)
        {
            double hours, rate, gross, insurance, tax, net;
            Console.WriteLine("Enter Hours");
            hours = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Rate per Hour");
            rate = Convert.ToDouble(Console.ReadLine());
            gross = hours * rate;
            insurance = ((gross)*5/100);
            tax = ((gross - insurance) * 20 / 100);
            net = gross - (tax+insurance);
            Console.WriteLine("================PaySlip==================");
            Console.WriteLine("=========================================");
            Console.WriteLine("Hours Worked         "+hours);
            Console.WriteLine("Hourly Rate          "+rate);
            Console.WriteLine("Gross Pay            "+ gross);
            Console.WriteLine("National Pay         "+ insurance);
            Console.WriteLine("Income Tax           "+ tax);
            Console.WriteLine("=========================================");
            Console.WriteLine("Nett Pay             "+ net);
            Console.WriteLine("=========================================");









        }
    }
}
