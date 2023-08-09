using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtractClass
{
    public interface ICamera
    {
        void ClickImage();
    }
    public interface IMusicSystem
    {
        public  void PlayMusic(string song);
        public void IncreaseVolume(double delta);
        public void DecreaseVolume(double delta);
    }
    class Mobile: ICamera
    {
        public void ClickImage()
        {
            Console.WriteLine("Image CLicked");
        }
    }
    class Computer
    {
        public void Speaker()
        {
            Console.WriteLine("Speaker Present");
        }
    }

    class Laptop : Computer, ICamera, IMusicSystem
    {
        public void ClickImage()
        {
            Console.WriteLine("Image Click for Laptop");
        }

        public void PlayMusic(string song)
        {
            Console.Write($"Playing Music {song}");
        }

        public void IncreaseVolume(double delta)
        {
            Console.WriteLine($"Increase Volume {delta}");
        }

        public void DecreaseVolume(double delta)
        {
            Console.WriteLine($"Decrease Volume {delta}");
        }
    }


}

