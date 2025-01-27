using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProblemsonRegex
{
    internal class ValidateIpAddress
    {
        public static void Main(String[] args) {

            String IpAddress = "192.168.1.0";

            String pattern = @"^\d{3}\.\d{3}\.\d{1}.\d{1}$";

            if (Regex.IsMatch(IpAddress, pattern))
            {
                Console.WriteLine("Valid IpAddress");
            }
            else
            {
                Console.WriteLine("Invalid IpAddress");
            }
        }
    }
}
