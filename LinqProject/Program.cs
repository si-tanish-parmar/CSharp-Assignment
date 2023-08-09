namespace LinqProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Linq1();
            Linq6();
        }

        public static void Linq1()
        {
            int[] numbers = new int[] { 2, 5, 546, 67, 7, 3, 45 };
            var result = from num in numbers where num%2==1 orderby num select num;
            foreach ( var item in result ) {
                Console.Write( item +"\t");
            }
            Console.WriteLine();

        }

        public static void Linq2()
        {
            int[] numbers = new int[] { 2, 3, 43, 3, 563, 4, 8, 6, 3, 1, 5, 35, 745, 100, 643 };
            //var result = from num in numbers where num > 30  orderby num select num;
            var result = numbers.Where(x=>x <30).OrderBy(x=>x).Distinct().ToList();
            foreach ( var item in result )
            {
                Console.Write( item +"\t");
            }
            Console.WriteLine();
        }
        public static void Linq3()
        {
            int[] numbers = new int[] { 45, 34, 545, 645, 2, 42, 9, 89, 63 };
            var result = numbers.Where(num =>num >30).OrderBy(x=>-char.MinValue).Distinct().ToList();
        }

        public static void Linq4()
        {
            var numbers = from num in Enumerable.Range(100, 50) select new { Number = num, OddEven = num % 2 == 0 ? "Even" : "Odd" };
            foreach( var item in numbers )
            {
                Console.WriteLine( item +"\t");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static void Linq5() {
            string[] fruits = { "Cherry", "Apple", "Mango","Watermelon","Muskmelon" };
            var result = fruits.OrderBy(x => x.Length);
            foreach ( var item in result )
            {
                Console.WriteLine( item +"\t");
                Console.WriteLine();
            }
        }
        public static void Linq6()
        {
            string[] fruits = { "Cherry", "Apple", "Mango", "Watermelon", "Muskmelon" };
            var result = (from f in fruits where f[0] == '0' select f);
            foreach ( var item in result)
            {
                Console.WriteLine(item);
            }
           
        }



    }
}