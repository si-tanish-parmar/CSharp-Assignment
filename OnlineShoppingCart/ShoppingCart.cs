using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingCart
{
    internal class ShoppingCart
    {
        private List<Item> items = new List<Item>();

        public void AddItem(string name, double price, int quantity)
        {
            Item item = new Item(name, price, quantity);
            items.Add(item);
        }

        public void DisplayCartContents()
        {
            Console.WriteLine("Shopping Cart Contents:");
            foreach (var item in items)
            {
                Console.WriteLine($"Item: {item.Name}, Price: ${item.Price:F2}, Quantity: {item.Quantity}");
            }
        }

        public double TotalCost
        {
            get
            {
                double totalCost = 0;
                foreach (var item in items)
                {
                    totalCost += item.Price * item.Quantity;
                }
                return totalCost;
            }
        }
    }
}
