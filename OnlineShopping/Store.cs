using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping
{
    internal class Store
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(string name, double price, int quantityInStock, string category)
        {
            Product product = new Product(name, price, quantityInStock, category);
            products.Add(product);
        }

        public void DisplayProductList()
        {
            Console.WriteLine("Product List:");
            foreach (var product in products)
            {
                Console.WriteLine($"Name: {product.Name}, Price: ${product.Price:F2}, Quantity in Stock: {product.QuantityInStock}, Category: {product.Category}");
            }
        }

        public double CalculateTotalValue()
        {
            double totalValue = 0;
            foreach (var product in products)
            {
                totalValue += product.Price * product.QuantityInStock;
            }
            return totalValue;
        }
    }
}
