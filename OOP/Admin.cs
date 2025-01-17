using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Admin
    {
        String Role;
        int Salary;

       public void admin(String Role,int Salary)
        {
            this.Role = Role;
            this.Salary = Salary;   
        }
        public void display()
        {
            Console.WriteLine($"Role is {Role} and Salary is {Salary}");
        }
    }
}
