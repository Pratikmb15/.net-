using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject2
{
  
    public class BankAccount
    {
        private double Balance;
        public BankAccount(double balance)
        {
            this.Balance = balance;
        }
        public static void Add(BankAccount acc, double amount) {
            if (acc == null)
            {
                Console.WriteLine("Invalid Account");
                return;
            }
            else {
                acc.Balance += amount;
                return;
            }
        }
        public static double GetBalance(BankAccount acc) {
            if (acc == null)
            {
                Console.WriteLine("Invalid Account");
                return 0;
            }
            else { 
            return acc.Balance; 
            }
        }

        public static void Transfer(BankAccount yourAcc,BankAccount recieverAcc,double amt) 
        {
            if (yourAcc == null)
            {
                Console.WriteLine("Invalid Account");
                return;
            }
            else if (amt > yourAcc.Balance)
            {
                Console.WriteLine("Insufficient Balance !");
                return;
            }
            else { 
                yourAcc.Balance -= amt;
                recieverAcc.Balance += amt;
                Console.WriteLine("Money Transffered Succesfully ");
                }

        
        }

    }
}
