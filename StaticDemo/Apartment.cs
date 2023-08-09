using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    internal class Apartment
    {
        public static string Name { get;set;}
        public  int AppartmentNo{get;set;}
        public  string OwnerName { get;set;}
        public static int NoOfHouseBought { get;set;}
        public static string Address { get;set;}
        public Apartment(int appartmentNo, string ownerName) {
            AppartmentNo = appartmentNo;
            OwnerName = ownerName;
            ++NoOfHouseBought;
        }
        public void Display()
        {
            Console.WriteLine($"Apartment No : {AppartmentNo} Owner Name: {OwnerName}");
        }
        public static void DisplayAddress()
        {
            Console.WriteLine($"Apartment Address: {Address}");
        }

        public static void DisplayHouses()
        { 
            Console.WriteLine($"No of Houses bought : {NoOfHouseBought}");
        }
    }
}
