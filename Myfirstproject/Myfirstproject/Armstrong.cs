using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfirstproject
{
    internal class Armstrong
    {
        public bool isArmstrong(int num)
        {
            int OGnum = num;
            int sum = 0;
            int digits = num.ToString().Length;
            while (num > 0)
            {
                int digit = num % 10;
                sum += (int)Math.Pow(digit, digits);
                num /= 10;
            }
            if(sum == OGnum)
            {
                return true;
            }
            else
            {
               return  false;
            } 
        }
    }
}
