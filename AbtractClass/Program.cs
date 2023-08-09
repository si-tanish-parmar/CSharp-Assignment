namespace AbtractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Animal a1 = new Dog("Dog");
            //Animal a2 = new Cat("Cat");
            //Animal a3 = new Cow("Cow");
            //a1.Display();
            //a2.Display();
            //a3.Display();

            Laptop l1 = new Laptop();
            l1.PlayMusic("Despacito");
            l1.Speaker();
            l1.IncreaseVolume(89.0);
            l1.DecreaseVolume(9.0);
            l1.ClickImage();
        }
    }
}