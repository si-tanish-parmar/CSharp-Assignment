using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AssignmentTaskDay1
{
    internal class DeleteArray
    {
        static void Main6(string[] args)
        {
            Console.WriteLine("Enter number of elements:");
            int num = Convert.ToInt32(Console.ReadLine());

            int[] arr1 = new int[num];
            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < num; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter the index of the array element to delete: ");
            int del = Convert.ToInt32(Console.ReadLine());

            if (del < 0 || del >= num)
            {
                Console.WriteLine("Invalid index. Please enter a valid index.");
            }
            else
            {
                int[] arr2 = new int[num - 1];

                for (int i = 0, j = 0; i < num; i++)
                {
                    if (i != del)
                    {
                        arr2[j++] = arr1[i];
                    }
                }

                Console.WriteLine("Array after deletion:");
                for (int i = 0; i < arr2.Length; i++)
                {
                    Console.WriteLine(arr2[i]);
                }
            }
        }
    }
}

