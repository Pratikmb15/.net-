using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message)
        {

        }
    }
    class Account
    {
        public int Accountno { get; set; }
        public String Name { get; set; }
        public String Password { get; set; }
        public double Balance { get; set; }
    }
    internal class Bank
    {
        public static void Main()
        {
            try
            {
                List<Account> accounts = new List<Account>() {
        new Account{Accountno =12345678, Name= "Pratik",Password="acd143",Balance=25009 },
        new Account{Accountno =28527741, Name= "Samyak",Password="dfg954",Balance=5005 },
        new Account{Accountno =30524848, Name= "Shrishti",Password="kld803",Balance=55050 },
        new Account{Accountno =19520546, Name= "Akruti",Password="hru235",Balance=40010 },
        new Account{Accountno =76592059, Name= "Navya",Password="pqj617",Balance=17000 },
          };
                Console.Write("Enter Account number :");
                int accountno = int.Parse(Console.ReadLine());

                Console.Write("Enter Password :");
                String passkey = Console.ReadLine();

                Console.Write("Enter Amount to be Withdraw :");
                double moneytoWithdraw = double.Parse(Console.ReadLine());

                WithDraw(accounts, accountno, passkey, moneytoWithdraw);
            }
            catch (FormatException exceptn)
            {
                Console.WriteLine(exceptn.Message);
            }


        }
        public static void WithDraw(List<Account> accounts, int accountno, String passkey, double moneytoWithdraw) {
            try
            {
                Account account = accounts.Find(x => x.Accountno == accountno);
                if (account == null)
                {
                    Console.WriteLine("Invalid Account Number !");
                    return;
                }
                if (account.Password != passkey)
                {
                    Console.WriteLine("Invalid Password !");
                    return;
                }
                if (account.Balance < moneytoWithdraw)
                {
                    throw new InsufficientBalanceException("Insufficient balance !");
                }
                account.Balance -= moneytoWithdraw;
                Console.WriteLine($"{moneytoWithdraw}rs Withdrawed Successfully");
                Console.WriteLine($"Your Current Balance is {account.Balance}rs");
            }
           
            catch (InsufficientBalanceException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }



    }
}
