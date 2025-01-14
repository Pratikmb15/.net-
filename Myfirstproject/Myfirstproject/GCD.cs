using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfirstproject
{
    internal class GCD
    {
        public int FindGCD(int a, int b)
        {
            if (b < 0) { throw new ArgumentException("Invalid num!"); }
            if (b == 0) {
                return a;
            }
            return FindGCD(b, a % b);
        }

        public int FindLCM(int a, int b)
        {
            if (a <= 0 || b <= 0)
            {
                throw new ArgumentException("Numbers must be positive integers!");
            }
            int gcd = FindGCD(a, b);
            return (a / gcd) * b; // Avoid overflow by dividing first
        }
    }


}

