using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review4
{
    internal class ProblemNum7
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>() { 4, 8, 10, 13, 16, 7};

            var result = list.Select(x => x * 2).ToList();
            foreach (var item in result)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            var numbersGreaterthan10 = list.Where(x => x > 10).ToList();
            Console.WriteLine("Numbers greater than 10 are : ");
            foreach (var num in numbersGreaterthan10)
            {
                Console.Write(num+" ");
            }
            Console.WriteLine();

           Func<int,int,int> Max  = (x, y) => x > y ? x : y;
            Console.WriteLine(Max(10, 20));
        }
       
    }
}
