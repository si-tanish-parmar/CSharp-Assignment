using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsBasics
{
    internal class Calculator
    {
        public int AddInt(int x, int y)
        {
            int result = x + y;
            return result;
        }
        public double AddDouble(double x, double y)
        {
            double result = x + y;
            return result;
        }
        public int Multiply(int x, int y)
        {
            int result = x * y;
            return result;
        }

        public int Multiply(int x, int y,int z)
        {
            int result = x * y*z;
            return result;
        }
        public int Divide(int x, int y)
        {
            int result = x / y;
            return result;
        }

    }
}
