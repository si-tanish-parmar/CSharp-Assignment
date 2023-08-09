using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping
{
    internal class Product
    {
        public string Name { get; }
        public double Price { get; }
        public int QuantityInStock { get; }
        public string Category { get; }

        public Product(string name, double price, int quantityInStock, string category)
        {
            Name = name;
            Price = price;
            QuantityInStock = quantityInStock;
            Category = category;
        }
    }
}
