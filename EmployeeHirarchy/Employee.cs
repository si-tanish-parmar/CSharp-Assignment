using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeHirarchy
{
    abstract class Employee
    {
        public string Name { get; set; }
        public string EmployeeID { get; set; }
        public double Salary { get; set; }

        public abstract double CalculateBonus();

        public virtual void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Employee ID: {EmployeeID}");
            Console.WriteLine($"Salary: Rs{Salary}");
        }

    }

    class Manager : Employee
    {
        public override double CalculateBonus()
        {
            
            return Salary * 0.15;
        }

        public override void DisplayEmployeeDetails()
        {
            base.DisplayEmployeeDetails();
            Console.WriteLine($"Bonus: Rs{CalculateBonus():F2}");
        }
    }
    class Developer : Employee
    {
        public override double CalculateBonus()
        {
            // Developers get a bonus of 10% of their salary
            return Salary * 0.10;
        }

        public override void DisplayEmployeeDetails()
        {
            base.DisplayEmployeeDetails();
            Console.WriteLine($"Bonus: Rs{CalculateBonus():F2}");
        }
    }
    class SalesPerson : Employee
    {
        public override double CalculateBonus()
        {
            
            return Salary * 0.05;
        }

        public override void DisplayEmployeeDetails()
        {
            base.DisplayEmployeeDetails();
            Console.WriteLine($"Bonus: Rs{CalculateBonus():F2}");
        }
    }

}
