using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqandLambdaProblems
{
    internal class Linqprob2
    {
        public static void Main(String[] args)
        {
            List<int> Scores = new List<int>() { 78, 90, 86, 82, 72, 68 };

            var Top3 = Scores.OrderByDescending(x => x).Take(3);
            Console.WriteLine("The Top 3 Scores in List are :");
            foreach (int i in Top3)
            {
                Console.WriteLine(i);
            }

        }
    }
}
