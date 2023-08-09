using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} Id: {Id} Salary: {Salary} Department: {Department}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                Employee otherEmployee = obj as Employee;
                if(this.Id == otherEmployee.Id)
                {
                    return true ;
                }
            }
            return false;
        }

    }
}
