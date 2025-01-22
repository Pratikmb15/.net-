using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review1
{
    internal class CalculateAge
    {
        public void FindAge(int BirthYear) { 
        
        DateTime today = DateTime.Today;
            if (BirthYear > today.Year)
            {
                Console.WriteLine("Enter Correct BirthYear!");
            }
            else
            {
                int Age =  today.Year -BirthYear ;
                Console.WriteLine($"Age is {Age}");
            }

        }
    }
}
