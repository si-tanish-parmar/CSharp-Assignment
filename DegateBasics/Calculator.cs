using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{

    internal class Calculator
    {
        /*
    { public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("Enter the arithmetic operator");

            char op = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter the operand 1");

            char num1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter the operand 2");
            //object for calculate class
            char num2 = Convert.ToInt32(Console.ReadLine());
            //instance for delegate
            CalculatorDelegate calcDel = null;
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
                int result = calcDel(num1, num2);
                Console.WriteLine($"the result of {num1} {op} {num2} = " + result);
            }




        Catch(Exception e)
                { Console.WriteLine(e.Message)
                    } }
         */
        public string Concate(string x, string y)
        {
            return x + " " + y;
        }
        public double AddDouble(double x, double y)
        {
            return x + y;
        }
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Subtract(int x, int y)
        {
            return x - y;
        }
        public int Multiple(int x, int y)
        {
            return x * y;
        }
        public int Divide(int x, int y)
        {
            return x / y;
        }
    }

}
