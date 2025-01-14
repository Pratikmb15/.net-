using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Checktype
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Enter any Character :");
            String ch = Console.ReadLine();
            Checkfortype(ch);
        }
        public static void Checkfortype(String ch) { 
            switch (ch) {
                case "+": 
                case "-": 
                case "*": 
                    Console.WriteLine("Arithmetic operator");
                    break;

                case "&&":
                case "||":
                    Console.WriteLine("Logical operator");
                    break;

                case "==":
                case "<":
                case ">":
                    Console.WriteLine("Relational Operator");
                    break;
                default:
                    Console.WriteLine("Enter Valid Char !");

                    break;
            }
        }
    }
}
