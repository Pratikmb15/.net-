using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Friends
    {
        public void friend() {
        String Frnd1, Frnd2, Frnd3, Frnd4, Frnd5;
            Console.WriteLine("Enter your Five friends Name:");
            Frnd1 = Console.ReadLine();
            Frnd2 = Console.ReadLine();
            Frnd3 = Console.ReadLine();
            Frnd4 = Console.ReadLine();
            Frnd5 = Console.ReadLine();

            Console.WriteLine($"My five friends Names are : {Frnd1},{Frnd2},{Frnd3},{Frnd4},{Frnd5}");

        }
        
    }
}
