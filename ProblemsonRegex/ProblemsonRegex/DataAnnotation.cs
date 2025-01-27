using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsonRegex
{
    internal class DataAnnotation
    {
        public class Employee {


        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name should be at least 3 and max 50 character long")]
        [Required]
        public string Name { get; set; }

            
        [Range(18,65,ErrorMessage ="Age must be between 18 and 65")]
        public int Age { get; set; }


        [EmailAddress(ErrorMessage ="Enter Valid Email ")]
        public String Email { get; set; }
        }
        public static void Main(String[] args) {


            Console.Write("Enter Name : ");
            String name = Console.ReadLine();

            Console.Write("Enter Age :");
            int age = int.Parse(Console.ReadLine());
            
            Console.Write("Enter Email :");
            String email = Console.ReadLine();


            Employee employee = new Employee() {
            Name= name,
            Age=age,
            Email=email
            }; 

            var context = new ValidationContext(employee);
            var results = new List<ValidationResult>();

            var isValid = Validator.TryValidateObject(employee, context, results, true);


            if (isValid)
            {
                Console.WriteLine("Employee Detais are Valid");
            }
            else
            {
                Console.WriteLine("Object is not Valid");

            }

            foreach (var error in results)
            {
                Console.WriteLine(error.ErrorMessage);
            }
        }
    }
}
