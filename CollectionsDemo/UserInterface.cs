using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    internal class UserInterface
    {
        public int GetId()
        {
            Console.WriteLine("Enter ID");
            int id = int.Parse(Console.ReadLine());
            return id;
        }
        public string GetName()
        {
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            return name;
        }
        public string GetDepartment()
        {
            Console.WriteLine("Enter Department");
            string department = Console.ReadLine();
            return department;
        }
        public double GetSalary()
        {
            Console.WriteLine("Enter Salary");
            double salary = double.Parse(Console.ReadLine());
            return salary;
        }
    }
}
