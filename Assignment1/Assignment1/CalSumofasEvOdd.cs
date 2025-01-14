using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class CalSumofasEvOdd
    {
        public static void Main(String[] args){
            Console.WriteLine("Enter number");
            int num =int.Parse(Console.ReadLine());
            CalSumofasEvOdd.CalsumOddEv(num);
            

        }
        public static void CalsumOddEv(int num) 
        {
            int EvenSum = 0;
            int OddSum = 0;
            if (num == 0) {
                Console.WriteLine("Enter Valid Number !");
                return;
            }
            while (num > 0) 
            {
                int rem = num % 10;
                if (rem % 2 == 0)
                {
                    EvenSum += rem;
                }
                else {
                OddSum += rem;  
                }
                num =num / 10;
            }
            Console.WriteLine($"Even number Sums is {EvenSum}");
            Console.WriteLine($"Odd number Sums is {OddSum}");
        }
    }
}
