using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class DaysConverter
    {
        public static void Main(String[] args) {

            Console.WriteLine("Enter Days: ");
            int Totaldays = int.Parse(Console.ReadLine());

            int Years = Totaldays / 365;
            int Remainingdaysafteryears = Totaldays % 365;

            int Months = Remainingdaysafteryears / 30;
            int RemainingdaysafterMonths = Remainingdaysafteryears % 30;

            int Weeks = RemainingdaysafterMonths / 7;
            int Days = RemainingdaysafterMonths % 7;

            Console.WriteLine($"Years : {Years}");
            Console.WriteLine($"Months : {Months}");
            Console.WriteLine($"Weeks : {Weeks}");
            Console.WriteLine($"Days : {Days}");
            
        }
    }
}
