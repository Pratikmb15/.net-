using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class AllzeroAtLast
    {
        public static void Main(String[] args) {
            int[] arr = { 9, 0, 54, 84, 0, 66, 77, 55 };
            int[] result = MoveZerosAtLast(arr);
            foreach (int ele in result) { 
            Console.Write(ele+" ");
            }
        }
        public static int[] MoveZerosAtLast(int[] array) {
            int[] Narr = new int[array.Length];
            int nonZeroindex = 0;
            foreach (int i in array) {
                if (array[i]==0) continue;
                Narr[nonZeroindex++] = i;
            }
            while (nonZeroindex < array.Length) {
                Narr[nonZeroindex++] = 0;
            }
            return Narr;
        }

    }
}
