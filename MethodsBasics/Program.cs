namespace MethodsBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculator calculator = new Calculator();
            //Console.WriteLine("Add "+calculator.AddInt(23, 44));
            //Console.WriteLine("Add Double "+calculator.AddDouble(4.2, 9.22));
            //Console.WriteLine("Multiply " + calculator.Multiply(33, 232));
            //Console.WriteLine("Divide " + calculator.Divide(22 , 11));

            //int a = 10; int b = 20;
            //Console.WriteLine($"Before Swapping a {a} b {b}");
            //Swap(ref a, ref b);
            //Console.WriteLine($"After Swapping a {a} b {b}");

            double grossPay;
            double netPay = CalculateSalary(5000,2000,out  grossPay);
            Console.WriteLine($"Net Pay : {netPay} Gross Pay : {grossPay}");


        }

        //static void Swap(ref int a, ref int b)
        //{
        //    Console.WriteLine($"Inside Before Swap a {a} b {b}");
        //    int temp;
        //    temp = a;
        //    a = b;
        //    b = temp;
        //    Console.WriteLine($"Inside After Swap a {a} b {b}");
        //}

        static double CalculateSalary(double bPay, double allowances, out double grossPay)
        {
            grossPay = bPay + allowances;
            double netPay = bPay - (bPay * 0.30);
            return netPay;

        }
    }
}