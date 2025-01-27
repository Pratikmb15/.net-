using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProblemsonRegex
{
    internal class RegexMobnum
    {
        public static void Main(string[] args)
        {
            

            String MobNumber1 = "8888489968";
            String MobNumber2 = "+91 9307378328";
            String MobNumber3 = "025-2684-3528";

            CheckifValidMobNum(MobNumber1);
            CheckifValidMobNum(MobNumber2);
            CheckifValidMobNum(MobNumber3);

        }
        public static void CheckifValidMobNum(String mobno)
        {
            string regxString = @"
               (^[0-9]{10}$)
               |(^\+[0-9]{2}\s[0-9]{2}[0-9]{8}$)
               |(^[0-0]{3}-[0-9]{4}-[0-9]{4}$)
               ";
            Regex reg = new Regex(regxString,RegexOptions.IgnorePatternWhitespace);
            if (reg.IsMatch(mobno))
            {
                Console.WriteLine($"{mobno} is Valid Mobile Number !");
            }
            else {
                Console.WriteLine($"{mobno} is  not Valid Mobile Number !");
            }
        }
    }
}
