using System.Xml.Serialization;

namespace InheritanceBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int choice;
            //do
            //{
            //    Console.WriteLine("Enter the choice (1 for DayScholar, 2 for Hostellier, 0 to exit)");
            //    choice = Convert.ToInt32(Console.ReadLine());

            //    switch (choice)
            //    {
            //        case 1:
            //            Console.WriteLine("For DayScholer");
            //            DayScholar d1 = new DayScholar();
            //            d1.Id = 1;
            //            d1.Name = "Tanish";
            //            d1.Department = "Engg";
            //            d1.BusRouteNo = 23;
            //            d1.CollegeFees = 2000;
            //            d1.Display();
            //            d1.Calculate();
            //            break;

            //        case 2:
            //            Console.WriteLine("For Hostellier");
            //            Hostellier h1 = new Hostellier();
            //            h1.Id = 2;
            //            h1.Name = "Kartikay";
            //            h1.Department = "Physics";
            //            h1.HostelFee = 2300;
            //            h1.CollegeFees = 3000;
            //            h1.Display();
            //            break;

            //        case 0:
            //            Console.WriteLine("Exiting the program...");
            //            break;

            //        default:
            //            Console.WriteLine("Invalid choice. Please try again.");
            //            break;
            //    }
            //} while (choice != 0);

            //Employee e1 = new Employee(22,"A");
            //Employee e2 = new Employee(23,"B");
            //Employee e3 = new Employee(22,"B");
            //Console.WriteLine(e1.Equals(e2));
            //Console.WriteLine(e3.Equals(e2));
            //Console.WriteLine(e1);
            //Console.WriteLine(e2);
            //Console.WriteLine(e3);
            //Console.WriteLine(e1.GetHashCode);
            //string s1 = new string("HI");
            //string s2 = new string("HI");
            //string s3 = s2;
            //Console.WriteLine(s1.Equals(s2));
            //Console.WriteLine(s2.Equals(s3));


            //Student s1 = new Student(11,"Tan");
            //Student s2 = new Student(11,"Kar");
            //Console.WriteLine(s1.Equals(s2));
            Student student = new DayScholar(122,"Tani");
            Student student3 = new DayScholar();


            Student student2 = new Hostellier(34,"Yo");
            Student student4 = new Hostellier();


        }
    }
}
        