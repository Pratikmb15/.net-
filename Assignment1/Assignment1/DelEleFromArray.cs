using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class DelEleFromArray
    {
        public static void Main(String[] args) 
        {
            int[] arr = { 5, 10, 8, 4, 6, 7 };
            Console.WriteLine("Enter Position of Element to be deleted :");
            int position = int.Parse(Console.ReadLine());
            int[] result = DelEle(position,arr);
            foreach (int ele in result) {
                Console.Write(ele+" ");
                
            }
            Console.WriteLine();
        }
        public static int[] DelEle(int pos, int[] array) 
        {
            if (pos < 0||pos>array.Length) {
                Console.WriteLine("Enter Correct Position !");
                return null;
            }
        int[] narr= new int[array.Length-1];
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (i == pos) continue;
                narr[j++] = array[i];
            }
            return narr;
        }

    }
}
