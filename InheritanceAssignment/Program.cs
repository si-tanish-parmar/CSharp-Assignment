namespace InheritanceAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            order.OrderID = 1;
            order.CustomerName = "Tanish";
            order.Quantity = 20;
            //order.Calculate();
            order.Display();
            Order order1 = new Order();
            order1.OrderID = 1;
            order1.CustomerName = "Tanish";
            order1.Quantity = 25;
            //order.Calculate();
            order1.Display();
            Order order2 = new Order();
            order2.OrderID = 2;
            order2.CustomerName = "Parmar";
            order2.Quantity = 29;
            //order.Calculate();
            order1.Display();
            order2.Display();
            Console.WriteLine(order.Equals(order1));
            Console.WriteLine(order.Equals(order2));

            Console.WriteLine(order.GetHashCode());
            Console.WriteLine(order.ToString());
        }
    }
}