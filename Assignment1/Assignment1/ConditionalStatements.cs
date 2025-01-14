using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class ConditionalStatements
    {
        public bool CheckNatural() {
           
            Console.WriteLine("Enter any Natural Number :");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0) { 
             return false;
            }
            else
            {
                return true;
            }
        }

        public void CheckName()
        {
            Console.WriteLine("Enter Name:");
            String s = Console.ReadLine();
            Console.WriteLine(s);
            if (s.Equals("Pratik"))
            {
                Console.WriteLine("Welcome Pratik");
            }
            //return;
            Console.WriteLine("Unkown!");
        }

        public double calculator(char ch,float num1,float num2)
        {
            switch (ch) {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2; 
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot Divide by Zero");
                        return 0;
                    }
                    else
                    {
                        return num1 / num2;
                    }
                default: return 0;            
            }
        }
    }
}
