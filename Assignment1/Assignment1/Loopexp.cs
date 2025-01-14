using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Loopexp
    {
        public static void Main(String[] args) {
            for (int i = 0; i < 7; i++) 
            {
                for (int j = 0; j < i;j++)                {
                    Console.Write(i + " ");
                }
            Console.WriteLine();
            }
        
        
        }

    }
}
