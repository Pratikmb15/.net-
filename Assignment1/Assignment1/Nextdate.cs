using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Assignment1
{
    internal class Nextdate
    {
        public void Findnextday(int day, int month, int year)
        {
            // Validate the input date
            if (year < 1 || year > 9999)
            {
                Console.WriteLine("Year must be between 1 and 9999.");
                return;
            }

            if (month < 1 || month > 12)
            {
                Console.WriteLine("Month must be between 1 and 12.");
                return;
            }

            if (day < 1 || day > DateTime.DaysInMonth(year, month))
            {
                Console.WriteLine($"Day must be between 1 and {DateTime.DaysInMonth(year, month)} for the given month and year.");
                return;
            }

            try
            {
                // Create a valid DateTime object
                DateTime today = new DateTime(year, month, day);

                // Add one day to get the next day
                DateTime nextday = today.AddDays(1);

                // Display the next date
                Console.WriteLine($"The next date is [yyyy-mm-dd]: {nextday.ToString("yyyy-MM-dd")}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
