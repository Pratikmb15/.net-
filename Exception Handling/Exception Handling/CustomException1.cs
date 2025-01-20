using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class InvalidAgeException : Exception
    {

        public InvalidAgeException(string message) : base(message)
        {

        }
    }
    internal class CustomException1
    {
        public static void Main(String[] args)
        {
            try
            {
            Console.Write("Enter Your age :");
            int age = int.Parse(Console.ReadLine());
            if (age < 18)
            {
                throw new InvalidAgeException("You Cannot Drive a vehicle !");
            }
            else
            {
                Console.WriteLine("You can Drive Vehicle ");
            }
                Console.WriteLine("Enter a and b :");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int result = a / b;
                
                Console.WriteLine($"The result after dividing a by b is : {result} ");
                
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception excp)
            {
                Console.WriteLine(excp.Message);
            }
            finally {
                Console.WriteLine("This will always be executed");
            }

        }
    }
}
