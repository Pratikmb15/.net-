using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsonRegex
{
    public class Creditcard
    {
        [Required(ErrorMessage = "Card Number is required")]
        [RegularExpression(@"^(?:[0-9]{4}\-[0-9]{4}\-[0-9]{4}\-[0-9]{4}|[0-9]{10})$",
            ErrorMessage = "Invalid card number format. Use XXXX-XXXX-XXXX-XXXX or a 10-digit number.")]
        public string Cardnumber { get; set; }

        [Required(ErrorMessage = "CVV is required")]
        [StringLength(3, MinimumLength = 3, ErrorMessage = "CVV must be exactly 3 digits")]
        [RegularExpression(@"^\d{3}$", ErrorMessage = "CVV must be numeric and exactly 3 digits")]
        public string CVV { get; set; }
    }
    internal class ValidateCreditCard
    {
        public static void Main()
        {
            Console.Write("Enter Credit Card Number :");
            String creditCardNum = Console.ReadLine();

            Creditcard MycreditCard = new Creditcard()
            { 
            Cardnumber = creditCardNum
            };
            
            var context = new ValidationContext(MycreditCard);
            var results = new List<ValidationResult>();

            var isValidCreditCard = Validator.TryValidateObject(MycreditCard, context, results,true);


            if (isValidCreditCard)
            {
                Console.WriteLine("Credit Card Number is Valid");
            }
            else
            {
                Console.WriteLine("Enter Valid Credit Card Number");
                foreach(var eror in results)
                {
                    Console.WriteLine(eror.ErrorMessage);
                }
            }
        }
    }
}
