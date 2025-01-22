using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review1
{
    internal class SumOfEvenAndOdd
    { 
        int SumOfEven = 0;

        int SumOfOdd = 0;

        public void FindSum(int num) {
            while (num > 0) {
                
            int DigitVal = num % 10;
                if (DigitVal % 2 == 0)
                {
                    SumOfEven += DigitVal;
                }
                else { 
                SumOfOdd += DigitVal;
                }
            num = num / 10; 
            }
            Console.WriteLine($"Sum Of Even Digits is : {SumOfEven}");
            Console.WriteLine($"Sum Of Odd Digits is : {SumOfOdd}");

        
        }
    }
}
