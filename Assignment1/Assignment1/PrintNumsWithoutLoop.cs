using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class PrintNumsWithoutLoop
    {
        int num = 0;
        public void PrintNum(int num)
        {

            Console.WriteLine(num);
            if (num < 100)
            { 
                PrintNum(num+1);
                
            }
        }
    }
}
