using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class SplitName
    {
        public void splitname(String Fullname)
        {
            if (Fullname.Length == 0)
            {
                return;
            }
            String[] Nameparts = Fullname.Split(' '); 
            int namecount = Nameparts.Length;
            Console.WriteLine($"String has {namecount} parts");

            foreach (var part in Nameparts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
