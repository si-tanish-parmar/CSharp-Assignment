using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTaskDay1
{
    internal class TemperatureTracker
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
    
        int total = 0;
        int count = 0;
        int sentinel = -1; // Sentinel value to end input

        while (true)
        {
            Console.WriteLine("Please enter a daily high temperature (20-130), or enter -1 to finish:");
            int temperature = Convert.ToInt32(Console.ReadLine());

            if (temperature == sentinel)
            {
                if (count == 0)
                {
                    Console.WriteLine("No temperatures entered.");
                }
                else
                {
                    double average = (double)total / count;
                    Console.WriteLine("Number of temperatures entered: {0}", count);
                    Console.WriteLine("Average temperature: {0}", average);
                }
                break; // Exit the loop when the sentinel value is entered
            }
            else if (temperature >= 20 && temperature <= 130)
            {
                total += temperature;
                count++;
            }
            else
            {
                Console.WriteLine("Invalid temperature. Please enter a valid temperature between 20 and 130.");
            }
        }

        Console.ReadLine();
    
        }
    }
}

