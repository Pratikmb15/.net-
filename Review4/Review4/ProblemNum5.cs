using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review4
{
    internal class ProblemNum5
    {
        public static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            Console.WriteLine($"Before Swapping : a = {a}, b = {b}");
            (a, b) = Swap<int>(a, b);
            Console.WriteLine($"After Swapping: a = {a}, b = {b}");
        }

        public static (T, T) Swap<T>(T a, T b)
        {
            return (b, a); 
        }
    }
}
