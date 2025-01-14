using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfirstproject
{
    internal class PrimeNum
    {
        public bool CheckPrimeNum(int num) {
            if (num <= 0) { throw new ArgumentException("Enter Valid Number!"); }
            if (num % 2 == 0) { return false; } 
            else return true;
        }
    }
}
