using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBasics
{
    internal class Employee
    {
        int id;
        string name;
        double bPay;
        double salary;
        public string Departmemt { get; set; }

        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double BPay
        {
            get { return bPay; }
            set
            {
                if (value < 1000)
                {
                    bPay = 1000;
                }
                else
                {
                    bPay = value;
                }
            }
        }
        public double Salary
        {
            get { return salary; }

        }

        public void CalculateSalary(double bPay ,double deductions)
        {
            this.salary = bPay - deductions;
        }


    }
}
