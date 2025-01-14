using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Lambda2
    {
        public static void Main(String[] args) {
        List<int> list = new List<int>() {56,75,80,68,29};

        var DisplayEven = list.Where(x=>(x%2)==0);
        
        foreach (var data in DisplayEven) {
                Console.WriteLine(data);

                var displayindesc = list.OrderByDescending(n => n);

                foreach (var m in displayindesc)
                {
                    Console.WriteLine(m);
                }
            }
        }
    }
}
