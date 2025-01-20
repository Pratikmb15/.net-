using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class IndexOutofBoundExceptionExp
    {
        public static void Main()
        {
            try
            {
                int size = 10;
                int[] arr = new int[size];
                for (int i = 0; i <= size; i++)
                {
                    arr[i] = i;
                }
                
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException excp) {
                Console.WriteLine(excp.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
