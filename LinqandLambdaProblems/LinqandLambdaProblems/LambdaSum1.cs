using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqandLambdaProblems
{
    internal class LambdaSum1
    {
        public static void Main()
        {

            List<String> list = new List<string>() { "pratik", "shreya", "rohan", "aditi", "prathamesh" };

            Console.Write("Enter Character to Count its occurence :");
            char Target = char.Parse(Console.ReadLine());

            int count = list.SelectMany(x => x).Count(ch => ch == Target);
            Console.WriteLine($"Occurence of {Target} in list is {count} times");
        }

    }
}
