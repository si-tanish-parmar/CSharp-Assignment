namespace StaticDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apartment.Address = "56 Shubhh Laabh Row House";
            Apartment.DisplayAddress();
            Apartment.DisplayHouses();

            Apartment apartment1 = new Apartment(1,"Tanish");
            Apartment apartment2 = new Apartment(3, "Ashwin");
            Apartment apartment3 = new Apartment(2, "Rekha");
            apartment1.Display();
            apartment2.Display();
            apartment3.Display();
            //apartment1.DisplayHouses();


        }
    }
}