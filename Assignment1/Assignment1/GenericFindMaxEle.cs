using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class GenericFindMaxEle
    {
        public static void Main(String[] args) 
        {
            int[] arr = {5,84,64,22,77};
            char[] arr2 = { 'b', 'z', '#', '+','A'};
            double[] arr3 = {-45.20,-555.87,-60 };
            GenericFindMaxEle obj = new GenericFindMaxEle();
            obj.findMax(arr3);
        }
        public void findMax<T>(T[] arr) where T : IComparable<T>
        {
            T maxele = arr[0];
            foreach (T item in arr) {
                if (item.CompareTo(maxele)>0) { 
                maxele = item;
                }
            }
            Console.WriteLine(maxele.ToString());
        
        }
    }
}
