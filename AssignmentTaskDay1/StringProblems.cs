using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTaskDay1
{
    internal class StringProblems
    {


        class Program
        {
            static void Main3()
            {
                Console.WriteLine("1. Count the number of occurrences of a particular character in a line of text");
                Console.WriteLine("2. Rewrite a string in alphabetical order");
                Console.WriteLine("3. Extract a substring from a given string");
                Console.WriteLine("4. Search the position of a substring within a string");
                Console.WriteLine("5. Compare two substrings that differ only in case");

                Console.Write("Enter your choice (1-5): ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CountOccurrences();
                        break;
                    case 2:
                        RewriteAlphabeticalOrder();
                        break;
                    case 3:
                        ExtractSubstring();
                        break;
                    case 4:
                        SearchSubstringPosition();
                        break;
                    case 5:
                        CompareSubstrings();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option (1-5).");
                        break;
                }
            }

            static void CountOccurrences()
            {
                Console.Write("Enter a line of text: ");
                string input = Console.ReadLine();

                Console.Write("Enter the character to count: ");
                char characterToCount = char.Parse(Console.ReadLine());

                int count = input.Count(c => c == characterToCount);
                Console.WriteLine($"Number of occurrences of '{characterToCount}' in the text: {count}");
            }

            static void RewriteAlphabeticalOrder()
            {
                Console.Write("Enter a string: ");
                string input = Console.ReadLine();

                char[] charArray = input.ToCharArray();
                Array.Sort(charArray);

                string result = new string(charArray);
                Console.WriteLine($"Alphabetical order: {result}");
            }

            static void ExtractSubstring()
            {
                Console.Write("Enter a string: ");
                string input = Console.ReadLine();

                Console.Write("Enter the starting index: ");
                int startIndex = int.Parse(Console.ReadLine());

                Console.Write("Enter the length of the substring: ");
                int length = int.Parse(Console.ReadLine());

                string subString = input.Substring(startIndex, length);
                Console.WriteLine($"Extracted substring: {subString}");
            }

            static void SearchSubstringPosition()
            {
                Console.Write("Enter a string: ");
                string input = Console.ReadLine();

                Console.Write("Enter the substring to search: ");
                string substring = Console.ReadLine();

                int position = input.IndexOf(substring);
                if (position != -1)
                {
                    Console.WriteLine($"Substring found at position: {position}");
                }
                else
                {
                    Console.WriteLine("Substring not found in the string.");
                }
            }

            static void CompareSubstrings()
            {
                Console.Write("Enter the first string: ");
                string str1 = Console.ReadLine();

                Console.Write("Enter the second string: ");
                string str2 = Console.ReadLine();

                bool ignoreCaseComparison = string.Equals(str1, str2, StringComparison.OrdinalIgnoreCase);
                bool caseSensitiveComparison = string.Equals(str1, str2);

                Console.WriteLine($"Ignoring case: {ignoreCaseComparison}");
                Console.WriteLine($"Considering case: {caseSensitiveComparison}");
            }
        }

    }
}


