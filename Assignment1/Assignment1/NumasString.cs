using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class NumasString
    {
        public void NumberasString(String number) 
        {
            int num = int.Parse(number);
            int result = num * 10;
            
           Console.WriteLine("10 times of given number is :"+ result.ToString());
        }
    }
}
