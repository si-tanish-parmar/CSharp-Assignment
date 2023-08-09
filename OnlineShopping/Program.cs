namespace OnlineShopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            while (true)
            {
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Display Product List");
                Console.WriteLine("3. Calculate Total Value of Products in Stock");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice (1-4): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddProductToStore(store);
                        break;
                    case "2":
                        store.DisplayProductList();
                        break;
                    case "3":
                        double totalValue = store.CalculateTotalValue();
                        Console.WriteLine($"Total Value of Products in Stock: Rs{totalValue}");
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void AddProductToStore(Store store)
        {
            Console.Write("Enter Product Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Product Price: ");
            double price = Convert.ToDouble(Console.ReadLine());
           

            Console.Write("Enter Quantity in Stock: ");
            int quantityInStock = Convert.ToInt32(Console.ReadLine());
           

            Console.Write("Enter Product Category: ");
            string category = Console.ReadLine();

            store.AddProduct(name, price, quantityInStock, category);

        }
    }
}