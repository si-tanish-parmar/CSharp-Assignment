using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    internal class VehlcieRegistration
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Enter the number of Vehicle Registration numbers");
            int num = Convert.ToInt32(Console.ReadLine());
            int[]  vehicle = new int[num];
            for (int i = 0; i < vehicle.Length; i++)
            {
                Console.WriteLine($"Enter the vehicle number {i+1} ");
                vehicle[i]= Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("The vehicle numbers are");
            for(int i = 0;i < vehicle.Length; i++)
            {
                Console.WriteLine(vehicle[i]);
            }
        }
    }
}
