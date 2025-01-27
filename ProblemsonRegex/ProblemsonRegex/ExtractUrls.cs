using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProblemsonRegex
{
    internal class ExtractUrls
    {
        public static void Main(String[] args) 
        {
            String text = "The website is https://www.google.com and the other website is https://www.bing.com ";
            String pattern = @"https?:\/\/(?:www\.)?([^\/\s]+)";

            MatchCollection matches = Regex.Matches(text, pattern);
            Console.WriteLine("Extracted URLs are : ");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[1].Value);
            }
        }
    }
}
