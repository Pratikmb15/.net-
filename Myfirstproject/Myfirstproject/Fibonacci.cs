using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfirstproject
{
    internal class Fibonacci
    {
        public void FindFibonacci(int limit)
        {

            if (limit < 0)
                throw new ArgumentException("limit cannot be negative");
            int a = 0, b = 1;

            Console.WriteLine("Fibonacci Series is :");



            if (limit >= a) Console.Write(a + " ");

            if (limit >= b) Console.Write(b + " ");

            int next = a + b;
            while (next <= limit)
            {
                Console.Write(next+" ");
                a = b;
                b = next;
                next = a + b;

            }
            Console.WriteLine();
        }
    }
}
