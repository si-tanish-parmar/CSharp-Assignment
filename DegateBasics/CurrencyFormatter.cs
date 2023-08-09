using System;
using System.Collections.Generic;

namespace DegateBasics
{
    public delegate string NumberFormatter(double number); // Make the delegate public

    internal class CurrencyFormatter
    {
        static void Main1(string[] args)
        {
            NumberDisplay numberDisplay = new NumberDisplay();
            List<double> numbers = new List<double> { 10.55, 8.9, 2.4, 6, 4 };
            numberDisplay.DisplayNumbers(numbers, numberDisplay.FormatCurrency);
            numberDisplay.DisplayNumbers(numbers, numberDisplay.FormatPercentage);
        }
    }

    public class NumberDisplay
    {
        public string FormatCurrency(double number)
        {
            return string.Format("${0:0.00}", number);
        }

        public string FormatPercentage(double number)
        {
            return string.Format("{0:0.00}%", number * 100);
        }

        public void DisplayNumbers(List<double> numbers, NumberFormatter formatter)
        {
            foreach (double number in numbers)
            {
                string formattedNumber = formatter(number);
                Console.WriteLine("Formatted: " + formattedNumber);
            }
        }
    }
}
