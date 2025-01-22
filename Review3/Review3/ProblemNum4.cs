using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review3
{
    public class ProblemNum4
    {
        public static void Main(String[] args)
        {
            List<int> numbers = new List<int>() { 68, 70, 12, 56, 34, 82, 27, 17 };

            var numbersinDescendingOrder = numbers.OrderByDescending(x => x);
            Console.WriteLine("Numbers in Descending Order are :");
            foreach (var ele in numbersinDescendingOrder)
            {
                Console.Write(ele + " ");
            }
            Console.WriteLine();

            var primeNumbers = numbers.Where(x => isPrime(x));
            Console.WriteLine("\nPrimeNumbers in List are :");
            foreach (var n in primeNumbers)
            {
                Console.WriteLine(n + " ");
            }

            int threshold = 30;
            var numbersGreaterthanThreshold = numbers.Where(x => x > threshold);
            Console.WriteLine($"\nNumbers in List Greater than {threshold} are :");
            foreach (var item in numbersGreaterthanThreshold)
            {
                Console.Write(item + " ");
            }
            var sumofnumbersGreaterthanThreshold = numbersGreaterthanThreshold.Sum();
            Console.WriteLine($"\nSum of Numbers greater than {threshold} is {sumofnumbersGreaterthanThreshold}");





        }

        public static bool isPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            else
            {
                for (int i = 2; i < Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }

        }
    }
}
