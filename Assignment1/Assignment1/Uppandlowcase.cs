using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Uppandlowcase
    {
        public void Upperandlowercase(String name)
        {
            String UpperCaseName = name.ToUpper();
            String LowerCaseName = name.ToLower();
            Console.WriteLine($"Place name in uppercase is : {UpperCaseName}");
            Console.WriteLine($"Place name in lowercase is : {LowerCaseName}");

        }
    }
}
