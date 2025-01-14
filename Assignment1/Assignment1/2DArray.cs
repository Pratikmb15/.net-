using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class _2DArray
    {
        public static void Main(String[] args) {
            int[,] arr = new int[3, 3] { { 1, 2, 5 }, { 3, 4, 8 }, { 5, 6, 9 } };
            for (int i = 0; i < arr.GetLength(0); i++) {
                for (int j = 0; j < arr.GetLength(1); j++) {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
        public void Search(int ele, int[,] array) 
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++) {
                    if (array[i, j] == ele) {
                        Console.Write(array[i, j]);
                        break;
                        
                    }
                }
            }
        }
    }
}
