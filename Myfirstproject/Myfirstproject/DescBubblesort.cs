using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfirstproject
{
    internal class DescBubblesort
    {
        public void Sorter(int[] array)
        {
            int size = array.Length;

            for (int i = 0; i < size; i++)
            {
                bool Swapped = false;
                for (int j = 0; j < size - i - 1; j++)
                {

                    if (array[j] < array[j + 1])
                    {
                        //swap
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        Swapped = true;

                    }

                }
                if (!Swapped)
                {
                    break;
                }

            }
        }
    }
}
