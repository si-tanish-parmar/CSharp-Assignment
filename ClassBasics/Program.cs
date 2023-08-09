namespace ClassBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
            //Car car1 = new Car("Audi", "Black", 230);
            //Car car2 = new Car();
            //Car car3 = new Car("Mercedes","Green");
            //Car car4 = new Car();
            //car4.CarName = "Masserati";
            //car4.Speed = 100;
            //car4.Color = "White";
            //car4.Display();
            //car1.Display();
            //car2.Display();
            //car3.SpeedUp(230);
            //car3.Display();
            //car3.Speed = 3;
            //car3.Display();
            Employee employee = new Employee();
            employee.Name = "Tan";
            //employee.Salary = 10000;
            employee.BPay = 70000;
            employee.CalculateSalary(employee.BPay,500);    
            Console.WriteLine($"{employee.Name} has salary of {employee.Salary} dollars");
         
            
        }
    }
}