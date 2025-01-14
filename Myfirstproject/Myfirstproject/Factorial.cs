using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfirstproject
{
    internal class Factorial
    {
        public int Findfactorial(int num) {
            if (num < 0)
            {
                throw new ArgumentException("Factorial is not defined for negative numbers.");
            }

            if ((num == 0) || (num == 1)) {
                return 1;
            }
         return num*Findfactorial(num-1);
        }  
    }
}
