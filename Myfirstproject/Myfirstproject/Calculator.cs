using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfirstproject
{
    internal class Calculator
    {
        public double PerformOperation(double num1,double num2 ,Char op)
        {
            switch (op) {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    if (num2 > 0)
                    {
                        return num1 / num2;
                    } else { throw new ArithmeticException(); }
                case '%':
                    return num1 % num2;
                default: throw new InvalidOperationException(); 
            }

        }
    }
}
