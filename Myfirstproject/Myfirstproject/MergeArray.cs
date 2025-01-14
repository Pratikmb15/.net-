using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfirstproject
{
    internal class MergeArray
    {
        public void MergingArray(int[] arr1, int[] arr2) {
            int[] MergedArray = new int[arr1.Length+arr2.Length];
            arr1.CopyTo(MergedArray, 0);
            arr2.CopyTo(MergedArray, arr1.Length);
            int finalsize= MergedArray.Length;
            Console.Write("[");
            for (int i = 0; i < finalsize; i++)
            {
                Console.Write(MergedArray[i]+" ");
            }
            Console.Write("]");
        }
    }
}
