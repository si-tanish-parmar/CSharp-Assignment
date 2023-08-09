using System.IO.Pipes;

namespace OnlineShoppingApplication
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            double item1,item2,item3;
            Console.WriteLine("Enter price for Item 1");
            item1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter price for Item 2");
            item2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter price for Item 3");
            item3 = Convert.ToDouble(Console.ReadLine());
            double total = ((double)item1 + (double)item2 + (double)item3);
            double ans = total * 5 / 100 + total;
            Console.WriteLine(ans.ToString());




        }
    }
}