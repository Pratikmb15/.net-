using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class CalculateDaystoBirthDay
    {
        public static void Main() 
        {
            try
            {
                Console.WriteLine("Enter your Birthday YYYY/MM/DD");

                DateTime Birthday = DateTime.Parse(Console.ReadLine());
                DateTime today = DateTime.Now;
                int Currentyear = today.Year;


                DateTime NextBirthday = new DateTime(Currentyear, Birthday.Month, Birthday.Day);

                if (NextBirthday < today)
                {
                    NextBirthday = NextBirthday.AddYears(1);
                }

                int DaysLeftforNextBirthday = (NextBirthday - today).Days;

                Console.WriteLine($"Your Next Birthday in in {DaysLeftforNextBirthday} Days");
            }
            catch (Exception ex){
            Console.WriteLine(ex.Message);
            }
        }
    }
}
