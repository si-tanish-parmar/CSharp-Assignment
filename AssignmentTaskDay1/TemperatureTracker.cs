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
            const int minTemperature = 20;
            const int maxTemperature = 130;

            int totalTemperatures = 0;
            int sumTemperatures = 0;

            Console.WriteLine("Enter daily high temperatures (Enter '0' to finish):");

            while (true)
            {
                Console.Write("Enter temperature (20 - 130) or '0' to finish: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int temperature))
                {
                    if (temperature == 0)
                        break;

                    if (temperature >= minTemperature && temperature <= maxTemperature)
                    {
                        sumTemperatures += temperature;
                        totalTemperatures++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid temperature! Temperature must be between 20 and 130.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a valid temperature.");
                }
            }

            if (totalTemperatures > 0)
            {
                double averageTemperature = (double)sumTemperatures / totalTemperatures;
                Console.WriteLine($"Total temperatures entered: {totalTemperatures}");
                Console.WriteLine($"Average temperature: {averageTemperature:F2} Fahrenheit");
            }
            else
            {
                Console.WriteLine("No valid temperatures entered.");
            }
        }
    }
}

