using System;
using System.Collections.Generic;

namespace Assignment1
{
    internal class Specialnum
    {
        public void FindSpecialnum()
        {
            List<int> list = new List<int>();

            // Iterate through numbers from 2000 to 3200
            for (int i = 2000; i <= 3200; i++)
            {
                // Check if divisible by 7 but not by 5
                if ((i % 7 == 0) && (i % 5 != 0))
                {
                    list.Add(i); // Add to the list
                }
            }

            // Print the list elements separated by commas
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
