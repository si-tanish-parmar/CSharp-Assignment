using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreInventorySystem
{
    internal class Product
    {
        public string ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int QuantityInStock { get; set; }

        public void DisplayProductDetails()
        {
            Console.WriteLine($"Product ID: {ProductID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: Rs{Price}");
            Console.WriteLine($"Quantity in Stock: {QuantityInStock}");
        }
    }

    class Electronics : Product
    {
        public string Brand { get; set; }

        public new void DisplayProductDetails()
        {
            base.DisplayProductDetails();
            Console.WriteLine($"Brand: {Brand}");
        }
    }
    class Clothing : Product
    {
        public string Size { get; set; }

        public new void DisplayProductDetails()
        {
            base.DisplayProductDetails();
            Console.WriteLine($"Size: {Size}");
        }
    }
    class Books : Product
    {
        public string Author { get; set; }

        public new void DisplayProductDetails()
        {
            base.DisplayProductDetails();
            Console.WriteLine($"Author: {Author}");
        }
    }

}
