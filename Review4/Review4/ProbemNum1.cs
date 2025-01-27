using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Review4
{
    public class PersonalInfo
    {
        [RegularExpression(@"^[A-Za-z]+@[A-Za-z]+\.[A-Za-z]+$", ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        [RegularExpression(@"^\+[0-9]{2}-[0-9]{10}$|^[0-9]{3}-[0-9]{3}-[0-9]{4}$", ErrorMessage = "Invalid phone number format.")]
        public string PhoneNum { get; set; }

        [StringLength(30, MinimumLength = 8, ErrorMessage = "Password must be between 8 and 30 characters long.")]
        public string Password { get; set; }

        public string Sentence { get; set; }
    }

    internal class ProbemNum1
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            Console.Write("Enter your phone number: ");
            string phoneNum = Console.ReadLine();

            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            Console.WriteLine("Enter any sentence: ");
            string sentence = Console.ReadLine();

            PersonalInfo personalInfo = new PersonalInfo
            {
                Email = email,
                PhoneNum = phoneNum,
                Password = password,
                Sentence = sentence
            };

            var context = new ValidationContext(personalInfo);
            var results = new List<ValidationResult>();

            var isValid = Validator.TryValidateObject(personalInfo, context, results, true);

            if (!isValid)
            {
                foreach (var validationResult in results)
                {
                    Console.WriteLine(validationResult.ErrorMessage);
                }
            }
            else
            {
                Console.WriteLine("All information is valid.");
            }
            if (!IsStrongPassword(password))
            {
                Console.WriteLine("Password is not strong.");
            }

        }

        public static bool IsStrongPassword(string password)
        {
            string passRegex = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*?_])[a-zA-Z\d!@#$%^&*?_]{8,30}$";
            return Regex.IsMatch(password, passRegex);
        }
    }
}
