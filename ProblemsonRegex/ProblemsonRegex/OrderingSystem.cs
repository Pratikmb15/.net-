using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsonRegex
{
    public class Order {
    [RegularExpression(@"^ORD-\d+$",ErrorMessage ="OrderId must start with 'ORD-'")] 
    [Required(ErrorMessage ="OrderId is required ")]
    public String OrderId { get; set; }

    [Required(ErrorMessage ="Order Date is Required")]
    [DataType(DataType.Date)]
    public String OderDate { get; set; }
   
    [Range(1,int.MaxValue)]
    public double price { get; set; }  
    }
    internal class OrderingSystem
    {
        public static void Main() {

            Console.WriteLine("Enter Order Details ");
            Console.WriteLine("Enter OrderId : ");
            String OrderId = Console.ReadLine();
            Console.WriteLine("Enter Order Date :");
            String Orderdate= Console.ReadLine();
            Console.WriteLine("Enter Price : ");
            double price = double.Parse(Console.ReadLine());

            Order newOrder = new Order() {
            OrderId= OrderId,
            OderDate= Orderdate,
            price= price
            };

            var context = new ValidationContext(newOrder);
            var results = new List<ValidationResult>();

            var isValid = Validator.TryValidateObject(newOrder, context, results, true);

            if (isValid)
            {
                Console.WriteLine("Order details are Valid ");
            }
            else 
            {
                foreach (var errors in results) {
                    Console.WriteLine(errors.ErrorMessage);
                }
            } 

        }
    }
}
