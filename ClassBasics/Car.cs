using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ClassBasics
{
    internal class Car
    {
        public string carName;
        public string color;
        public int speed;


        public string CarName
        {
            get { return carName; }
            set { carName = value; }
        }

        public int Speed
        {
            get { return speed; }
            set {if(value >= 5) { speed = value; } 
            else { speed = 5; }
            }

        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }




        public Car(string carName, string color, int speed)
        {
            this.carName =carName;
            this.color = color;
            this.speed = speed;
        }

        public Car()
        {
            carName = "Lambo";
            color = "Red";
            speed = 300;
        }

        public Car(string carName, string color)
        {
            this.carName=carName;
            this.color = color;
        }

        public void SpeedUp(int delta)
        {
            speed += delta;
        }

        public void Display()
        {
           WriteLine($"{carName} of {color} is running at speed of {speed} km/hr");
        }


    }
}
