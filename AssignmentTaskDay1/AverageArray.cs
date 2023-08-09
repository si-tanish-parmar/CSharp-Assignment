using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTaskDay1
{
    internal class AverageArray
    {
        public static void Main7(string[] args)

        {

            int sum = 0, hgst = 0;

            double avg;




            int[] arr1 = new int[10];



            for (int i = 0; i < 10; i++)

            {

                Console.WriteLine($"Enter marks of Student {i + 1}:");

                arr1[i] = Convert.ToInt32(Console.ReadLine());

                sum += arr1[i];




                if (arr1[i] > hgst)

                {

                    hgst = arr1[i];

                }


            }

            avg = (double)sum / 10;

            Console.WriteLine($"Average marks of 10 students is {avg}");


            Console.WriteLine($"Highest marks of 10 students is {hgst}");



        }
    }
}
