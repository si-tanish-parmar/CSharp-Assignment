using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTaskDay1
{
    internal class OrderString
    {
        static void Main5(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine().ToLower();

            char[] chars = input.ToCharArray();
            Array.Sort(chars);
            string sortedString = new string(chars);

            Console.WriteLine($"The string in alphabetical order is: {sortedString}");
        }
    }
}
