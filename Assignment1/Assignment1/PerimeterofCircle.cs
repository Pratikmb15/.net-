using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class PerimeterofCircle
    {
        public void FindPerimeterofCircle(float diameter) { 
            if (diameter < 0) 
            { 
                return;
            }
            float radius = diameter / 2;

            double Perimeter = 2*3.14*radius;
            Console.WriteLine($"Perimeter of Circle of diameter {diameter} is {Perimeter}");

        
        }
    }
}
