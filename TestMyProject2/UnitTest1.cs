using MyProject2;

namespace TestMyProject2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddingFundsUpdatesBalance()
        {
            //Arrange
            var account = new BankAccount(2500);
            double amountToAdd = 500;
            double expectedBalance = 3000;

            //Act
            BankAccount.Add(account,amountToAdd);
            double currentBalance = BankAccount.GetBalance(account);

            //Assert
            Assert.AreEqual(expectedBalance, currentBalance);

        }
        [Test]
        public void CheckCurrentBalance() {
            //Arrange 
            var newAccount = new BankAccount(12560);
            double ExpectedBalance = 12560;

            //Act
            double currentBalance = BankAccount.GetBalance(newAccount);

            //Assert
            Assert.AreEqual(currentBalance,ExpectedBalance);

        
        }

        [Test]
        public void TransferFundsToAnotherAccount() { 
        
            //Arrange
            var senderAccount = new BankAccount(5000);
            var recieverAccount = new BankAccount(1300);
            double amountTobeSend = 1000;
            double expectedBalanceofSender = 4000;
            double expectedBalanceofReciever = 2300;

            //Act
            BankAccount.Transfer(senderAccount,recieverAccount,amountTobeSend);

            double sendersCurrentBalance = BankAccount.GetBalance(senderAccount);
            double recieversCurrentBalance = BankAccount.GetBalance(recieverAccount);

            //Assert
            Assert.AreEqual(expectedBalanceofSender, sendersCurrentBalance);
            Assert.AreEqual(expectedBalanceofReciever,recieversCurrentBalance);
        
        
        }
    }
}