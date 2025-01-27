using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review4
{
    internal class ProblemNum2
    {
        public static void Main(String[] args)
        {
            {
                try
                {

                    Console.Write("Enter a : ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Enter b : ");
                    int b = int.Parse(Console.ReadLine());

                    int c = a / b;
                    Console.WriteLine($"Result : {c}");

                    Console.Write("Enter age :");
                    int age = int.Parse(Console.ReadLine());
                    if (age < 0 || age > 150)
                    {
                        throw new InvalidAgeException("Invalid age - Age Must be greater than 0 and less than 150");
                    }
                    Console.WriteLine(age);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("Cannot divide by zero");
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (InvalidAgeException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public class InvalidAgeException : Exception
        {
            public InvalidAgeException(string message) : base(message)
            {
            }
        }
    }
}
