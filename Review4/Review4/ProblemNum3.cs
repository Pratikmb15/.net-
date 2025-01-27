using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review4
{
    public class BankAccount
    {
        internal double Balance;
        public BankAccount(double balance)
        {
            this.Balance = balance;
        }
    }
    public class Product
    {
        public String ProductName { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

    }
    internal class ProblemNum3
    {
        public static void Main(string[] args)
        {
            try
            {
                BankAccount acc1 = new BankAccount(1000);
                BankAccount acc2 = new BankAccount(2000);


                // Transfer(acc1, acc2, 1500);
                Add(acc1, 1000);
                Transfer(acc1, acc2, 1500);

                Console.WriteLine($"Balance of acc1 : {GetBalance(acc1)}");
                Console.WriteLine($"Balance of acc2 : {GetBalance(acc2)}");

                Product newProduct = new Product()
                {
                    ProductName = "Orange Juice",
                    Price = 35,
                    Stock = 10
                };
                if (newProduct.Stock <= 0)
                {
                    throw new ProductOutOfStockException("Product is out of stock !");
                }
                else
                {
                    Console.WriteLine("New Product added successfully ");
                }
            }
            catch (InsufficientBalanceException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public static void Add(BankAccount acc, double amount)
        {
            if (acc == null)
            {
                Console.WriteLine("Invalid Account");
                return;
            }
            else
            {
                acc.Balance += amount;
                return;
            }
        }
        public static double GetBalance(BankAccount acc)
        {
            if (acc == null)
            {
                Console.WriteLine("Invalid Account");
                return 0;
            }
            else
            {
                return acc.Balance;
            }
        }

        public static void Transfer(BankAccount yourAcc, BankAccount recieverAcc, double amt)
        {
            if (yourAcc == null)
            {
                Console.WriteLine("Invalid Account");
                return;
            }
            else if (amt > yourAcc.Balance)
            {
                throw new InsufficientBalanceException("Insufficient Balance !");

            }
            else
            {
                yourAcc.Balance -= amt;
                recieverAcc.Balance += amt;
                Console.WriteLine("Money Transffered Succesfully ");
            }


        }

        public class InsufficientBalanceException : Exception
        {
            public InsufficientBalanceException(string message) : base(message)
            {
            }
        }
        public class ProductOutOfStockException : Exception
        {
            public ProductOutOfStockException(string message) : base(message)
            {
            }

        }
    }
}