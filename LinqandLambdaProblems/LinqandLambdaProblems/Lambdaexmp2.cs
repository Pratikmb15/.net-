using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqandLambdaProblems
{
    internal class Lambdaexmp2
    {
        public static void Main(String[] args)
        {
            List<int> list = new List<int>() { 56, 75, 81, 68, 29, 36 };

            var Squares = Square(list);
            Console.WriteLine("\nSquare of List is :");
            foreach (var s in Squares)
            {
                Console.Write(s + " ");
            }

            var DisplayEven = list.Where(x => (x % 2) == 0);
            Console.WriteLine("\nEven numbers in List are: ");
            foreach (var data in DisplayEven)
            {
                Console.Write(data + " ");
            }

            var displayindesc = list.OrderByDescending(n => n);
            Console.WriteLine("\nList Ordered by Decending :");
            foreach (var m in displayindesc)
            {
                Console.Write(m + " ");
            }

            var PerfectSquares = PerfectSquare(list);
            Console.WriteLine("\nPerfect Squares in list are :");
            foreach (int ele in PerfectSquares)
            {
                Console.Write(ele + " ");
            }

        }
        public static List<int> Square(List<int> inputlist)
        {
            return inputlist.Select(x => x * x).ToList();
        }
        public static List<int> PerfectSquare(List<int> inputlist)
        {
            return inputlist.FindAll(x => Math.Sqrt(x) % 1 == 0).ToList();
        }



    }
}
