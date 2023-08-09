using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTaskDay1
{
    internal class CheckCredit
    {
        static void Main8(string[] args)
        {
            const int creditLimit = 10000;

            Console.Write("Enter the purchase price: ");
            string input = Console.ReadLine();

          
                if (purchasePrice > creditLimit)
                {
                    Console.WriteLine("Error: Purchase price exceeds the credit limit.");
                }
                else
                {
                    Console.WriteLine("Approved.");
                }
          
        }
    }
}
