using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Array
    {
       
        public static void Main() {

            Console.Write("Input the size of array: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];

            Console.WriteLine($"Input {size} elements in the array in ascending order:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"element - {i}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            
            Console.Write("Input the position where to delete: ");
            int position = int.Parse(Console.ReadLine());

            
            if (position < 1 || position > size)
            {
                Console.WriteLine("Invalid position! Position must be between 1 and the size of the array.");
                return;
            }

            
            int[] newArray = new int[size - 1];
            for (int i = 0, j = 0; i < size; i++)
            {
                if (i != position )
                {
                    newArray[j++] = arr[i];
                }
            }

            Console.WriteLine("The new list is:");
            foreach (int item in newArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}


        
    

