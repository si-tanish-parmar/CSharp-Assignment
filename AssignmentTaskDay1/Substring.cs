using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTaskDay1
{
    internal class Substring
    {
        static void Main4(string[] args)
        {
            Console.Write("Enter the main string: ");
            string mainString = Console.ReadLine();

            Console.Write("Enter the starting index of the substring: ");
            int startIndex = int.Parse(Console.ReadLine());

            Console.Write("Enter the length of the substring: ");
            int length = int.Parse(Console.ReadLine());

            if (startIndex < 0 || startIndex >= mainString.Length || length < 0 || startIndex + length > mainString.Length)
            {
                Console.WriteLine("Invalid starting index or length.");
            }
            else
            {
                string subString = mainString.Substring(startIndex, length);
                Console.WriteLine($"The extracted substring is: {subString}");
            }
        }
    }
}
