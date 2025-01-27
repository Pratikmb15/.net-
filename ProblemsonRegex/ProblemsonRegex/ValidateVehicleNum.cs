using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsonRegex
{
    public class Vehicle {
    [Required(ErrorMessage ="Vehicle Number is Reuired")]
    [RegularExpression(@"^[A-Z]{2}\-[0-9]{2}\-[A-Z]{2}\-[0-9]{4}$",ErrorMessage ="Enter Valid vehicle Number")]
    public String VehicleNum { get; set; }
    }
    internal class ValidateVehicleNum
    {
        public static void Main(String[] args) {
            Console.Write("Enter Vehicle Number :");
            String vehicleNum = Console.ReadLine();

            Vehicle newVehicle = new Vehicle() { 
            VehicleNum= vehicleNum
            };


            var context = new ValidationContext(newVehicle);
            var result = new List<ValidationResult>();

            var isValid = Validator.TryValidateObject(newVehicle, context, result, true);

            if (isValid)
            {
                Console.WriteLine("Vehicle is registered Successfully");
            }
            else {
                foreach (var error in result)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
        }
    }
}
