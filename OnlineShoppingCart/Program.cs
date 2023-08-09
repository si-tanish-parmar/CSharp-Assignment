namespace OnlineShoppingCart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();

            while (true)
            {
                Console.WriteLine("1. Add Item to Cart");
                Console.WriteLine("2. Display Cart Contents");
                Console.WriteLine("3. Calculate Total Cost");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice (1-4): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddItemToCart(cart);
                        break;
                    case "2":
                        cart.DisplayCartContents();
                        break;
                    case "3":
                        double totalCost = cart.TotalCost;
                        Console.WriteLine($"Total Cost of the Cart: Rs{totalCost}");
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option (1-4).");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void AddItemToCart(ShoppingCart cart)
        {
            Console.Write("Enter Item Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Item Price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Item Quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
           

            cart.AddItem(name, price, quantity);

            Console.WriteLine("Item added to the cart!");
        }
    }
}