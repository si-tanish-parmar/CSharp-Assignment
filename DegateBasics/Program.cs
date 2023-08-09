namespace DelegateDemo
{//Step 1 :Delcare a delegate
    delegate void GreetingDelegate(string str);
    //delegate int CalculatorDelegate(int x, int y);
    public delegate void Del<T>(T item);
    public delegate T CalculatorDelegate<T>(T x , T y);

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the arithmetic operator");

            char op = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter the operand 1");

            int num1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter the operand 2");
            //object for calculate class
            int num2 = Convert.ToInt32(Console.ReadLine());
            Calculator c1=new Calculator();
            //instance for delegate
            CalculatorDelegate<int> calcDel =c1.Add ;
            calcDel = c1.Multiple;
            calcDel = c1.Divide;
            //CalculatorDelegate<double> calcDel = c1.;



            Calculator calculator = new Calculator();
            try
            {
                switch (op)
                {
                    case '+':
                        calcDel = calculator.Add;
                        break;
                    case '-':
                        calcDel = calculator.Subtract;
                        break;
                    case '*':
                        calcDel = calculator.Multiple;
                        break;
                    case '/':
                        calcDel = calculator.Divide;
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
                DisplayResult(num1, num2, calcDel);
            }




            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void DisplayResult(int x, int y, CalculatorDelegate<int> Del)
        {
            int result = Del(x, y);
            Console.WriteLine($"The result of is = " + result);
        }
        static void DisplayWelcome(string name)
        {
            Console.WriteLine($"Hai {name} Welcome !");


        }
        static void DisplayThankyou(string name)
        {
            Console.WriteLine($"Hai {name} Thankyou !");
        }
        static void DisplayMessage(string name)
        {
            Console.WriteLine($"Hai {name} Have a nice day !");
        }

    }
}

//static void DisplayWelcome(string name)
//    {

//        Console.WriteLine("Enter your name");
//        string name = Console.ReadLine();
//    }

//        Console.WriteLine("Enter Login or Logout");
//        string choice = Console.ReadLine();

//  if(choice.Equals("Login"))
//        {
//            del = DisplayWelcome;
//            del(name);
//        }
//        else
//        {
//            del = DisplayThankyou;
//            del(name);
//        }

///*          
////step2 create  instance for delegate and bind a method with same signature
//        GreetingDelegate greet = DisplayWelcome;

//        //Multicast delegate
//        greet += DisplayMessage;
////step3.call the delegate by passing parametre if any
//        greet("minu");

//        //remove a method from delegate
//        greet -= DisplayMessage;

//        GreetingDelegate greetingDelegate = DisplayThankyou;
//        greetingDelegate ("Bob");
//    }

//    static void DisplayWelcome(string name)
//    { Console.WriteLine($"Hai {name} Welcome !");


//    }
//    static void DisplayThankyou(string name)
//    {
//        Console.WriteLine($"Hai {name} Thankyou !");
//    }
//    static void DisplayMessage(string name)
//    {
//        Console.WriteLine($"Hai {name} Have a nice day !");
//    }

////}

