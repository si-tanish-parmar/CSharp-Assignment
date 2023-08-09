using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingApplication
{
    internal class TeamPerformance
    {
        static void Main2(string[] args)
        {
            int won, lost, draw;
            Console.WriteLine("Enter the games won");
            won = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the games lost");
            lost = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the games draw");
            draw = Convert.ToInt32(Console.ReadLine());
            int total = (3*won)+(0*lost)+draw;
            Console.WriteLine(total);


        }
    }
}
