using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsonRegex
{
    public class User
    {
        [Required(ErrorMessage = "Name is Required")]
        public String Name { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        [MinLength(8, ErrorMessage = "Enter Valid Password -{Minimum 8 characters are required} ")]
        public String Password { get; set; }
        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress(ErrorMessage = "Enter Valid Email")]
        public String Email { get; set; }
    }
    public class Product
    {
        [Required(ErrorMessage = "Product Name is Required")]
        [MaxLength(50, ErrorMessage = "Enter Valid Name-{Maximum Length of Name can be 50}")]
        public String ProductName { get; set; }
        [Required(ErrorMessage = "Product Price is Required")]
        [Range(1, 1000, ErrorMessage = "Enter Valid Price -{Price must be between 1 and 1000}")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Stock is Required")]
        [Range(0, int.MaxValue)]
        public int Stock { get; set; }


    }
    internal class DataAnnotationProblem
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Choose any one Options :");
            Console.WriteLine("1. Add User Details \n2. Add Product Details");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    User newUser=AddUserDetails();
                    break;
                case 2:
                   Product newProduct= AddProductDetails();
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
           
            
            Console.WriteLine();
        }
        public static User AddUserDetails() {
            Console.WriteLine("Enter User Details");
            Console.Write("Enter username :");
            String name = Console.ReadLine();
            Console.Write("Enter Password :");
            String password = Console.ReadLine();
            Console.Write("Enter Email :");
            String email = Console.ReadLine();
            User user = new User()
            {
                Name = name,
                Password = password,
                Email = email
            };
            var context = new ValidationContext(user);
            var results = new List<ValidationResult>();

            var isValid = Validator.TryValidateObject(user, context, results, true);

            if (isValid)
            {
                Console.WriteLine("User Details are Valid");
                return user;
            }
            else
            {
                foreach (var error in results)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
                return AddUserDetails();
            }

        }
        public static Product AddProductDetails() {
            Console.WriteLine("Enter Product Details");
            Console.Write("Enter Product Name :");
            String productName = Console.ReadLine();
            Console.Write("Enter Price :");
            double Price = double.Parse(Console.ReadLine());
            Console.Write("Enter Stock :");
            int stock = int.Parse(Console.ReadLine());
            Product product = new Product()
            {
                ProductName = productName,
                Price = Price,
                Stock = stock
            };
            var context1 = new ValidationContext(product);
            var results1 = new List<ValidationResult>();
            var isValidProduct = Validator.TryValidateObject(product, context1, results1, true);
            if (isValidProduct)
            {
                Console.WriteLine("Product Details are Valid ");
                return product;
            }
            else
            {
                foreach (var i in results1)
                {
                    Console.WriteLine(i.ErrorMessage);
                }
                return AddProductDetails();
            }

        }

    }
}
