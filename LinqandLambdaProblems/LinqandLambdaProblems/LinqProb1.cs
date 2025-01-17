using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqandLambdaProblems
{
    internal class LinqProb1
    {
        public static void Main(String[] args)
        {
            List<string> list = new List<string>() { "pratik", "shreya", "rohan", "aditi", "prathamesh", "abhishek" };

            var StringStartingwithA = list.Where(x => x.StartsWith("a", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("String in list Starting with 'a' are :");
            foreach (var x in StringStartingwithA)
            {
                Console.WriteLine(x + " ");
            }
        }
    }
}
