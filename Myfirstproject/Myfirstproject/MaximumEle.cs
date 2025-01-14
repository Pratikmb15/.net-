using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfirstproject
{
    internal class MaximumEle
    {
        public void MaximumElement(int[] arr) {
            int maxelement = 0;
            foreach (int i in  arr)
            {
                if (i > maxelement)
                {
                    maxelement = i;
                }
            }
            Console.WriteLine("Maximum Element in array is : "+maxelement);
        }
    }
}
