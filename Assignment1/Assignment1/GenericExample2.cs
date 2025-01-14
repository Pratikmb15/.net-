using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class GenericExample2
    {
        public static void Main(String[] args) 
        {
            int[] array = { 0, 5, 7, 6, 9 };
            String[] array2 = { "Rohit", "Raj", "Aditi" };
            Object[] array3 = {"Ram",8.50,9999999999999999999,'p' };
            GenericExample2.Display(array);
            GenericExample2.Display(array2);
            GenericExample2.Display(array3);
        }

        private static void Display<T>(T[] Array)
        {
            foreach (var item in Array) {
                Console.Write(item+" ");
            }
            Console.WriteLine();    
        }
    }
}
