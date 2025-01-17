using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace OOP
{
    internal class Employee:Admin
    {
        String Location;
        internal void employee(string location)
        {
            Location = location;
        }

        internal void display1() {
            Console.WriteLine($"Location is {Location}");
        }
    }
}
