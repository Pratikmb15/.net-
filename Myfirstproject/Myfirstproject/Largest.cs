using System;

namespace Myfirstproject
{
    internal class Largest
    {
        public int FindLargest(int a, int b, int c)
        {
            if (a >= b && a >= c)
            {
                return a;
            }
            else if (b >= a && b >= c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
    }
}
