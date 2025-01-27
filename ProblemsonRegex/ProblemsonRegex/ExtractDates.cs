using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProblemsonRegex
{
    internal class ExtractDates
    {
        public static void Main(String[] args) {
        
            String text = "Today is 15/07/2024 and tomorrow is 16/07/2024 ";
            String pattern = @"\b(\d{2}\/\d{2}\/\d{4}|\d{2}\-\d{2}\-\d{4})\b";

            MatchCollection matches = Regex.Matches(text, pattern);
            Console.WriteLine("Extracted Dates are : ");
            foreach (Match match in matches) {
                Console.WriteLine(match.Value);
            }
        }
    }
}
