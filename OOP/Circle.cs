using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Circle : Shapes
    {
        public override void Area()
        {
            Console.WriteLine("Area is 3.14*r*r");
        }
    }
}
