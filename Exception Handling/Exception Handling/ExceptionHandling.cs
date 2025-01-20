using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class ExceptionHandling
    {
        public static void Main(String[] args) {
            int[] arr = {5, 8, 7, 12, 4, 19};
            Console.Write("Enter the Element to be Searched :");
            int target = int.Parse(Console.ReadLine());
            Search(target, arr);
        }
        public static void Search(int target, int[] arr)
        {
            try { for (int i = 0; i < arr.Length; i++) {
                    if (arr[i] == target) {
                        Console.WriteLine($"Element Found at {i} index");
                        return;
                    }
                }
                Console.WriteLine("Element not found in Array");
                return;
            }catch (Exception e)
            {
                Console.WriteLine(e.Message); 
            }
        }
    }
}
