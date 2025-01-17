using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqandLambdaProblems
{
    internal class LambdaSum2
    {
        public static void Main()
        {
            List<int> list = new List<int>() { 5, 8, 3, 9, 2 };
            int sum = list.Sum(x => x);
            int max = list.Max(x => x);
            int min = list.Min(x => x);
            double avg = list.Average(x => x);

            Console.WriteLine($"Sum of numbers in List is {sum}");
            Console.WriteLine($"Maximum number in List is {max}");
            Console.WriteLine($"Minimum number in List is {min}");
            Console.WriteLine($"Average of numbers in List is {avg}");

        }
    }
}
