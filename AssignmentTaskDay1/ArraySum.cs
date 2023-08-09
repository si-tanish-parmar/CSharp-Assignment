using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTaskDay1
{
    internal class ArraySum
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Enter the number of elements in array:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter the elements:");

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = arr.Sum();

            Console.WriteLine("Sum of all elements in the array: " + sum);
        }
    }
}
