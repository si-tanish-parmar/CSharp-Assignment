using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBasics
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }    

        public string Department { get; set; }
        public double CollegeFees { get; set; }

        public void Display()
        {
            Console.WriteLine($"ID: {Id} Name: {Name} Department: {Department}");
        }
        public Student()
        {

        }

        public Student(int Id,string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
        public override bool Equals(object? obj)
        {
            if (obj != null)
            {
                Student other = obj as Student;//this is casted into Employee object
                if (this.Id == other.Id)
                {
                    return true;
                }
            }
            return false;

        }
    }
    class DayScholar : Student
    {
        public DayScholar()
        {
            Console.WriteLine("From DayScholar");
        }
        public DayScholar(int Id, string Name):base(Id,Name)
        {
            Console.WriteLine("From Parent");
            this.Id = Id;
            this.Name = Name;
        }
        public int BusRouteNo { get; set; }
        public void Display()
        {

            base.Display();
            Console.WriteLine($" Bus Route No: {BusRouteNo} College Fees: {Calculate()}");

        }
        public double Calculate()
        {
            CollegeFees = CollegeFees + 10000;
            return CollegeFees;
        }


    }
    class Hostellier : Student
    {
        public Hostellier() { Console.WriteLine("From Hostellier"); }
        public Hostellier(int Id, string Name) : base(Id, Name)

        {
            Console.WriteLine("From Parent");
            this.Id = Id;
            this.Name = Name;
        }
        public double HostelFee { get; set; }
        public new void Display()

        {
            base.Display();
            Console.WriteLine($" Hostel Fee: {HostelFee} College Fees: {Calculate()}");
        }
        public double Calculate()
        {
            CollegeFees = CollegeFees + 10000;
            return CollegeFees;
        }
    }


}
