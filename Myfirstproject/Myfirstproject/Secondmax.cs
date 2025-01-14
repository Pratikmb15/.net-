using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfirstproject
{
    internal class Secondmax
    {
        public void SecondMaximumElement(int[] arr)
        {
            int maxelement = 0;
            int prevmax = 0;
            foreach (int i in arr)
            {
                if (i > maxelement)
                {
                    prevmax = maxelement;
                    maxelement = i;
                }
            }
            Console.WriteLine(" Second Maximum Element in array is : " + prevmax);
        }
    }
}
