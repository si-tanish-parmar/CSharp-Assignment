using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTaskDay1
{
    internal class StringCount
    {
        static void Main3(string[] args)
        {
            Console.Write("Enter a line of text: ");
            string line = Console.ReadLine();

            Console.Write("Enter the character to count: ");
            char character = char.Parse(Console.ReadLine());

            int occurrences = 0;
            foreach (char c in line)
            {
                if (c == character)
                    occurrences++;
            }

            Console.WriteLine($"The character '{character}' appears {occurrences} time");
        }
    }
}
