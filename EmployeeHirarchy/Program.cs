namespace EmployeeHirarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager
            {
                Name = "John Doe",
                EmployeeID = "M001",
                Salary = 50000
            };

            Developer developer = new Developer
            {
                Name = "Jane Smith",
                EmployeeID = "D001",
                Salary = 60000
            };

            SalesPerson salesPerson = new SalesPerson
            {
                Name = "Mike Johnson",
                EmployeeID = "S001",
                Salary = 45000
            };

            Console.WriteLine("Manager:");
            manager.DisplayEmployeeDetails();

            Console.WriteLine("\nDeveloper:");
            developer.DisplayEmployeeDetails();

            Console.WriteLine("\nSalesPerson:");
            salesPerson.DisplayEmployeeDetails();
        }
    
    }
}