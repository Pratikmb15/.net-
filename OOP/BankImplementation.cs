using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class BankImplementation : Bank
    {
        private float balance =25000F;
        public override void credit(int password,float money)
        {
            if (login(password))
            {
                getBalance();
                setBalance(balance += money);
                Console.WriteLine($"Money Credited Successfully and your Current balance is {balance}");
            }
            else {
                Console.WriteLine("Credit fail Due to invalid password!");
            }
            
        }

        

        public override void Debit(int password, float money)
        {
            if (login(password))
            {
                if (balance >= money)
                {
                    getBalance();
                    setBalance(balance -= money);
                    Console.WriteLine($"Money Debited Successfully and your Current balance is {balance}");
                }
                else 
                {
                    Console.WriteLine("Insufficient Balance!");
                }
            }
            else
            {
                Console.WriteLine("Debit fail Due to invalid password!");
            }
        }

        public  float getBalance()
        {
            return balance;
        }

        

        public override bool login(int password)
        {
            if (password == 7722)
            {
                return true;
            }
            else 
            { 
                return false;
            }
        }

        public void setBalance(float newbalance)
        {  
            balance = newbalance;
        }
    }
}
