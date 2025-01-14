using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class CalculateWorkingDays
    {
        public static void Main(String[] args) {
            Console.WriteLine("Enter Start Date");
            DateTime StartDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter End Date");
            DateTime EndDate = DateTime.Parse(Console.ReadLine());

            CalculateWorkingdays(StartDate, EndDate);

        }
        public static void CalculateWorkingdays(DateTime StartDate, DateTime EndDate) 
        {
            for (DateTime i = StartDate; i <= EndDate; i.AddDays(1)) 
            { }
        }
    }
}
