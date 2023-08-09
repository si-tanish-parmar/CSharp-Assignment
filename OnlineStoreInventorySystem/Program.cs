namespace OnlineStoreInventorySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Electronics laptop = new Electronics
            {
                ProductID = "E001",
                Name = "Laptop",
                Price = 800,
                QuantityInStock = 10,
                Brand = "Dell"
            };

            Clothing tShirt = new Clothing
            {
                ProductID = "C001",
                Name = "T-Shirt",
                Price = 20,
                QuantityInStock = 50,
                Size = "Medium"
            };

            Books harryPotter = new Books
            {
                ProductID = "B001",
                Name = "Harry Potter and the Sorcerer's Stone",
                Price = 15,
                QuantityInStock = 20,
                Author = "J.K. Rowling"
            };

            Console.WriteLine("Electronics:");
            laptop.DisplayProductDetails();

            Console.WriteLine("\nClothing:");
            tShirt.DisplayProductDetails();

            Console.WriteLine("\nBooks:");
            harryPotter.DisplayProductDetails();
        }
    
    }
}