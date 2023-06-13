using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class CalculateValues
    {
        public int add (int num1 , int  num2) 
        {
            int add=num1+num2;

            return add;

        }
        public int sub(int num1, int num2)
        {
            int sub = num1 - num2;

            return sub;

        }
        public int mul(int num1, int num2)
        {
            int mul = num1 * num2;

            return mul;

        }
        public int div(int num1, int num2)
        {
            int div = num1 / num2;

            return div;

        }
    }
}
