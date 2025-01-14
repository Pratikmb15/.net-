using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class SquareSumDiff
    {
        double Sum;
        double diff;
        public void SquareSumandDiff(float num1, float num2)
        {
            Sum = num1 + num2;
            diff = num1 - num2;
            double SquareofSum = Sum * Sum;
            double SquareofDiff = diff * diff;

            Console.WriteLine($"Square of sum of two numbers is {SquareofSum} and Square of difference between two numbers is {SquareofDiff}");
        }
    }
}
