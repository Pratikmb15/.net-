using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review4
{
    internal class ProblemNum4
    {
        public static void Main(String[] args) {
        Func<int,String> CheckEven=x=>x%2==0 ? "Even":"Odd";

           
            Console.WriteLine(CheckEven(10));

        Func<String,String,bool> checkifSameLength = (x, y) => x.Length == y.Length ? true : false;
            String str1 = "Hello";
            String str2 = "World";
            if (checkifSameLength(str1, str2))
            {
                Console.WriteLine("Both strings are of same length");
            }
            else
            {
                Console.WriteLine("Both strings are of different length");
            }

        }
    }
}
