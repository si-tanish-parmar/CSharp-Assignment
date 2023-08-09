using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    internal class Order
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public double Calculate()
        {
            double TPrice = Quantity * 19.95;
            return TPrice;
        }
        public void Display()
        {
            Console.WriteLine($"Order ID: {OrderID} Customer Name: {CustomerName} Quantity: {Quantity} Price: {Calculate()}");
        }

        public override bool Equals(object? obj)
        {
            if (obj != null)
            {
                Order other = obj as Order;
                if (this.OrderID == other.OrderID)
                {
                    return true;
                }
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(OrderID);
        }

        public override string ToString()
        {
            return $"Order ID: {OrderID} Customer Name: {CustomerName} Quantity: {Quantity} Price: {Calculate()}";
        }
    }
    
}
