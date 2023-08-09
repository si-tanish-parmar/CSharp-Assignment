using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtractClass
{
    abstract internal class Animal
    {
        public string Name { get; set; }
        public Animal(String name)
        {
            Name = name;
        }
        abstract public string Speak();

        public void Display()
        {
            Console.WriteLine($"{Name}  says {Speak()}");
        }
    }

    class Dog : Animal
    {
        public Dog(string name):base(name)
        {
           
        }
        public override string Speak()
        {
            return "Bow Bow";
        }
    }
    class Cat : Animal
    {
        public Cat(string name) : base(name)
        {

        }
        public override string Speak()
        {
            return "Meow Meow";
        }
    }
    class Cow : Animal
    {
        public Cow(string name) : base(name)
        {

        }
        public override string Speak()
        {
            return "Moo Moo";
        }
    }
}
