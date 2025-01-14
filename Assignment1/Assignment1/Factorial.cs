using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Factorial
    {
        public static int FindFactorial(int num)
        {
            if (num == 0 || num == 1)
            {
                return 1;
            }
            else
            {
                while (num > 0)
                {
                    return num * FindFactorial(num - 1);
                }
            }
            return 0;
        }
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter Number :");
            int num = int.Parse(Console.ReadLine());
            long result = FindFactorial(num);
            Console.WriteLine(result);
        }
    }
}
