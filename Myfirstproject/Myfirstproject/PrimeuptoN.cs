using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfirstproject
{
    internal class PrimeuptoN
    {
        public void PrintPrime(int limit)
        {
            if (limit < 2)
            {
                Console.WriteLine("No Prime numbers");
            }
            List<int> arr = new List<int>(); 
            for(int i = 2; i <= limit; i++)
            {  
                if (CheckPrimeNum(i))
                {
                    arr.Add(i);
                }

            }
            Console.WriteLine("Prime numbers up to " + limit + ": " + string.Join(", ", arr));
        }
        public bool CheckPrimeNum(int num)
        {
            if (num <= 0) { throw new ArgumentException("Enter Valid Number!"); }
            if (num % 2 == 0) { return false; }
            else return true;
        }
    }
}
