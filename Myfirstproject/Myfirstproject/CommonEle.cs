using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfirstproject
{
    internal class CommonEle
    {
        public void FindCommonElements(int[] arr1, int[] arr2)
        {
            Console.WriteLine("Common elements are:");
            Console.Write("[");
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if(arr1[i] == arr2[j])
                    {
                        Console.Write(arr1[i]+" ");
                    }  
                }
            }
            Console.Write("]");
        }
    }
}
