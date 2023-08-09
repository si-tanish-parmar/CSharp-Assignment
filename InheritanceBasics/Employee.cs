using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBasics
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Ename{ get; set; }
        

        public Employee(int id,string name)
        {
            Ename = name;
            Id = id;
        }
        public override string ToString()
        {
            return $"Id : {Id} Name: {Ename}";
        }
        //public override bool Equals(object? obj)
        //{
        //    if (obj != null)
        //    {
        //        Employee other = obj as Employee;//this is casted into Employee object
        //        if (this.Id == other.Id && this.Ename.Equals(other.Ename))
        //        {
        //            return true;
        //        }
        //    }


        //    return false;

        //}

        public override int GetHashCode()
        {
            return HashCode.Combine(Id,Ename);
        }
    }
}
