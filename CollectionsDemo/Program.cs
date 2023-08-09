using System.Collections;
namespace CollectionsDemo

{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeUtility utility = new EmployeeUtility();
            char toContinue = 'Y';
            do
            {
                DisplayMenu();
                Console.WriteLine("Enter a number to select an option:");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        UserInterface ui = new UserInterface();
                        int id = ui.GetId();
                        string name = ui.GetName();
                        string depart = ui.GetDepartment();
                        double salary = ui.GetSalary();
                        Employee emp = utility.CreateEmployee(id, name, depart, salary);
                        bool isAdded = utility.AddEmployee(emp);
                        if (isAdded)
                        {
                            Console.WriteLine("Employee Added");
                        }
                        else
                        {
                            Console.WriteLine("Employee not Added");
                        }
                        break;

                    case 2:
                        utility.DisplayEmployees();
                        break;

                    case 3:
                        Console.WriteLine("Enter the name");
                        string findByName = Console.ReadLine();
                        Employee employeeByName = utility.FindEmployeeByName(findByName);
                        if (employeeByName != null)
                        {
                            Console.WriteLine($"ID: {employeeByName.Id} Name: {employeeByName.Name} Salary: {employeeByName.Salary} Department: {employeeByName.Department}");
                        }
                        else
                        {
                            Console.WriteLine("Employee not found");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Enter the Id");
                        int findById = int.Parse(Console.ReadLine());
                        Employee employeeById = utility.FindEmployeeById(findById);
                        if (employeeById != null)
                        {
                            Console.WriteLine($"ID: {employeeById.Id} Name: {employeeById.Name} Salary: {employeeById.Salary} Department: {employeeById.Department}");
                        }
                        else
                        {
                            Console.WriteLine("Employee not found");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Enter the ID");
                        int updateId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the new salary");
                        double newSalary = double.Parse(Console.ReadLine());
                        bool isUpdated = utility.UpdateEmployeeSalary(updateId, newSalary);
                        if (isUpdated)
                        {
                            Console.WriteLine("Salary updated successfully!!");
                        }
                        else
                        {
                            Console.WriteLine("Employee not found");
                        }
                        break;

                    case 6:
                        utility.SortEmployeesBySalary();
                        utility.DisplayEmployees();
                        break;

                    case 7:
                        Console.WriteLine("Enter the department");
                        string findDepartment = Console.ReadLine();
                        var employeesByDepartment = utility.FindEmployeesByDepartment(findDepartment);
                        if (employeesByDepartment.Count > 0)
                        {
                            Console.WriteLine($"Department: {findDepartment}");
                            foreach (var employee in employeesByDepartment)
                            {
                                Console.WriteLine($"ID {employee.Id} Name: {employee.Name} Salary: {employee.Salary} Department: {employee.Department}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Employee not found");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

                Console.WriteLine("Do you want to continue? (Y/N)");
                string toContinueStr = Console.ReadLine();
                toContinue = char.ToUpper(toContinueStr[0]);
            } while (toContinue == 'Y' || toContinue == 'y');



            static void DisplayMenu()
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.Add Employee");
                Console.WriteLine("2.Display Employee Details");
                Console.WriteLine("3. Find Employee by Name");
                Console.WriteLine("4. Find Employee by Id");
                Console.WriteLine("5. Update Employee Salary");
                Console.WriteLine("6. Sort Employees by Salary");
                Console.WriteLine("7. Find all employees for a given department");
            }
        }
    }

    //class Emp
    //{

    //}

    //List<int> list = new List<int>();
    //list.Add(1);
    //list.Add(2);
    //list.Add(3);


    //ArrayList arrayList = new ArrayList();
    //arrayList.Add("Alice");
    //arrayList.Add(223.4);
    //arrayList.Add(new Emp());
    //arrayList.Add(new Emp());
    //arrayList.Add(new int[45]);

    //foreach (object obj in list)
    //{
    //    Console.WriteLine(obj);
    //}

    //List<string> list2 = new List<string>();
    //list2.Add("a");
    //list2.Add("b");
    //list2.Add("c");

    //foreach (object obj in list2)
    //{
    //    Console.WriteLine(obj);
    //}

    //List<double> list3 = new List<double>() { 34.54, 345.44, 11.5 };
    //Console.WriteLine("Remove   " + list3.Remove(34.54));
    //Console.WriteLine("Contains     " + list3.Contains(34.54));
    //Console.WriteLine("Index of     " + list3.IndexOf(345.44));
    //Console.WriteLine("Count        " + list3.Count);
    //Console.WriteLine("Capacity     " + list3.Capacity);
    //Console.WriteLine(list3[0]);
    //list3[0] = 990.0;
    //Console.WriteLine(list3[1]);

    //list3.Add(343.345);
    //list3.Add(23.3);
    //list3.Add(56.1);

    //foreach (object obj in list3)
    //{
    //    Console.WriteLine(obj);
    //}

    //List<string> fruit = new List<string>() { "Apple", "Orange","Watermelon","Muskmelon" };
    //Console.WriteLine("Enter the fruit name");
    //string name = Console.ReadLine();
    //var result = fruit.Find(x => x.Equals(name));
    //Console.WriteLine("Result :" + result);

    //fruit.RemoveAll(elem => elem.Equals("Apple"));
    //foreach(string f  in fruit) { 
    //    Console.WriteLine(f);
    //}
}