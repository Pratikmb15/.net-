using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProblemsonRegex
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public String Email { get; set; }
        public String Gender { get; set; }

        public int Zipcode { get; set; }
    }
    internal class DataAnnotation2
    {
        public static void Main(String[] args)
        {
            Console.Write("Enter Name : ");
            String name = Console.ReadLine();
           
            Console.Write("Enter Age :");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter Email :");
            String Email = Console.ReadLine();

            Console.Write("Enter Gender : ");
            string gender = Console.ReadLine();

            Console.Write("Enter Zipcode : ");
            String zipcode = Console.ReadLine();


            if (!isValid(name))
            {
                Console.WriteLine("Enter Valid name");
            }

            if (!isValidAge(age))
            {
                Console.WriteLine("Enter Valid Age");
            }

            if (!isValidEmail(Email)) {
            Console.WriteLine("Enter Valid Email");
            }
            if (!isValidGender(gender))
            {

                Console.WriteLine("Enter Valid Gender");
            }
            if (!isValidZipcode(zipcode))
            {
                Console.WriteLine("Enter Valid Zipcode");
            }

            Student student = new Student()
            {
                Name = name,
                Age = age,
                Email = Email
            };


        }
        public static bool isValid(String name) {
        String regxString = @"^[A-Z]{1}[a-zA-Z\s]{2,}$";

        Regex reg = new Regex(regxString);
            return reg.IsMatch(name);

        }
        public static bool isValidAge(int age)
        {
            return age >= 18;
        }
        public static bool isValidEmail(String email) {
            string pat = @"^[^\s@]+@[^\s@]+\.[^\s@]+$";
            Regex reg = new Regex(pat);
            return Regex.IsMatch(email,pat);

        }
        public static bool isValidGender(String gen) {
        String regxGen = @"^(Male|Female|M|F)$";
            
            return Regex.IsMatch(gen,regxGen,RegexOptions.IgnoreCase);
        }

        public static bool isValidZipcode(String zip)
        {
            String regxZip = @"^[1-9]{1}[0-9]{5}$";
            return Regex.IsMatch(zip, regxZip);
        }
    }
}
