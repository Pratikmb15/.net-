using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class GenericExample
    {
        public static void Main(String[] args) 
        {
            GenericExample.Comparator<String>("Pratik","Pratik");
            GenericExample.Comparator<double>(10.01,10.1);
            GenericExample.Comparator<char>('A','a');

            
        
        }
        public static void Comparator<T>(T para1, T para2){
            if (para1.Equals(para2)) {
                Console.WriteLine("Both Parameters are Equal");
            }
            else
            {
                Console.WriteLine("Para1 in not equal to Para2");
            }
        }

    }
}
