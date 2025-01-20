using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class OverflowexeptionExample
    {
        public static void Main()
        {
            try
            {

                int max = int.MaxValue;
                int result = checked(max + 1);
                Console.WriteLine(result);
            }
            catch (OverflowException ex) {
            Console.WriteLine(ex.Message);
            }
         
        }
    }
}
