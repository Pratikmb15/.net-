using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfirstproject
{
    internal class ReverseArray
    {
        public int[] ReversingArray(int[] arr) {
            int left = 0;
            int right = arr.Length - 1;
            while (left < right)       
            { 
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
            left++;
            right--;
            }
            return arr;
        }
    }
}
