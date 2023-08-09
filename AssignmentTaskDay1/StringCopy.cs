using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTaskDay1
{
    internal class StringCopy
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("Enter the number of elements in array:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] source = new int[n];

            Console.WriteLine("Enter the elements of the source array:");

            for (int i = 0; i < n; i++)
            {
                source[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] destination = source.ToArray();

            Console.WriteLine("Elements in new array:");

            for (int i = 0; i < n; i++)
            {
                Console.Write(destination[i] + " ");
            }
        }
    }
}
