using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    internal class EmployeeUtility
    {
        private static List<Employee> employeesList = new List<Employee>()
        {
            new Employee(){Id=1,Name="Tanish",Department="Engg",Salary=300000},
            new Employee(){Id=2,Name="Kartik",Department="HR",Salary=200000},
            new Employee(){Id=3,Name="Tejas",Department="Game",Salary=100000},
            new Employee(){Id=4,Name="Tejal",Department="Engg",Salary=10000},
            new Employee(){Id=5,Name="Sejal",Department="HR",Salary=10000},

        };

        public Employee CreateEmployee(int  id,string name, string department,double salary)
        {
            Employee employee = new Employee() { Id=id, Name = name, Department = department, Salary = salary };

            return employee;

        }

        public bool AddEmployee(Employee emp)
        {
            if (employeesList.Count == 0)
            {
                employeesList.Add(emp);
            }
            else
            {
                foreach(Employee employee in employeesList)
                {
                    if (employee.Equals(emp))
                    {
                        return false;
                    }
                    else
                    {
                        employeesList.Add(emp);
                        break;
                    }
                }
            }
            return true;
        }
        //provide a menu here.1 to add 2 to exit etc
        public void DisplayEmployees()
        {
            Console.WriteLine("Employee Details");
            foreach (Employee emp in employeesList)
            {
               
                Console.WriteLine(emp);
            }
        }
        public Employee FindEmployeeByName(string name)
        {
            foreach (Employee emp in employeesList)
            {
                if (string.Equals(emp.Name, name, StringComparison.OrdinalIgnoreCase))
                {
                    return emp;
                }
            }
            return null;

        }
        public Employee FindEmployeeById(int id)
        {
            return employeesList.Find(emp => emp.Id == id);
        }
        public void SortEmployeesBySalary()
        {
            employeesList = employeesList.OrderByDescending(emp => emp.Salary).ToList();

        }
        public List<Employee> FindEmployeesByDepartment(string department)
        {
            List<Employee> result = new List<Employee>();
            foreach (Employee emp in employeesList)
            {
                if (string.Equals(emp.Department, department, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(emp);
                }
            }
            return result;
        }

        public bool UpdateEmployeeSalary(int id, double newSalary)
        {
            foreach (Employee emp in employeesList)
            {
                if (emp.Id == id)
                {
                    emp.Salary = newSalary;
                    return true;
                }
            }
            return false;
        }





    }
}
