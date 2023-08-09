namespace BasicsContinued
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Display(marks: 34.5);

            Calculate("Tanish", 100);
            Calculate("Kartikay", 100,100,1000);
            Calculate("Tejas", 100,11,66,8889,99);
        }
        //public static void Display(double marks, string name = "Parmar", string fname="tan")
        //{
        //    Console.WriteLine($"Name: {name}  Marks:{marks} fname:{fname}");
        //}

        public static void Calculate(string name,params double[] pricelist) {
            double total = 0;
            for(int i = 0; i < pricelist.Length; i++) { total += pricelist[i]; }
            Console.WriteLine($"Bill of {name} Total Bill {total}");
        }
    }
}