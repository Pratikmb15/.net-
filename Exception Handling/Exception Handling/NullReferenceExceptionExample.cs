using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class NullReferenceExceptionExample
    {
        public static void Main() {
            try
            {
                String str = null;
                if (str == null) { 
                throw new NullReferenceException("Given String Reference is Null !");
                }
                int l = str.Length;
                Console.WriteLine(l);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
