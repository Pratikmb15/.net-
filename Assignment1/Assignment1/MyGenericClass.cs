using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class MyGenericClass<T>
    {
        private T Member;
        public MyGenericClass(T Value) {
            this.Member = Value;
        }
        public void GenericMethod(T Value) {
            Console.WriteLine($"Parameter ={typeof(T)} and Value:{Value}");
        }

    }
}
